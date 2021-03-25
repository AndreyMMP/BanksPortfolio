using BanksPortifolio.Business.Interfaces;
using System;

namespace BanksPortifolio.Business.Models
{
    public abstract class Trade : ITrade
    {
        private readonly double value;
        private readonly string clientSector;
        public Trade(double _value, string _clientSector)
        {
            value = _value;
            clientSector = _clientSector;
        }
        public double Value => value;
        public string ClientSector => clientSector;
        public abstract string GetTradeCategory();
        public string TradeCategory => GetTradeCategory();
    }                          
}
