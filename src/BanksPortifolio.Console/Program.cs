using BanksPortifolio.Business.Models;
using System;

namespace BanksPortifolio.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Trade lowrisk = new Trade(999999999999999, "Public Sector");
            System.Console.WriteLine(lowrisk.TradeCategory);

            System.Console.ReadLine();
        }
    }
}
