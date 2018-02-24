public class AirMonument : Monument
{
    private int airAffinity;

    public AirMonument(string name, int airAffinity)
        : base(name)
    {
        this.AirAffinity = airAffinity;
    }

    public int AirAffinity
    {
        get => this.airAffinity;
        private set => this.airAffinity = value;
    }

    public override int GetAffinity() => this.airAffinity;

    public override string ToString()
    {
        return ($"###Air Monument: {this.Name}, Air Affinity: {this.AirAffinity}");
    }
}
