using System.Drawing;

namespace UITestDirect2.Core.Helpers
{
    public static class ImageCompare
    {
        /// <summary>
        /// Comparing two images with tolerance
        /// </summary>
        /// <param name="firstImage"></param>
        /// <param name="secondImage"></param>
        /// <param name="tolerance">in percents</param>
        /// <returns></returns>
        public static double PercentDifferenceImages(Bitmap firstImage, Bitmap secondImage)
        {
            bool flag = true;
            string firstPixel;
            string secondPixel;
            int countDif = 0;

            if (firstImage.Width == secondImage.Width && firstImage.Height == secondImage.Height)
            {
                for (int i = 0; i < firstImage.Width; i++)
                {
                    for (int j = 0; j < firstImage.Height; j++)
                    {
                        firstPixel = firstImage.GetPixel(i, j).ToString();
                        secondPixel = secondImage.GetPixel(i, j).ToString();
                        if (firstPixel != secondPixel)
                        {
                            countDif++;
                        }
                    }
                }
            }
            else
            {
                return 100.00;
            }

            return (double)countDif * 100.00 / (firstImage.Width * firstImage.Height);
        }

    }
}
