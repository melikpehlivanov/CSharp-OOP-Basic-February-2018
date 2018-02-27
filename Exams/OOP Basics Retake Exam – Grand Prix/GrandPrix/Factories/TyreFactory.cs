using System;
using System.Collections.Generic;

public static class TyreFactory
{
    public static Tyre Create(List<string> args)
    {
        var tyreType = args[0];
        var tyreHardness = double.Parse(args[1]);
        switch (tyreType)
        {
            case "Ultrasoft":
                return new UltrasoftTyre(tyreHardness, double.Parse(args[2]));
            case "Hard":
                return new HardTyre(tyreHardness);
            default:
                throw new ArgumentException();
        }
    }
}