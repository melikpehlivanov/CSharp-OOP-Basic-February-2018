class Employee
{
    private string name;
    private decimal salary;
    private string position;
    private string department;
    private string email;
    private int age;

    public Employee(string name, decimal salary, string position, string department)
    {
        this.name = name;
        this.salary = salary;
        this.position = position;
        this.department = department;
        this.email = "n/a";
        this.age = -1;
    }

    public string Name => this.name;
    public decimal Salary => this.salary;
    public string Department => this.department;

    public string Email
    {
        get { return this.email = email; }
        set { this.email = value; }
    }

    public int Age
    {
        get { return this.age = age; }
        set { this.age = value; }
    }
}

