using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace BarCodeGenerator.BarCodeGenerator
{
    public class GenerateBarCode1DFormat
    {
        internal async Task<T> GenerateBarCode39<T>(BarCodeSettings barCodeSettings)
        {
            BarCodeInformation barCodeData = new BarCodeInformation();
            string imagePath = Lib.ImagesServerPath(barCodeSettings.ImageFormat);
            await Task.Run(() => {
                
            });
            return (T)Convert.ChangeType(barCodeData, typeof(T));
        }

        internal async Task<T> GenerateBarCode128<T>(BarCodeSettings barCodeSettings)
        {
            BarCodeInformation barCodeData = new BarCodeInformation();
            string imagePath = Lib.ImagesServerPath(barCodeSettings.ImageFormat);
            await Task.Run(() => {
                PointF oPoint = new PointF(2f, 2f);
                ImageFormat imageFormat = barCodeSettings.ImageFormat;
                Bitmap oBitmap = new Bitmap(barCodeSettings.Width, barCodeSettings.Height);
                oBitmap.SetResolution(90, 90);
                Graphics oGraphics = Graphics.FromImage(oBitmap);
                SolidBrush oBrushWrite = new SolidBrush(barCodeSettings.ForeColor);
                Font oFont = new Font("Libre Barcode 128 Text", barCodeSettings.FontSize);
                SolidBrush oBrush = new SolidBrush(barCodeSettings.BackgroundColor);
                oGraphics.FillRectangle(oBrush, 0, 0, barCodeSettings.Width, barCodeSettings.Height);
                oGraphics.DrawString(barCodeSettings.BarCodeText, oFont, oBrushWrite, oPoint);
                oBitmap.Save(imagePath, imageFormat);
                Image image = Image.FromFile(imagePath);
                using (MemoryStream memoryStram = new MemoryStream())
                {
                    image.Save(memoryStram, imageFormat);
                    byte[] imageBytes = memoryStram.ToArray();
                    barCodeData.Base64String = Convert.ToBase64String(imageBytes);
                }
                barCodeData.Data = barCodeSettings.BarCodeText;
                barCodeData.ImageFormat = barCodeSettings.ImageFormat.ToString();
            });
            return (T)Convert.ChangeType(barCodeData, typeof(T));
        }
    }
}
