public class Citizen : SocietyMember
{
    public Citizen(string id, string name, int age)
        : base(id)
    {
        this.Name = name;
        this.Age = age;
    }

    public string Name { get; }

    public int Age { get; }
}