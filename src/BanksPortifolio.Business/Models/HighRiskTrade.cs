namespace BanksPortfolio.Business.Models
{
    public class HighRiskTrade : Trade
    {
        public HighRiskTrade(double _value, string _clientSector) : base(_value, _clientSector)
        {
        }

        public override string GetTradeCategory()
        {
            return nameof(CategoryRisk.HIGHRISK);
        }
    }
}
