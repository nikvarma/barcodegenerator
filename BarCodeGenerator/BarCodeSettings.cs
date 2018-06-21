using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Web;

namespace BarCodeGenerator.BarCodeGenerator
{
    public class BarCodeSettings
    {
        public BarCodeSettings()
        {
            Width = 180;
            Height = 65;
            ForeColor = Color.Black;
            BackgroundColor = Color.White;
            ImageFormat = ImageFormat.Gif;
            BarCodeFormat = BarCodeFormat.None;
            OutputFormat = OutputFormat.Base64String;
        }

        public int Width { get; set; }
        public int Height { get; set; }
        public Color ForeColor { get; set; }
        public Color BackgroundColor { get; set; }
        public ImageFormat ImageFormat { get; set; }
        public int FontSize { get; set; }
        public BarCodeFormat BarCodeFormat { get; set; }
        public BarCodeTypes BarCodeType { get; set; }
        public string BarCodeText { get; set; }
        public OutputFormat OutputFormat { get; set; }
    }

    public class BarCodeTypes
    {
        public BarCode1DType BarCode1DType { get; set; }
        public BarCode2DType BarCode2DType { get; set; }
    }
}