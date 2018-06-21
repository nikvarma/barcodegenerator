using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BarCodeGenerator
{
    public class BarCodeTypes
    {

    }

    public enum OutputFormat
    {
        Base64String
    }
    public enum BarCodeFormat
    {
        None,
        OneDimensional,
        TwoDimensional
    }

    public enum BarCode1DType
    {
        None,
        AustraliaPost,
        Codabar,
        Code25,
        Code11,
        Code32,
        Code39,
        Code49,
        Code93,
        Code128,
        DXFilmEdgeBarCode,
        EAN2,
        EAN5,
        EAN8,
        EAN813,
        GS1128,
        GS1DataBar,
        IntelligentMailBarCode,
        ITF14,
        JAN,
        JapanPost,
        KarTrakACI,
        MSI,
        PharmaCode,
        PLANET,
        Plessey,
        PostBar,
        POSTNET,
        RM4SCCKIX,
        RMMailmarkC,
        Telepen,
        UPCA,
        UPCE
    }
    
    public enum BarCode2DType
    {
        None,
        AztecCode,
        CrontoSign,
        DataMatrix,
        DotCode,
        EZcode,
        HighCapacityColorBarcode,
        HanXinBarcode,
        MaxiCode,
        NexCode,
        PDF417,
        Qode,
        QRCode,
        ARCode,
        ShotCode,
        SPARQCode
    }
}