
using System;
using System.Collections.Generic;

namespace dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            //create stock dictionary
            Dictionary<string,string> stocks = new Dictionary<string,string>();

            //add values to stock dictionary
            stocks.Add("GM", "General Motors");
            stocks.Add("CAT", "Caterpillar");
            stocks.Add("GOOGL", "Google");
            stocks.Add("AAPL","Apple");

            //To find a value in a Dictionary, you can use square bracket notation much like JavaScript object key lookups.
            string GM = stocks["GM"];
            string CAT = stocks["CAT"];
            string GOOGL = stocks["GOOGL"];
            string AAPL = stocks["AAPL"];
        
            //create list for purchases
            List<(string ticker, int shares, double price)> purchases = new List<(string,int,double)>();

            //add values to list of purchases
            purchases.Add((ticker: "GM", shares: 150, price: 23.21));
            purchases.Add((ticker: "GM", shares: 32, price: 17.87));
            purchases.Add((ticker: "GM", shares: 80, price: 19.02));
            purchases.Add((ticker: "CAT", shares: 15, price: 12.21));
            purchases.Add((ticker: "CAT", shares: 300, price: 13.87));
            purchases.Add((ticker: "CAT", shares: 60, price: 14.02));
            purchases.Add((ticker: "GOOGL", shares: 40, price: 112.21));
            purchases.Add((ticker: "GOOGL", shares: 67, price: 113.87));
            purchases.Add((ticker: "GOOGL", shares: 76, price: 114.02));
            purchases.Add((ticker: "AAPL", shares: 34, price: 212.21));
            purchases.Add((ticker: "AAPL", shares: 50, price: 213.87));
            purchases.Add((ticker: "AAPL", shares: 50, price: 214.02));

            //create report dictionary
            Dictionary<string,double> report = new Dictionary<string,double>();
            

            //iterate over purchases
            foreach((string ticker,int shares,double price) purchase in purchases)
            {       
                    //check to see if purchased are contained in stocks list
                    if(stocks.ContainsKey(purchase.ticker))
                    {   
                        
                        
                        if (report.ContainsKey(stocks[purchase.ticker]))
                        {
                            //key value pair for dictionary
                             report[stocks[purchase.ticker]] += (purchase.shares * purchase.price);
                        }
                        else
                        {
                            report.Add(stocks[purchase.ticker],purchase.shares * purchase.price);
                        }
                       
                    }
            }
            foreach( KeyValuePair<string, double> r in report){
                 Console.WriteLine("{0} : {1}", r.Key, r.Value);
            }
       


        }
    }
}
