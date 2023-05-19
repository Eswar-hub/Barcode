using Aspose.BarCode.Generation;
using Aspose.Drawing;
using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string dir = @"C:\Users\EswaraVD\OneDrive - Unisys\PCS\publish\";
            BarcodeGenerator generator = new BarcodeGenerator(EncodeTypes.Code128, "1234567");
            generator.Parameters.AutoSizeMode = AutoSizeMode.None;
            generator.Parameters.ImageWidth.Pixels = 100;
            generator.Parameters.ImageHeight.Pixels = 25;
            generator.Parameters.Barcode.XDimension.Pixels = 1;
            generator.Parameters.Barcode.CodeTextParameters.Location = CodeLocation.None;
            generator.Save(dir + "output.jpg", BarCodeImageFormat.Bmp);
        }
    }
}
