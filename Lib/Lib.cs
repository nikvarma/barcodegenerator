using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Web;

namespace BarCodeGenerator.BarCodeGenerator
{
    public static partial class Lib
    {
        public static string serverPath { get; internal set; }
        private static string _fontName = Startup._fontName;
        public static string ImagesServerPath(ImageFormat imageFormat)
        {
            return string.Format("{0}\\BarCode-Images\\{1}.{2}", new object[] { serverPath, Guid.NewGuid(), imageFormat });
        }

        private static PrivateFontCollection LoadFont()
        {
            PrivateFontCollection _font = new PrivateFontCollection();
            string path = string.Format("{0}\\App_Files\\FontCode.ttf", new object[] { serverPath });
            _font.AddFontFile(path);
            return _font;
        }

        public static FontFamily FontsFamily()
        {
            FontFamily fontFamily = new FontFamily(_fontName, LoadFont());
            return fontFamily;
        }
    }
}