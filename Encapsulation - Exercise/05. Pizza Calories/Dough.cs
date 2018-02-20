using System;

public class Dough
{
    private const int MinWeight = 1;
    private const int MaxWeight = 200;
    private const int BaseCalories = 2;

    private string flourType;
    private string bakingTechnique;
    private double weight;

    public Dough(string flourType, string bakingTechnique, double weight)
    {
        this.FlourType = flourType;
        this.BakingTechnique = bakingTechnique;
        this.Weight = weight;
    }

    public string FlourType
    {
        get => this.flourType;
        private set
        {
            if (value.ToLower() != "wholegrain" &&
                value.ToLower() != "white")
            {
                throw new ArgumentException("Invalid type of dough.");
            }
            this.flourType = value;
        }
    }

    public string BakingTechnique
    {
        get => this.bakingTechnique;
        private set
        {
            if (value.ToLower() != "crispy" &&
                value.ToLower() != "chewy" &&
                value.ToLower() != "homemade")
            {
                throw new ArgumentException("Invalid type of dough.");
            }
            this.bakingTechnique = value;
        }
    }

    public double Weight
    {
        get => this.weight;
        private set
        {
            if (value < MinWeight || value > MaxWeight)
            {
                throw new ArgumentException($"Dough weight should be in the range [{MinWeight}..{MaxWeight}].");
            }
            this.weight = value;
        }
    }

    public double GetCalories()
    {
        return BaseCalories * this.Weight * this.GetFlourTypeModifier() * this.GetBakingTechniqueModifier();
    }

    private double GetBakingTechniqueModifier()
    {
        if (this.FlourType.ToLower() == "white")
        {
            return 1.5;
        }
        return 1;
    }

    private double GetFlourTypeModifier()
    {
        if (this.BakingTechnique.ToLower() == "crispy")
        {
            return 0.9;
        }
        if (this.BakingTechnique.ToLower() == "chewy")
        {
            return 1.1;
        }
        return 1;
    }
}
