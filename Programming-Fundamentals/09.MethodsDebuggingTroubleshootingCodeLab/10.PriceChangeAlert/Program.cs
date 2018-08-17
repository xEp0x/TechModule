namespace _10.PriceChangeAlert
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int pricesCount = int.Parse(Console.ReadLine());
            double thresholdLimit = double.Parse(Console.ReadLine());
            double lastPrice = double.Parse(Console.ReadLine());

            for (int i = 0; i < pricesCount - 1; i++)
            {
                double currentPrice = double.Parse(Console.ReadLine());
                double percentDifference = CalcPercentDifference(lastPrice, currentPrice);
                bool isSignificantDifference = CheckPriceOverThresholdLimit(percentDifference, thresholdLimit);
                string outputMessage = Get(currentPrice, lastPrice, percentDifference, isSignificantDifference);
                Console.WriteLine(outputMessage);
                lastPrice = currentPrice;
            }
        }

        static string Get(double currentPrice, double lastPrice, double percentDifference, bool isSignificantDifference)
        {
            string outputMessage = string.Empty;
            percentDifference *= 100;

            if (percentDifference == 0)
            {
                outputMessage = string.Format("NO CHANGE: {0}", currentPrice);
            }
            else if (!isSignificantDifference)
            {
                outputMessage = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, percentDifference);
            }
            else if (isSignificantDifference && (percentDifference > 0))
            {
                outputMessage = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, percentDifference);
            }
            else if (isSignificantDifference && (percentDifference < 0))
            {
                outputMessage = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, percentDifference);
            }

            return outputMessage;
        }

        static bool CheckPriceOverThresholdLimit(double percentDifference, double ThresholdLimit)
        {
            if (Math.Abs(percentDifference) >= ThresholdLimit)
            {
                return true;
            }
            return false;
        }

        static double CalcPercentDifference(double lastPrice, double currentPrice)
        {
            double percentDifference = ((currentPrice - lastPrice) / lastPrice);

            return percentDifference;
        }
    }
}
