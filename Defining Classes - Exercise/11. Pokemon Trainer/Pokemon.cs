public class Pokemon
{
    private string name;
    private string element;
    private int health;

    public Pokemon(string name, string element, int health)
    {
        this.name = name;
        this.element = element;
        this.health = health;
    }

    public string Element => this.element;

    public int Health
    {
        get => this.health = health;
        set => this.health = value;
    }
}

