using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using OpenCvSharp;

namespace MonitoringStudents
{
    public class RawData
    {
        public bool[,] _data;
        private int _threshold = 255 / 10;
        private int _width = 320, _height = 240;

        public Bitmap IplimageToBitmap(IplImage image)
        {
            return OpenCvSharp.Extensions.BitmapConverter.ToBitmap(image);
        }

        public Image Grayscale(IplImage image, int huddle, int headTop)
        {
            Bitmap srcBitmap = IplimageToBitmap(image);

            Size resize = new Size(_width, _height);
            Bitmap bitmap = new Bitmap(srcBitmap, resize);
            Bitmap grayscale = new Bitmap(bitmap.Width, bitmap.Height);

            for(int x = 0; x < bitmap.Width; x++)
            {
                for (int y = 0; y < bitmap.Height; y++)
                {
                    int r = bitmap.GetPixel(x, y).R;
                    int g = bitmap.GetPixel(x, y).G;
                    int b = bitmap.GetPixel(x, y).B;
                    //data[x, y] = r < _threshold && g < _threshold && b < _threshold ? false : true; // 백색 = true, 흑색 = false

                    if (y == huddle)
                    {
                        grayscale.SetPixel(x, y, Color.FromArgb(255, 255, 0, 0));
                    }
                    else if(y == headTop)
                    {
                        grayscale.SetPixel(x, y, Color.FromArgb(255, 0, 0, 255));
                    }
                    else
                    {
                        grayscale.SetPixel(
                            x, y, r < _threshold && g < _threshold && b < _threshold
                            ? Color.FromArgb(255, 0, 0, 0) : Color.FromArgb(255, 255, 255, 255));
                    }
                }
            }

            return (Image)grayscale;
        }

        public int DetectHeadTop(IplImage image)
        {
            Bitmap srcBitmap = IplimageToBitmap(image);

            Size resize = new Size(_width, _height);
            Bitmap bitmap = new Bitmap(srcBitmap, resize);

            for (int y = 0; y < bitmap.Height; y++) 
            {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    int r = bitmap.GetPixel(x, y).R;
                    int g = bitmap.GetPixel(x, y).G;
                    int b = bitmap.GetPixel(x, y).B;

                    if(r < _threshold && g < _threshold && b < _threshold)
                    {
                        return y;
                    }
                }
            }

            return -1;
        }
    }
}
