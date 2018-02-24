public class FireBender : Bender
{
    private double heatAgression;

    public FireBender(string name, int power, double heatAgression)
        : base(name, power)
    {
        this.HeatAgression = heatAgression;
    }

    public double HeatAgression
    {
        get => this.heatAgression;
        private set => this.heatAgression = value;
    }

    public override double GetPower() =>
        this.heatAgression * this.Power;

    public override string ToString()
    {
        return ($"###Fire Bender: {this.Name}, Power: {this.Power}, Heat Aggression: {this.HeatAgression:f2}");
    }
}

