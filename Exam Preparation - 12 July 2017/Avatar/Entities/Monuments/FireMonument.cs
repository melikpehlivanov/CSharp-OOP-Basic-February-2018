public class FireMonument : Monument
{
    private int fireAffinity;

    public FireMonument(string name, int fireAffinity) 
        : base(name)
    {
        this.fireAffinity = fireAffinity;
    }

    public override int GetAffinity() => this.fireAffinity;

    public override string ToString() =>
        $"{base.ToString()}, Fire Affinity: {this.fireAffinity}";

}

