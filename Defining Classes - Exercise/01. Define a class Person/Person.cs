class Person
{
    private string name;
    private int age;

    public Person()
    {
    }


    public Person(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }

    public string Name => this.name;
    public int Age => this.age;
}
