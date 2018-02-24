public abstract class Bender
{
    private string name;
    private int power;

    protected Bender(string name, int power)
    {
        this.Name = name;
        this.Power = power;
    }

    public string Name
    {
        get => this.name;
        private set => this.name = value;
    }

    public int Power
    {
        get => this.power;
        private set => this.power = value;
    }

    public abstract double GetPower();
    
}

