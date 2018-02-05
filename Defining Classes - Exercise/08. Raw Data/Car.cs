public class Car
{
    private string model;
    private Engine engine;
    private Cargo cargo;
    private Tire[] tires;

    public Car(string model, Engine engine, Cargo cargo, Tire[] tires)
    {
        this.model = model;
        this.engine = engine;
        this.cargo = cargo;
        this.tires = tires;
    }


    public string Model => this.model;
    public Engine Engine => this.engine;
    public Cargo Cargo => this.cargo;
    public Tire[] Tires => this.tires;
}

