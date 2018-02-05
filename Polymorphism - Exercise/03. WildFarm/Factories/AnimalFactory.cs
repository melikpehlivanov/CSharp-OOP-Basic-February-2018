public class AnimalFactory
{
    public static Animal GetAnimal(string[] tokens)
    {
        if (tokens.Length < 4) return null;

        var type = tokens[0];
        var name = tokens[1];
        var weight = double.Parse(tokens[2]);
        var livingRegion = tokens[3];

        switch (type)
        {
            case "Mouse": return new Mouse(name, type, weight, livingRegion);
            case "Zebra": return new Zebra(name, type, weight, livingRegion);
            case "Tiger": return new Tiger(name, type, weight, livingRegion);
            case "Cat":
                return new Cat(name, type, weight, livingRegion,
                    tokens.Length < 5 ? "unknown breed" : tokens[4]);
            default: return null;
        }
    }
}