public class WaterBender : Bender
{
    private double waterClarity;

    public WaterBender(string name, int power, double waterClarity)
        : base(name, power)
    {
        this.waterClarity = waterClarity;
    }

    public override double GetPower()
        => this.Power * this.waterClarity;

    public override string ToString() =>
        $"{base.ToString()}, Water Clarity: {this.waterClarity:f2}";

}
