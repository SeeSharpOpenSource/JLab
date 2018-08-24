using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MACOs.JY.Drawing
{
    public class Graphs
    {
        public unsafe static Bitmap DensityGraph(double[,] data, ref Bitmap image, bool greyscale = false, double rangeHigh = 0, double rangeLow = 0)
        {
            Bitmap imgBuffer = (Bitmap)image.Clone();
            BitmapData bitmapData = imgBuffer.LockBits(new Rectangle(0, 0, imgBuffer.Width, imgBuffer.Height), ImageLockMode.ReadWrite, imgBuffer.PixelFormat);

            int bytesPerPixel = Bitmap.GetPixelFormatSize(imgBuffer.PixelFormat) / 8;
            int heightInPixels = bitmapData.Height;
            int widthInBytes = bitmapData.Width * bytesPerPixel;
            byte* PtrFirstPixel = (byte*)bitmapData.Scan0;
            bool isAutoscale = rangeHigh - rangeLow == 0;
            double maxValue = isAutoscale ? data.Cast<double>().Max() : rangeHigh;
            double minValue = isAutoscale ? data.Cast<double>().Min() : rangeLow;
            
            Parallel.For(0, heightInPixels, y =>
            {
                byte* currentLine = PtrFirstPixel + (y * bitmapData.Stride);
                int red;
                int green;
                int blue;
                double h, s, v;

                for (int x = 0; x < bitmapData.Width; x++)
                {
                    double value = Math.Min(maxValue, data[y, x]);
                    value = Math.Max(minValue, data[y, x]);
                    value = maxValue - minValue == 0 ? 0 : (value - minValue) / (maxValue - minValue);

                    h = greyscale ? 0 : 360.0 * value;
                    s = greyscale ? 0 : 1;
                    v = greyscale ? value : 1;

                    HsvToRgb(h,s,v, out red, out green, out blue);

                    currentLine[x * bytesPerPixel] = (byte)red;
                    currentLine[x * bytesPerPixel + 1] = (byte)green;
                    currentLine[x * bytesPerPixel + 2] = (byte)blue;
                }
            });
            imgBuffer.UnlockBits(bitmapData);
            return imgBuffer;
        }

        public static void HsvToRgb(double h, double S, double V, out int r, out int g, out int b)
        {
            
            h = h < 0 ? 360 + h : h;
            h = h >= 360 ? h % 360 : h;

            if (V<=0)
            {
                r = g = b = 0;
                return;
            }
            else if (S<=0)
            {
                r = g = b = (int)(V*255.0);
                return;
            }            
            else
            {
                double hf = h / 60.0;
                int i = (int)Math.Floor(hf);
                double f = hf - i;
                double pv = V * (1 - S);
                double qv = V * (1 - S * f);
                double tv = V * (1 - S * (1 - f));
                switch (i)
                {

                    // Red is the dominant color
                    case 0:
                        r = (int)(V * 255.0);
                        g = (int)(tv * 255.0);
                        b = (int)(pv * 255.0);
                        return;

                    // Green is the dominant color
                    case 1:
                        r = (int)(qv*255.0);
                        g = (int)(V * 255.0);
                        b = (int)(pv * 255.0);
                        return;
                    case 2:
                        r = (int)(pv * 255.0);
                        g = (int)(V * 255.0);
                        b = (int)(tv * 255.0);
                        return;

                    // Blue is the dominant color
                    case 3:
                        r = (int)(pv * 255.0);
                        g = (int)(qv * 255.0);
                        b = (int)(V * 255.0);
                        return;
                    case 4:
                        r = (int)(tv * 255.0);
                        g = (int)(pv * 255.0);
                        b = (int)(V * 255.0);
                        return;

                    // Red is the dominant color
                    case 5:
                        r = (int)(V * 255.0);
                        g = (int)(pv * 255.0);
                        b = (int)(qv * 255.0);
                        return;

                    // Just in case we overshoot on our math by a little, we put these here. Since its a switch it won't slow us down at all to put these here.
                    case 6:
                        r = (int)(V * 255.0);
                        g = (int)(tv * 255.0);
                        b = (int)(pv * 255.0);
                        return;
                    case -1:
                        r = (int)(V * 255.0);
                        g = (int)(pv * 255.0);
                        b = (int)(qv * 255.0);
                        return;

                    // The color is not defined, we should throw an error.

                    default:
                        //LFATAL("i Value error in Pixel conversion, Value is %d", i);
                        r=g=b=(int)(V*255.0); // Just pretend its black/white
                        return;
                }
            }
        }
    }

}
