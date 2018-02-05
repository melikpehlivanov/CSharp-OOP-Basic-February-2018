using System;
using System.Text;

public class Animal
{
    private string name;
    private int age;
    private string gender;

    public Animal(string name, int age, string gender)
    {
        this.Name = name;
        this.Age = age;
        this.Gender = gender;
    }

    protected string Name
    {
        get => this.name;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Invalid input!");
            }
            this.name = value;
        }
    }
    protected int Age
    {
        get => this.age;
        set
        {
            if (string.IsNullOrWhiteSpace(value.ToString()) ||
                value < 0)
            {
                throw new ArgumentException("Invalid input!");
            }
            this.age = value;
        }
    }

    protected virtual string Gender
    {
        get => this.gender;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Invalid input!");
            }
            this.gender = value;
        }
    }

    public virtual string ProduceSound()
    {
        return string.Empty;
    }

    public override string ToString()
    {
        var sb = new StringBuilder()
            .AppendLine(this.GetType().Name)
            .AppendLine($"{this.Name} {this.Age} {this.Gender}")
            .AppendLine(this.ProduceSound());

        return sb.ToString();
    }
}
