public class HammerHarvester : Harvester
{
    private const int OreOutputPercentageToIncrease = 200;

    public HammerHarvester(string id, double oreOutput, double energyRequirement)
        : base(id, oreOutput, energyRequirement)
    {
        this.OreOutput += this.OreOutput * OreOutputPercentageToIncrease / 100;
        this.EnergyRequirement *= 2;
    }
}
