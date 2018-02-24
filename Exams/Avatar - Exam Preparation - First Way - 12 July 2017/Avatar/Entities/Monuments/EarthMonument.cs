public class EarthMonument : Monument
{
    private int earthAffinity;

    public EarthMonument(string name, int earthAffinity) 
        : base(name)
    {
        this.earthAffinity = earthAffinity;
    }

    public override int GetAffinity() => this.earthAffinity;

    public override string ToString() =>
        $"{base.ToString()}, Earth Affinity: {this.earthAffinity}";

}
