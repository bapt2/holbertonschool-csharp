using System.Collections.Generic;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System;

class ImageProcessor
{

    /// <summary>
    /// public static void Inverse
    /// </summary>
    /// <param name="filenames"></param>
    public static void Inverse(string[] filenames)
    {
        Parallel.ForEach(filenames, filename =>
        {
            string newfilename = Path.GetFileNameWithoutExtension(filename) + "_inverse.jpg";
            Bitmap bmp = new Bitmap(filename);

            int width = bmp.Width;
            int height = bmp.Height;

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color p = bmp.GetPixel(x, y);

                    int a = p.A;
                    int r = p.R;
                    int g = p.G;
                    int b = p.B;

                    r = 255 - p.R;
                    g = 255 - p.G;
                    b = 255 - p.B;

                    bmp.SetPixel(x, y, Color.FromArgb(a, r, g, b));
                }
            }

            bmp.Save(newfilename);
        });
    }

    /// <summary>
    /// public static void Grayscale
    /// </summary>
    /// <param name="filenames"></param>
    public static void Grayscale(string[] filenames)
    {
        Parallel.ForEach(filenames, filename =>
        {
            string newfilename = Path.GetFileNameWithoutExtension(filename) + "_grayscale.jpg";
            Bitmap bmp = new Bitmap(filename);

            int width = bmp.Width;
            int height = bmp.Height;

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color p = bmp.GetPixel(x, y);

                    int gray = (p.R + p.G + p.B) / 3;
                    bmp.SetPixel(x, y, Color.FromArgb(gray, gray, gray));
                }
            }

            bmp.Save(newfilename);
        });
    }

    /// <summary>
    /// public static void BlackWhite
    /// </summary>
    /// <param name="filenames"></param>
    /// <param name="threshold"></param>
    public static void BlackWhite(string[] filenames, double threshold)
    {
        Parallel.ForEach(filenames, filename =>
        {
            string newfilename = Path.GetFileNameWithoutExtension(filename) + "_bw.jpg";
            Bitmap bmp = new Bitmap(filename);

            int width = bmp.Width;
            int height = bmp.Height;

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color p = bmp.GetPixel(x, y);
                    if (p.GetBrightness() < threshold)
                    {
                        bmp.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                    }
                    else
                    {
                        bmp.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                    }
                    
                }
            }

            bmp.Save(newfilename);
        });
    }

    /// <summary>
    /// public static void Thumbnail
    /// </summary>
    /// <param name="filenames"></param>
    /// <param name="height"></param>
    public static void Thumbnail(string[] filenames, int height)
    {
        Parallel.ForEach(filenames, filename =>
        {
            string newfilename = Path.GetFileNameWithoutExtension(filename) + "_th.jpg";
            Bitmap bmp = new Bitmap(filename);

            int oldwidth = bmp.Width;
            int oldheight = bmp.Height;

            int width = oldwidth / oldwidth * height;

            Bitmap thumbnail = new Bitmap(bmp, new Size(width, height));

            thumbnail.Save(newfilename);
        });
    }
}