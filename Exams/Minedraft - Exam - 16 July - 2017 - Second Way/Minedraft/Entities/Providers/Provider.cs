using System;
using System.Text;

public abstract class Provider : IdMiner
{
    private double energyOutput;

    protected Provider(string id, double energyOutput) 
        : base(id)
    {
        this.EnergyOutput = energyOutput;
    }

    public double EnergyOutput
    {
        get => this.energyOutput;
        protected set
        {
            if (value > 10000 || value < 0)
            {
                throw new ArgumentException($"Provider is not registered, because of it's {nameof(EnergyOutput)}");
            }
            this.energyOutput = value;
        }
    }

    public override string ToString()
    {
        var sb = new StringBuilder();

        var type = this.GetType().Name;
        var index = type.IndexOf("Provider");
        type = type.Remove(index);

        sb.AppendLine($"{type} Provider - {this.Id}");
        sb.AppendLine($"Energy Output: {this.EnergyOutput}");

        return sb.ToString().Trim();
    }
}

