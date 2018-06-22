using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Web;

namespace BarCodeGenerator.BarCodeGenerator
{
    public class ResponseBody
    {
        public int Status { get; set; }
        public string Message { get; set; }
        public BarCodeInformation BarCodeInformation { get; set; }
    }

    public class BarCodeInformation
    {
        public object Data { get; set; }
        public string Base64String { get; set; }
        public string ImageFormat { get; set; }
    }
}