public class extraordinary : Cat
{
    private int decibels;

    public extraordinary(string breed, string name, int decibels) : base(breed, name)
    {
        this.decibels = decibels;
    }

    public override string ToString()
    {
        return $"{base.ToString()} {this.decibels}";
    }
}