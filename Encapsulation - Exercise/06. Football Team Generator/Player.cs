using System;

public class Player
{
    private readonly string[] statNames = new string[] { "Endurance", "Sprint", "Dribble", "Passing", "Shooting" };

    private string name;
    private int[] stats;

    public Player(string name, int[] stats)
    {
        this.Name = name;
        this.Stats = stats;
    }

    public string Name
    {
        get => this.name;
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("A name should not be empty.");
            }
            this.name = value;
        }
    }

    public int[] Stats
    {
        get => this.stats;
        private set
        {
            this.stats = new int[5];
            for (int i = 0; i < 5; i++)
            {
                if (value[i] < 0 || value[i] > 100)
                {
                    throw new ArgumentException($"{statNames[i]} should be between 0 and 100.");
                }
                this.stats[i] = value[i];
            }
        }
    }
}