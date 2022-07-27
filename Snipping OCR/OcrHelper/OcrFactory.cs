namespace Snipping_OCR
{
    public static class OcrFactory
    {
        public static IOcr GetOcr()
        {
            // switch on type
            return new OcrTesseract();
        }
    }
}