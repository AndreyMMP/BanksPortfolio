namespace BanksPortfolio.Business.Models
{
    public class LowRiskTrade : Trade
    {
        public LowRiskTrade(double _value, string _clientSector) : base(_value, _clientSector)
        {
        }

        public override string GetTradeCategory()
        {
            return nameof(CategoryRisk.LOWRISK);
        }
    }
}
