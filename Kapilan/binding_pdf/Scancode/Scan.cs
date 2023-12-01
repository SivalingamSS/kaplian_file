using System.Drawing;
using ZXing;
using ZXing.QrCode;

namespace binding_pdf.Scancode
{
    public class QRCodeDecoder
    {
        public string DecodeQRCode(byte[] qrCodeImageBytes)
        {
            try
            {
                QR barcodeReader = new BarcodeReader();
                Result result = barcodeReader.Decode(qrCodeImageBytes);
                if (result != null)
                {
                    return result.Text;
                }
                else
                {       
                    return "QR code could not be decoded.";
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions, such as image data not being a valid QR code
                return "An error occurred: " + ex.Message;
            }
        }
    }
}
