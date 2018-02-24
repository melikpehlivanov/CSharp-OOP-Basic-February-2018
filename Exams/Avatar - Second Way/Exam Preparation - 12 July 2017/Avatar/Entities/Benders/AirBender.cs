public class AirBender : Bender
{
    private double aerialIntegrity;

    public AirBender(string name, int power, double aerialIntegrity)
        : base(name, power)
    {
        this.AerialIntegrity = aerialIntegrity;
    }

    public double AerialIntegrity
    {
        get => this.aerialIntegrity;
        private set => this.aerialIntegrity = value;
    }

    public override double GetPower() =>
        this.AerialIntegrity * this.Power;

    public override string ToString()
    {
        return ($"###Air Bender: {this.Name}, Power: {this.Power}, Aerial Integrity: {this.AerialIntegrity:f2}");
    }
}

