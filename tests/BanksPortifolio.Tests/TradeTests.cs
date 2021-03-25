using BanksPortifolio.Business.Factories;
using BanksPortifolio.Business.Models;
using System;
using Xunit;

namespace BanksPortifolio.Tests
{
    public class TradeTests
    {
        [Fact]
        public void TradeFactory_MustCreateLowRiskTrade()
        {
            Trade trade = TradeFactory.Create(Constants.TradeValueRange, nameof(ClientSector.PUBLIC));
            Assert.Equal(typeof(LowRiskTrade), trade.GetType());
        }
        [Fact]
        public void TradeFactory_MustCreateMediumRiskTrade()
        {
            Trade trade = TradeFactory.Create(Constants.TradeValueRange + 1, nameof(ClientSector.PUBLIC));
            Assert.Equal(typeof(MediumRiskTrade), trade.GetType());
        }
        [Fact]
        public void TradeFactory_MustCreateHighRiskTrade()
        {
            Trade trade = TradeFactory.Create(Constants.TradeValueRange + 1, nameof(ClientSector.PRIVATE));
            Assert.Equal(typeof(HighRiskTrade), trade.GetType());
        }
        [Fact]
        public void TradeFactory_MustThrowsException()
        {
            Action act = () => TradeFactory.Create(Constants.TradeValueRange, "UNKNOWN");
            Assert.Throws<ApplicationException>(act);
        }
        [Fact]
        public void TradeValue_MustReturnValueParameter()
        {
            Trade trade = TradeFactory.Create(Constants.TradeValueRange, nameof(ClientSector.PUBLIC));
            Assert.Equal(Constants.TradeValueRange, trade.Value);
        }
        [Fact]
        public void TradeClientSector_MustReturnClientSectorParameter()
        {
            Trade trade = TradeFactory.Create(Constants.TradeValueRange, nameof(ClientSector.PUBLIC));
            Assert.Equal(nameof(ClientSector.PUBLIC), trade.ClientSector);
        }
        [Fact]
        public void TradeCategory_MustReturnLowRisk()
        {
            Trade trade = TradeFactory.Create(Constants.TradeValueRange, nameof(ClientSector.PUBLIC));            
            Assert.Equal(nameof(CategoryRisk.LOWRISK), trade.TradeCategory);
        }
        [Fact]
        public void TradeCategory_MustReturnMediumRisk()
        {
            Trade trade = TradeFactory.Create(Constants.TradeValueRange + 1, nameof(ClientSector.PUBLIC));
            Assert.Equal(nameof(CategoryRisk.MEDIUMRISK), trade.TradeCategory);
        }
        [Fact]
        public void TradeCategory_MustReturnHighRisk()
        {
            Trade trade = TradeFactory.Create(Constants.TradeValueRange + 1, nameof(ClientSector.PRIVATE));
            Assert.Equal(nameof(CategoryRisk.HIGHRISK), trade.TradeCategory);
        }
    }
}
