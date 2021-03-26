namespace BanksPortfolio.Business.Models
{
    public class MediumRiskTrade : Trade
    {
        public MediumRiskTrade(double _value, string _clientSector) : base(_value, _clientSector)
        {
        }

        public override string GetTradeCategory()
        {
            return nameof(CategoryRisk.MEDIUMRISK);
        }
    }
}
