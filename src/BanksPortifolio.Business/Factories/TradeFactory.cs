using BanksPortifolio.Business.Models;
using System;

namespace BanksPortifolio.Business.Factories
{
    public class TradeFactory
    {
        public static Trade Create(double value, string clientSector)
        {
            if (value <= Constants.TradeValueRange && clientSector == nameof(ClientSector.PUBLIC))
                return new LowRiskTrade(value, clientSector);
            else if (value > Constants.TradeValueRange && clientSector == nameof(ClientSector.PUBLIC))
                return new MediumRiskTrade(value, clientSector);
            else if (value > Constants.TradeValueRange && clientSector == nameof(ClientSector.PRIVATE))
                return new HighRiskTrade(value, clientSector);
            else
                throw new ApplicationException(Constants.UnknownTradeErrorMessage);
        }
    }
}
