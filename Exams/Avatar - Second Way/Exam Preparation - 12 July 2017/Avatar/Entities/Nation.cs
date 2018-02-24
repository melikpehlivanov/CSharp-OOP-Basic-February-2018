using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class Nation
{
    private string name;
    private List<Monument> monuments;
    private List<Bender> benders;

    protected Nation(string name)
    {
        this.Name = name;
        this.Monuments = new List<Monument>();
        this.Benders = new List<Bender>();
    }

    public string Name
    {
        get => this.name;
        private set => this.name = value;
    }

    public List<Monument> Monuments
    {
        get => this.monuments;
        private set => this.monuments = value;
    }

    public List<Bender> Benders
    {
        get => this.benders;
        private set => this.benders = value;
    }

    public double GetTotalPower()
    {
        int monumentsIncreasePercentage = this.monuments.Sum(m => m.GetAffinity());
        double TotalbendersPower = this.benders.Sum(b => b.GetPower());
        double totalPowerIncrease = TotalbendersPower / 100 * monumentsIncreasePercentage;

        return TotalbendersPower + totalPowerIncrease;
    }

    public override string ToString()
    {
        var result = new StringBuilder();

        result.AppendLine($"{this.Name} Nation");
        if (this.benders.Count == 0)
        {
            result.AppendLine($"Benders: None");
        }
        else
        {
            result.AppendLine($"Benders:");

            foreach (var bender in benders)
            {
                result.AppendLine(bender.ToString());
            }
        }

        if (this.monuments.Count == 0)
        {
            result.AppendLine($"Monuments: None");
        }
        else
        {
            result.AppendLine($"Monuments:");

            foreach (var monument in monuments)
            {
                result.AppendLine(monument.ToString());
            }
        }

        return result.ToString();
    }

    public void DeclareDefeat()
    {
        this.benders.Clear();
        this.monuments.Clear();
    }
}

