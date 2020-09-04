using System.Drawing;
using System.Drawing.Imaging;
using Spire.Barcode;

namespace Library
{
    public class QRcode
    {
        public static void CreateQR(string str , string savePath ,  int width = 10 )
        {
            BarcodeSettings.ApplyKey("Free");
            BarcodeSettings settings = new BarcodeSettings();
            settings.Type = BarCodeType.QRCode;
            settings.Unit = GraphicsUnit.Pixel;
            settings.ShowText = false;
            settings.ResolutionType = ResolutionType.UseDpi;
            settings.Data = str;
            settings.X = width;
            BarCodeGenerator generator = new BarCodeGenerator(settings);
            Image QRbarcode = generator.GenerateImage();
            QRbarcode.Save(savePath, ImageFormat.Png);
        }
    }
}