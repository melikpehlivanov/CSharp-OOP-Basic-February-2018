public class FireMonument : Monument
{
    private int fireAffinity;

    public FireMonument(string name, int fireAffinity)
        : base(name)
    {
        this.FireAffinity = fireAffinity;
    }

    public int FireAffinity
    {
        get => this.fireAffinity;
        private set => this.fireAffinity = value;
    }

    public override int GetAffinity() => this.fireAffinity;

    public override string ToString()
    {
        return ($"###Fire Monument: {this.Name}, Fire Affinity: {this.FireAffinity}");
    }
}

