using System;
using System.Collections.Generic;

public static class HarvesterFactory
{
    public static Harvester CreateHarvester(List<string> harvesterArgs)
    {
        var harvesterType = harvesterArgs[0];
        var harvesterId = harvesterArgs[1];
        var harvesterOreOutput = double.Parse(harvesterArgs[2]);
        var harvesterEnergyRequirement = double.Parse(harvesterArgs[3]);

        switch (harvesterType)
        {
            case "Sonic":
                int sonicFactor = int.Parse(harvesterArgs[4]);
                return new SonicHarvester(harvesterId, harvesterOreOutput, harvesterEnergyRequirement, sonicFactor);
            case "Hammer":
                return new HammerHarvester(harvesterId, harvesterOreOutput, harvesterEnergyRequirement);
            default:
                throw new ArgumentException();
        }
    }
}
