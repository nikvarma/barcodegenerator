using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace BarCodeGenerator.BarCodeGenerator
{
    public class GenerateBarCode
    {
        public async Task<T> GetBarCode<T>(BarCodeSettings barCodeSettings)
        {
            Object barCodeData = null;
            GenerateBarCodeOnType generateBarCodeOnType = new GenerateBarCodeOnType();
            switch (barCodeSettings.BarCodeFormat)
            {
                case BarCodeFormat.OneDimensional:
                    barCodeData = await generateBarCodeOnType.Generate1DBarCode<T>(barCodeSettings);
                    break;
                case BarCodeFormat.TwoDimensional:
                    barCodeData = await generateBarCodeOnType.Generate2DBarCode<T>(barCodeSettings);
                    break;
                default:
                    break;
            }
            return (T)Convert.ChangeType(barCodeData, typeof(T));
        }
    }
}