using _06.Birthday_Celebrations;

public class Citizen : SocietyMember, IBirthdate
{
    public Citizen(string id, string name, int age, string birthdate)
        : base(id)
    {
        this.Name = name;
        this.Age = age;
        this.BirthDate = birthdate;
    }

    public string Name { get; }

    public int Age { get; }

    public string BirthDate { get; }
}