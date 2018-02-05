using System.Text;

public class Box
{
    private double lenght;
    private double width;
    private double height;

    public Box(double lenght, double width, double height)
    {
        this.lenght = lenght;
        this.width = width;
        this.height = height;
    }

    public double GetSurfaceArea(double lenght, double width, double height)
    {
        return (2 * lenght * width) + (2 * lenght * height) + (2 * width * height);
    }

    public double GetLateralSurfaceArea(double lenght, double width, double height)
    {
        return (2 * lenght * height) + (2 * width * height);
    }

    public double GetVolume(double lenght, double width, double height)
    {
        return lenght * width * height;
    }

    public override string ToString()
    {
        var stringBuilder = new StringBuilder()
            .AppendLine($"Surface Area - {GetSurfaceArea(this.lenght, this.width, this.height):f2}")
            .AppendLine($"Lateral Surface Area - {GetLateralSurfaceArea(this.lenght, this.width, this.height):f2}")
            .AppendLine($"Volume - {GetVolume(this.lenght, this.width, this.height):f2}");
        return stringBuilder.ToString();
    }
}

