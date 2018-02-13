public class Extraordinary : Cat
{
    private int decibels;

    public Extraordinary(string breed, string name, int decibels) : base(breed, name)
    {
        this.decibels = decibels;
    }

    public override string ToString()
    {
        return $"{base.ToString()} {this.decibels}";
    }
}