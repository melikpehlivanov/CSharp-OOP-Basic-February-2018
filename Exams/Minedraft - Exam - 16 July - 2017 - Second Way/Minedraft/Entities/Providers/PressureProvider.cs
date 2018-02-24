public class PressureProvider : Provider
{
    public PressureProvider(string id, double energyOutput)
        : base(id, energyOutput)
    {
        this.EnergyOutput += this.EnergyOutput * 50 / 100;
    }
}

