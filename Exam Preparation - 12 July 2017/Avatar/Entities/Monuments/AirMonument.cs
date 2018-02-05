public class AirMonument : Monument
{
    private int airAffinity;

    public AirMonument(string name, int airAffinity)
        : base(name)
    {
        this.airAffinity = airAffinity;
    }

    public override int GetAffinity() => this.airAffinity;

    public override string ToString() =>
         $"{base.ToString()}, Air Affinity: {this.airAffinity}";

}
