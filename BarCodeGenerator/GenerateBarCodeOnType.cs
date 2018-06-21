using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace BarCodeGenerator.BarCodeGenerator
{
    public class GenerateBarCodeOnType
    {
        internal async Task<T> Generate1DBarCode<T>(BarCodeSettings barCodeSettings)
        {
            Object barCodeData = null;
            GenerateBarCode1DFormat generateBarCode1DFormat = new GenerateBarCode1DFormat();
            switch (barCodeSettings.BarCodeType.BarCode1DType)
            {
                case BarCode1DType.AustraliaPost:
                    break;
                case BarCode1DType.Codabar:
                    break;
                case BarCode1DType.Code25:
                    break;
                case BarCode1DType.Code11:
                    break;
                case BarCode1DType.Code32:
                    break;
                case BarCode1DType.Code39:
                    barCodeData = await generateBarCode1DFormat.GenerateBarCode39<T>(barCodeSettings);
                    break;
                case BarCode1DType.Code49:
                    break;
                case BarCode1DType.Code93:
                    break;
                case BarCode1DType.Code128:
                    barCodeData = await generateBarCode1DFormat.GenerateBarCode128<T>(barCodeSettings);
                    break;
                case BarCode1DType.DXFilmEdgeBarCode:
                    break;
                case BarCode1DType.EAN2:
                    break;
                case BarCode1DType.EAN5:
                    break;
                case BarCode1DType.EAN8:
                    break;
                case BarCode1DType.EAN813:
                    break;
                case BarCode1DType.GS1128:
                    break;
                case BarCode1DType.GS1DataBar:
                    break;
                case BarCode1DType.IntelligentMailBarCode:
                    break;
                case BarCode1DType.ITF14:
                    break;
                case BarCode1DType.JAN:
                    break;
                case BarCode1DType.JapanPost:
                    break;
                case BarCode1DType.KarTrakACI:
                    break;
                case BarCode1DType.MSI:
                    break;
                case BarCode1DType.PharmaCode:
                    break;
                case BarCode1DType.PLANET:
                    break;
                case BarCode1DType.Plessey:
                    break;
                case BarCode1DType.PostBar:
                    break;
                case BarCode1DType.POSTNET:
                    break;
                case BarCode1DType.RM4SCCKIX:
                    break;
                case BarCode1DType.RMMailmarkC:
                    break;
                case BarCode1DType.Telepen:
                    break;
                case BarCode1DType.UPCA:
                    break;
                case BarCode1DType.UPCE:
                    break;
                default:
                    break;
            }
            return (T)Convert.ChangeType(barCodeData, typeof(T));
        }

        internal async Task<object> Generate2DBarCode<T>(BarCodeSettings barCodeSettings)
        {
            object barCodeData = null;
            switch (barCodeSettings.BarCodeType.BarCode2DType)
            {
                case BarCode2DType.AztecCode:
                    break;
                case BarCode2DType.CrontoSign:
                    break;
                case BarCode2DType.DataMatrix:
                    break;
                case BarCode2DType.DotCode:
                    break;
                case BarCode2DType.EZcode:
                    break;
                case BarCode2DType.HighCapacityColorBarcode:
                    break;
                case BarCode2DType.HanXinBarcode:
                    break;
                case BarCode2DType.MaxiCode:
                    break;
                case BarCode2DType.NexCode:
                    break;
                case BarCode2DType.PDF417:
                    break;
                case BarCode2DType.Qode:
                    break;
                case BarCode2DType.QRCode:
                    break;
                case BarCode2DType.ARCode:
                    break;
                case BarCode2DType.ShotCode:
                    break;
                case BarCode2DType.SPARQCode:
                    break;
                default:
                    break;
            }
            return (T)Convert.ChangeType(barCodeData, typeof(T));
        }
    }
}