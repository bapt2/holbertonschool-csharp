using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

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
            // lire l'image
            Bitmap bmp = new Bitmap(filename);

            // prendre la dimension de l'image 
            int width = bmp.Width;
            int height = bmp.Height;

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    // récuperer la valeur de chaque pixel
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
            // lire l'image
            Bitmap bmp = new Bitmap(filename);

            // prendre la dimension de l'image 
            int width = bmp.Width;
            int height = bmp.Height;

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    // récuperer la valeur de chaque pixel
                    Color p = bmp.GetPixel(x, y);

                    bmp.SetPixel(x, y, Color.FromArgb(p.R, 0, 0));
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

    }

    /// <summary>
    /// public static void Thumbnail
    /// </summary>
    /// <param name="filenames"></param>
    /// <param name="height"></param>
    public static void Thumbnail(string[] filenames, int height)
    {

    }
}