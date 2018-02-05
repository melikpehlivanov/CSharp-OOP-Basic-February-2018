using System;
using System.Collections.Generic;
using System.Linq;

public class Team
{
    private string name;
    private readonly List<Player> players;

    public Team(string name)
    {
        this.Name = name;
        this.players = new List<Player>();
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

    public void AddPlayer(Player player)
    {
        this.players.Add(player);
    }

    public void RemovePlayerByName(string playerName)
    {
        var playerToRemove = this.players.FirstOrDefault(p => p.Name == playerName);
        if (playerToRemove == null)
        {
            throw new ArgumentException($"Player {playerName} is not in {this.name} team.");
        }

        this.players.Remove(playerToRemove);
    }

    public int GetRating()
    {
        if (this.players.Count == 0) return 0;

        double sumAvSkillLevels = this.players.Sum(p => p.Stats.Average());
        return (int)Math.Round(sumAvSkillLevels / this.players.Count);
    }
}
