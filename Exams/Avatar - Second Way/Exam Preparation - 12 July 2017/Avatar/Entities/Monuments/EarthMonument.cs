public class EarthMonument : Monument
{
    private int earthAffinity;

    public EarthMonument(string name, int earthAffinity)
        : base(name)
    {
        this.EarthAffinity = earthAffinity;
    }

    public int EarthAffinity
    {
        get => this.earthAffinity;
        private set => this.earthAffinity = value;
    }

    public override int GetAffinity() => this.earthAffinity;

    public override string ToString()
    {
        return ($"###Earth Monument: {this.Name}, Earth Affinity: {this.EarthAffinity}");
    }
}

