public class FireBender : Bender
{
    private double heatAgression;

    public FireBender(string name, int power, double heatAgression) 
        : base(name, power)
    {
        this.heatAgression = heatAgression;
    }

    public override double GetPower() 
        => this.Power * this.heatAgression;

    public override string ToString() =>
        $"{base.ToString()}, Heat Aggression: {this.heatAgression:f2}";

}
