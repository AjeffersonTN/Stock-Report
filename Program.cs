using System;
using System.Collections.Generic;

namespace dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> stocks = new Dictionary<string, string>();
                stocks.Add("GM", "General Motors");
                stocks.Add("CAT", "Caterpillar");
                stocks.Add("MS", "Microsoft");
                stocks.Add("FD", "Ford");
                string CAT = stocks["CAT"];

        foreach (KeyValuePair<string, string> stock in stocks)
        {
        Console.WriteLine($"{stock.Key} is equal to {stock.Value}");
        }
        List<Dictionary<string, double>> purchases = new List<Dictionary<string, double>>();

        purchases.Add (new Dictionary<string, double>(){ {"GM", 230.21} });
        purchases.Add (new Dictionary<string, double>(){ {"GM", 580.98} });
        purchases.Add (new Dictionary<string, double>(){ {"CAT", 406.34} });
        purchases.Add (new Dictionary<string, double>(){ {"CAT", 406.34} });
        purchases.Add (new Dictionary<string, double>(){ {"MS", 418.94} });
        purchases.Add (new Dictionary<string, double>(){ {"FD", 406.34} });
        purchases.Add (new Dictionary<string, double>(){ {"FD", 500.00} });

         Dictionary<string, double> stockReport = new Dictionary<string, double>();

         foreach (Dictionary<string, double> purchase in purchases)
            {
                foreach (KeyValuePair<string, double> stock in purchase)
                {
                    string fullName = stocks[stock.Key];

                    if (stockReport.ContainsKey(fullName)){
                       stockReport[fullName] += stock.Value;
                    }
                    else{
                     stockReport.Add(fullName, stock.Value);

                    }
                    // Does the full company name key already exist in the `stockReport`?

                    // If it does, update the total valuation

                    /*
                        If not, add the new key and set its value.
                        You have the value of "GE", so how can you look
                        the value of "GE" in the `stocks` dictionary
                        to get the value of "General Electric"?
                    */
                }
            }
            foreach (KeyValuePair<string, double> stock in stockReport)
        {
        Console.WriteLine($"{stock.Key} is equal to {stock.Value}");
        }

        }
    }
}
