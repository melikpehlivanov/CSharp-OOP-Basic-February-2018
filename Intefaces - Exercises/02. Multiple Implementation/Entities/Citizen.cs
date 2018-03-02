public class Citizen : IBirthable, IIdentifiable, IPerson
{
    public Citizen(string name, int age, string id, string birthdate)
    {
        this.Birthdate = birthdate;
        this.Id = id;
        this.Name = name;
        this.Age = age;
    }

    public string Birthdate { get; }
    public string Id { get; }
    public string Name { get; set; }
    public int Age { get; set; }
}

