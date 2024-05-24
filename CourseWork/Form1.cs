using DocumentFormat.OpenXml.Office.Drawing;
using Microsoft.VisualBasic.Devices;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class Form1 : Form
    {
        private List<Pixel> pixels;

        private Bitmap originalBitmap;
        private List<Pixel> originalPixels;


        public Form1()
        {
            InitializeComponent();
        }

        private Bitmap CreateBitmapFromPixels(List<Pixel> pixels, int width, int height)
        {

            Bitmap bitmap = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        Pixel pixel = pixels[y * width + x];
                        bitmap.SetPixel(x, y, pixel.Color);
                    }
                }
            }
            return bitmap;
        }

        private async void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = null;
                var bitmap = new Bitmap(openFileDialog1.FileName);

                pictureBox1.Image = bitmap;
                pixels = GetPixels(bitmap); // сохраняем пиксели

                originalPixels = new List<Pixel>(pixels.Select(pixel => new Pixel(pixel))); // глубоко копируем список оригинальных пикселей,
                                                                                            // чтобы потом создать независимый bitmap
                originalBitmap = CreateBitmapFromPixels(originalPixels, bitmap.Width, bitmap.Height); ; // сохраняем оригинальное изображение

                // Получаем среднее значение между минимальным и максимальным значениями
                int middleValue = (trackBar1.Minimum + trackBar1.Maximum) / 2;
                int middleValueHue = (trackBar3.Minimum + trackBar3.Maximum) / 2;

                // Устанавливаем значение ползунка в середину диапазона
                trackBar1.Value = middleValue;
                trackBar2.Value = middleValue;
                trackBar3.Value = middleValueHue;
            }
        }

        private List<Pixel> GetPixels(Bitmap bitmap)
        {
            var pixels = new List<Pixel>(bitmap.Width * bitmap.Height);

            for (int y = 0; y < bitmap.Height; y++)
            {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    pixels.Add(new Pixel()
                    {
                        Color = bitmap.GetPixel(x, y),
                        Point = new Point { X = x, Y = y }
                    });
                }
            }
            return pixels;
        }

        private void ChangeSaturation(Pixel pixel, float saturation)
        {
            Color originalColor = pixel.Color;
            float h = originalColor.GetHue();
            float s = originalColor.GetSaturation() + saturation;
            float l = originalColor.GetBrightness();
            if (s < 0) { s = 0; }
            if (s > 1) { s = 1; }
            pixel.SetHSL(h, s, l);
        }

        private void ChangeLightness(Pixel pixel, float lightness)
        {
            Color originalColor = pixel.Color;
            float h = originalColor.GetHue();
            float s = originalColor.GetSaturation();
            float l = originalColor.GetBrightness() + lightness;
            if (l < 0) { l = 0; }
            else if (l > 1) { l = 1; }
            pixel.SetHSL(h, s, l);
        }

        private void ChangeHue(Pixel pixel, float hue)
        {
            Color originalColor = pixel.Color;
            float h = (originalColor.GetHue() + hue) % 360; // Оттенок находится в диапазоне [0, 360], поэтому используем операцию модуля для обработки выхода за границы
            float s = originalColor.GetSaturation();
            float l = originalColor.GetBrightness();
            pixel.SetHSL(h, s, l);
        }

        private float defaultValue1 = 0.5f; // Переменная для хранения предыдущего значения ползунка
        private float lightDelt = 0;

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (pixels == null)
            {
                return;
            }

            float currentValue = trackBar1.Value / 100f;

            float deltaLightness = currentValue - defaultValue1;

            var tempBitmap = CreateBitmapFromPixels(pixels, originalBitmap.Width, originalBitmap.Height);
            var tempPixels = new List<Pixel>(pixels.Select(pixel => new Pixel(pixel)));

            foreach (var pixel in tempPixels)
            {
                ChangeLightness(pixel, deltaLightness);
                ChangeHue(pixel, hueDelt);
                ChangeSaturation(pixel, saturDelt);
                tempBitmap.SetPixel(pixel.Point.X, pixel.Point.Y, pixel.Color); // 
            }

            pictureBox1.Image = tempBitmap;
            lightDelt = deltaLightness;
        }

        private float previousValue2 = 0.5f;
        private float saturDelt = 0;

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            if (pixels == null)
            {
                return;
            }

            float currentValue = trackBar2.Value / 100f;

            float deltaSatur = currentValue - previousValue2;

            var tempBitmap = CreateBitmapFromPixels(pixels, originalBitmap.Width, originalBitmap.Height);
            var tempPixels = new List<Pixel>(pixels.Select(pixel => new Pixel(pixel)));

            foreach (var pixel in tempPixels)
            {
                ChangeLightness(pixel, lightDelt);
                ChangeHue(pixel, hueDelt);
                ChangeSaturation(pixel, deltaSatur);
                tempBitmap.SetPixel(pixel.Point.X, pixel.Point.Y, pixel.Color);
            }

            pictureBox1.Image = tempBitmap;
            saturDelt = deltaSatur;
        }

        private int previousValue3 = 180;

        private float hueDelt = 0;
        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            if (pixels == null)
            {
                return;
            }

            int currentValue = trackBar3.Value;

            float deltaHue = currentValue - previousValue3;

            var tempBitmap = CreateBitmapFromPixels(pixels, originalBitmap.Width, originalBitmap.Height);
            var tempPixels = new List<Pixel>(pixels.Select(pixel => new Pixel(pixel)));

            foreach (var pixel in tempPixels)
            {
                ChangeHue(pixel, deltaHue);
                ChangeLightness(pixel, lightDelt);
                ChangeSaturation(pixel, saturDelt);
                tempBitmap.SetPixel(pixel.Point.X, pixel.Point.Y, pixel.Color);
            }

            pictureBox1.Image = tempBitmap;
            hueDelt = deltaHue;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pixels == null)
            {
                MessageBox.Show("Вы не можете сохранить изображение, так как оно отсутствует", "Ошибка сохранения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            saveFileDialog1.Filter = "PNG files (*.png)|*.png|JPEG files (*.jpg)|*.jpg|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1; // Устанавливаем PNG как формат по умолчанию

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog1.FileName;

                string extension = Path.GetExtension(filePath);

                ImageFormat imageFormat = ImageFormat.Png;
                if (extension.Equals(".jpg", StringComparison.OrdinalIgnoreCase) || extension.Equals(".jpeg", StringComparison.OrdinalIgnoreCase))
                {
                    imageFormat = ImageFormat.Jpeg;
                }

                pictureBox1.Image.Save(filePath, imageFormat);
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox = new AboutBox1();

            // Отображение окна
            aboutBox.ShowDialog();
        }

        private void SetBW()
        {
            var tempBitmap = new Bitmap(originalBitmap);

            foreach (var pixel in pixels)
            {
                ChangeSaturation(pixel, -1f);
                tempBitmap.SetPixel(pixel.Point.X, pixel.Point.Y, pixel.Color);
            }
            pictureBox1.Image = tempBitmap;

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (pixels == null)
            {
                return;
            }

            if (checkBox1.Checked == true)
            {
                SetBW();

                var tempBitmap = CreateBitmapFromPixels(pixels, originalBitmap.Width, originalBitmap.Height);
                var tempPixels = new List<Pixel>(pixels.Select(pixel => new Pixel(pixel)));

                foreach (var pixel in pixels)
                {
                    ChangeSaturation(pixel, 0.5f);
                    tempBitmap.SetPixel(pixel.Point.X, pixel.Point.Y, pixel.Color);
                }

                pictureBox1.Image = tempBitmap;

            }
            else if (checkBox1.Checked == false)
            {

                pixels = new List<Pixel>(originalPixels.Select(pixel => new Pixel(pixel)));

                float currentValue1 = trackBar1.Value / 100f;
                float currentValue2 = trackBar2.Value / 100f;
                float currentValue3 = trackBar3.Value;

                float deltaL = currentValue1 - defaultValue1;
                float deltaS = currentValue2 - previousValue2;
                float deltaH = currentValue3 - previousValue3;

                var tempBitmap = CreateBitmapFromPixels(pixels, originalBitmap.Width, originalBitmap.Height);
                var tempPixels = new List<Pixel>(pixels.Select(pixel => new Pixel(pixel)));

                foreach (var pixel in tempPixels)
                {
                    ChangeLightness(pixel, deltaL);
                    ChangeHue(pixel, deltaH);
                    ChangeSaturation(pixel, deltaS);
                    tempBitmap.SetPixel(pixel.Point.X, pixel.Point.Y, pixel.Color); // 
                }

                pictureBox1.Image = tempBitmap;
                lightDelt = deltaL;
                saturDelt = deltaS;
                hueDelt = deltaH;
            }
        }

        private Bitmap curBitmap;
        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            if (pixels == null)
            {
                return;
            }

            int imageWidth = pictureBox1.Image.Width;
            int imageHeight = pictureBox1.Image.Height;

            curBitmap = new Bitmap(imageWidth, imageHeight);

            using (Graphics g = Graphics.FromImage(curBitmap))
            {
                // Рисуем содержимое PictureBox (изображение) на Bitmap
                g.DrawImage(pictureBox1.Image, 0, 0, imageWidth, imageHeight);
            }

            pictureBox1.Image = originalBitmap;
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            if (pixels == null)
            {
                return;
            }

            pictureBox1.Image = curBitmap;
        }

        Color drawColor = Color.Black;
        private void panel1_Click(object sender, EventArgs e)
        {
            this.colorDialog1.Color = this.pictureBox1.BackColor;
            if (this.colorDialog1.ShowDialog() == DialogResult.OK)
            {
                drawColor = this.colorDialog1.Color;
                this.panel1.BackColor = drawColor;
                this.panel2.BackColor = drawColor;
            }

        }

        Graphics g;
        Point startPoint;
        private bool isMouse = false;

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (pixels == null)
            {
                return;
            }
            isMouse = true;
            g = Graphics.FromImage(pictureBox1.Image);
            startPoint = GetImageCoordinates(e.Location);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouse)
            {
                Point endPoint = GetImageCoordinates(e.Location);
                Pen pen = new Pen(drawColor, (float)trackBar4.Value);
                g.DrawLine(pen, startPoint, endPoint);
                pictureBox1.Invalidate();
                startPoint = endPoint;
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (pixels == null)
            {
                MessageBox.Show("Для рисования на изображении это изображение следует предварительно загрузить", "Ошибка рисования", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            isMouse = false;
            g.Dispose(); // Освобождаем ресурсы графики
        }


        private Point GetImageCoordinates(Point pictureBoxCoordinates)
        {
            // Получаем размеры изображения в pictureBox1
            int imageWidth = pictureBox1.Image.Width;
            int imageHeight = pictureBox1.Image.Height;

            // Получаем размеры pictureBox1
            int pictureBoxWidth = pictureBox1.Width;
            int pictureBoxHeight = pictureBox1.Height;

            // Вычисляем масштаб изображения по горизонтали и вертикали
            float horizontalScale = (float)pictureBoxWidth / imageWidth;
            float verticalScale = (float)pictureBoxHeight / imageHeight;

            // Используем минимальный масштаб, чтобы изображение целиком вписалось в pictureBox1
            float scale = Math.Min(horizontalScale, verticalScale);

            // Рассчитываем размеры изображения после масштабирования
            int scaledWidth = (int)(imageWidth * scale);
            int scaledHeight = (int)(imageHeight * scale);

            // Рассчитываем смещение изображения внутри pictureBox1
            int offsetX = (pictureBoxWidth - scaledWidth) / 2;
            int offsetY = (pictureBoxHeight - scaledHeight) / 2;

            // Корректируем координаты мыши, вычитая смещение и учитывая масштаб
            int imageX = (int)((pictureBoxCoordinates.X - offsetX) / scale);
            int imageY = (int)((pictureBoxCoordinates.Y - offsetY) / scale);

            return new Point(imageX, imageY);
        }
    }
}