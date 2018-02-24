using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

public class NationsBuilder
{
    private List<string> warHistoryRecord = new List<string>();

    Nation AirNation = new AirNation();
    Nation FireNation = new FireNation();
    Nation EarthNation = new EarthNation();
    Nation WaterNation = new WaterNation();

    public void AssignBender(List<string> benderArgs)
    {
        var benderType = benderArgs[0];
        var currentBender = CreateBender(benderArgs);

        switch (benderType)
        {
            case "Air":
                AirNation.Benders.Add(currentBender);
                break;
            case "Water":
                WaterNation.Benders.Add(currentBender);
                break;
            case "Fire":
                FireNation.Benders.Add(currentBender);
                break;
            case "Earth":
                EarthNation.Benders.Add(currentBender);
                break;
        }
    }

    private Bender CreateBender(List<string> benderArgs)
    {
        var benderType = benderArgs[0];
        var benderName = benderArgs[1];
        var benderPower = int.Parse(benderArgs[2]);
        var benderAuxParam = double.Parse(benderArgs[3]);

        switch (benderType)
        {
            case "Air":
                return new AirBender(benderName, benderPower, benderAuxParam);
            case "Water":
                return new WaterBender(benderName, benderPower, benderAuxParam);
            case "Fire":
                return new FireBender(benderName, benderPower, benderAuxParam);
            case "Earth":
                return new EarthBender(benderName, benderPower, benderAuxParam);
            default:
                throw new ArgumentException();
        }
    }

    private Monument CreateMonument(List<string> benderArgs)
    {
        var benderType = benderArgs[0];
        var benderName = benderArgs[1];
        var benderPower = int.Parse(benderArgs[2]);

        switch (benderType)
        {
            case "Air":
                return new AirMonument(benderName, benderPower);
            case "Water":
                return new WaterMonument(benderName, benderPower);
            case "Fire":
                return new FireMonument(benderName, benderPower);
            case "Earth":
                return new EarthMonument(benderName, benderPower);
            default:
                throw new ArgumentException();
        }
    }
    public void AssignMonument(List<string> monumentArgs)
    {
        var monumentType = monumentArgs[0];
        var currentMonument = CreateMonument(monumentArgs);

        switch (monumentType)
        {
            case "Air":
                AirNation.Monuments.Add(currentMonument);
                break;
            case "Water":
                WaterNation.Monuments.Add(currentMonument);
                break;
            case "Fire":
                FireNation.Monuments.Add(currentMonument);
                break;
            case "Earth":
                EarthNation.Monuments.Add(currentMonument);
                break;
        }
    }
    public string GetStatus(string nationsType)
    {
        var message = new StringBuilder();
        switch (nationsType)
        {
            case "Air":
                message.AppendLine(AirNation.ToString());
                break;
            case "Water":
                message.AppendLine(WaterNation.ToString());
                break;
            case "Fire":
                message.AppendLine(FireNation.ToString());
                break;
            case "Earth":
                message.AppendLine(EarthNation.ToString());
                break;
        }
        return message.ToString().Trim();
    }

    public void IssueWar(string nationsType)
    {
        double airNation = AirNation.GetTotalPower();
        double fireNation = FireNation.GetTotalPower();
        double earthNation = EarthNation.GetTotalPower();
        double waterNation = WaterNation.GetTotalPower();

        var dict = new Dictionary<Nation, double>();
        dict.Add(AirNation, airNation);
        dict.Add(FireNation, fireNation);
        dict.Add(EarthNation, earthNation);
        dict.Add(WaterNation, waterNation);

        var newDict = dict.OrderByDescending(n => n.Value).Skip(1);

        foreach (var nation in newDict)
        {
            nation.Key.DeclareDefeat();
        }

        dict.Clear();

        this.warHistoryRecord.Add($"War {warHistoryRecord.Count + 1} issued by {nationsType}");
    }

    public string GetWarsRecord() => string.Join(Environment.NewLine, this.warHistoryRecord);

}

