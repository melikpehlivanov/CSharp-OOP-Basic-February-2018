using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class DraftManager
{
    private string mode;
    private double totalStoredEnergy;
    private double totalMinedOre;
    private Dictionary<string, Harvester> harvesters;
    private Dictionary<string, Provider> providers;

    public DraftManager()
    {
        this.harvesters = new Dictionary<string, Harvester>();
        this.providers = new Dictionary<string, Provider>();
        this.mode = "Full";
        this.totalStoredEnergy = 0;
        this.totalMinedOre = 0;
    }

    public string RegisterHarvester(List<string> arguments)
    {
        string msg = string.Empty;
        try
        {
            var harvesterType = arguments[0];
            Harvester harvester = HarvesterFactory.CreateHarvester(arguments);
            this.harvesters[harvester.Id] = harvester;

            msg = $"Successfully registered {harvesterType} Harvester - {harvester.Id}";
        }
        catch (ArgumentException ex)
        {
            msg = ex.Message;
        }

        return msg;
    }

    public string RegisterProvider(List<string> harvesterArgs)
    {
        string msg = string.Empty;
        try
        {
            var providerType = harvesterArgs[0];
            Provider provider = ProviderFactory.CreateProvider(harvesterArgs);
            this.providers[provider.Id] = provider;

            msg = $"Successfully registered {providerType} Provider - {provider.Id}";
        }
        catch (ArgumentException ex)
        {
            msg = ex.Message;
        }

        return msg;
    }
    
    public string Day()
    {
        double dayEnergy = 0;
        double dayOre = 0;
        double harvestNeededEnergyForDay = 0;

        dayEnergy = providers.Sum(v => v.Value.EnergyOutput);
        totalStoredEnergy += dayEnergy;
        
        harvestNeededEnergyForDay += harvesters.Sum(h => h.Value.EnergyRequirement);

        if (totalStoredEnergy >= harvestNeededEnergyForDay)
        {
            if (mode == "Full")
            {
                dayOre += harvesters.Values.Sum(h => h.OreOutput);
                totalStoredEnergy -= harvestNeededEnergyForDay;
            }
            else if (mode == "Half")
            {
                dayOre += harvesters.Values.Sum(h => (h.OreOutput * 50) / 100);
                totalStoredEnergy -= (harvestNeededEnergyForDay * 60) / 100;
            }

            totalMinedOre += dayOre;
        }

        var sb = new StringBuilder();
        sb.AppendLine($"A day has passed.");
        sb.AppendLine($"Energy Provided: {dayEnergy}");
        sb.AppendLine($"Plumbus Ore Mined: {dayOre}");

        return sb.ToString().Trim();
    }
    public string Mode(List<string> arguments)
    {
        string modeToChange = arguments[0];
        if (modeToChange == "Half")
        {
            this.mode = modeToChange;
        }
        else if (modeToChange == "Full")
        {
            this.mode = modeToChange;
        }
        else
        {
            this.mode = modeToChange;
        }

        return $"Successfully changed working mode to {this.mode} Mode";
    }
    public string Check(List<string> arguments)
    {
        var id = arguments[0];
        string msg = string.Empty;

        if (providers.ContainsKey(id))
        {
            msg = providers[id].ToString();
        }
        if (harvesters.ContainsKey(id))
        {
            msg = harvesters[id].ToString();
        }
        if (msg != String.Empty)
        {
            return msg;
        }

        return $"No element found with id - {id}";
    }
    public string ShutDown()
    {
        var sb = new StringBuilder();

        sb.AppendLine("System Shutdown");
        sb.AppendLine($"Total Energy Stored: {totalStoredEnergy}");
        sb.AppendLine($"Total Mined Plumbus Ore: {totalMinedOre}");

        return sb.ToString().Trim();
    }
}
