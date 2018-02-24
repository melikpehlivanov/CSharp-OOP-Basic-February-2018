public class WaterMonument : Monument
{
    private int waterAffinity;
    
    public WaterMonument(string name, int waterAffinity) 
        : base(name)
    {
        this.waterAffinity = waterAffinity;
    }

    public override int GetAffinity() => this.waterAffinity;

    public override string ToString() =>
        $"{base.ToString()}, Water Affinity: {this.waterAffinity}";

}
