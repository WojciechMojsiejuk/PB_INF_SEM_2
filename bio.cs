using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;

namespace ConsoleApplication2
{
    class Picture
    {
        public static unsafe Bitmap Apply(string filename)
        {
            Bitmap bitmap;
            try
            {
                bitmap = new Bitmap(filename);
            }
            catch(FileNotFoundException)
            {
                return null;
            }
            Bitmap newBitmap = new Bitmap(bitmap.Width, bitmap.Height);
            BitmapData readData = bitmap.LockBits(new Rectangle(Point.Empty, bitmap.Size),
                ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            BitmapData writeData = newBitmap.LockBits(new Rectangle(Point.Empty, bitmap.Size),
               ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);
            byte* read = (byte*)readData.Scan0.ToPointer();
            byte* write = (byte*)writeData.Scan0.ToPointer();
            for (int i = 1; i < bitmap.Height-1; i++)
            {
                for (int j = 3; j < readData.Stride-3; j++)
                {
                    int offset = i * readData.Stride + j;
                    List<byte> bytes = new List<byte>()
                    {
                        read[offset + readData.Stride],read[offset+3+readData.Stride], read[offset-3+readData.Stride],
                        read[offset],read[offset+3], read[offset-3],
                        read[offset - readData.Stride],read[offset+3-readData.Stride], read[offset-3-readData.Stride]
                    };
                    bytes.Sort();
                    write[offset] = bytes[4];
                }
            }
            bitmap.UnlockBits(readData);
            newBitmap.UnlockBits(writeData);
            return newBitmap;

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Picture.Apply("apple2.png")?.Save("apple3.png");
            
           

        }
    }
}
