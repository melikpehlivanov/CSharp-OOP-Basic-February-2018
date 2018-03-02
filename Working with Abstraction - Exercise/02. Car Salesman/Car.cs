using System.Text;

public class Car
{
    private string model;
    private Engine engine;
    private string weight;
    private string color;

    public Car(string model, Engine engine)
    {
        this.model = model;
        this.engine = engine;
        this.weight = "n/a";
        this.color = "n/a";
    }

    public string Model => this.model;

    public Engine Engine => this.engine;

    public string Weight
    {
        get => this.weight;
        set => this.weight = value;
    }

    public string Color
    {
        get => this.color;
        set => this.color = value;
    }

    public override string ToString()
    {
        var builder = new StringBuilder()
            .AppendLine($"{this.model}:")
            .AppendLine($"  {this.Engine.Model}:")
            .AppendLine($"    Power: {this.Engine.Power}")
            .AppendLine($"    Displacement: {this.engine.Displacement}")
            .AppendLine($"    Efficiency: {this.Engine.Efficiency}")
            .AppendLine($"  Weight: {this.weight}")
            .AppendLine($"  Color: {this.color}");

        return builder.ToString();
    }
}

