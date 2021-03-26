namespace BanksPortfolio.App.ViewModels
{
    public class TradeInformation
    {
        public string Name { get; private set; }
        public double Value { get; private set; }
        public string ClientSector { get; private set; }
        public TradeInformation(string _name)
        {
            Name = _name;
            if (Name == "Trade1")
            {
                Value = 2000000;
                ClientSector = "PRIVATE";
            }
            else if (Name == "Trade2")
            {
                Value = 400000;
                ClientSector = "PUBLIC";
            }
            else if (Name == "Trade3")
            {
                Value = 500000;
                ClientSector = "PUBLIC";
            }
            else if (Name == "Trade4")
            {
                Value = 3000000;
                ClientSector = "PUBLIC";
            }
        }
    }
}
