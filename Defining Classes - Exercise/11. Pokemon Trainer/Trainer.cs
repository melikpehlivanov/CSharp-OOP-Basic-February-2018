using System.Collections.Generic;

public class Trainer
{
    private string name;
    private int badges;
    private List<Pokemon> pokemons;

    public Trainer(string name)
    {
        this.name = name;
        this.badges = 0;
        this.pokemons = new List<Pokemon>();
    }

    public string Name => this.name;

    public List<Pokemon> Pokemons
    {
        get => this.pokemons;
        set => this.pokemons = value;
    }

    public int Badges
    {
        get => this.badges = badges;
        set => this.badges = value;
    }

    public override string ToString()
    {
        return $"{this.name} {this.badges} {this.Pokemons.Count}";
    }
}

