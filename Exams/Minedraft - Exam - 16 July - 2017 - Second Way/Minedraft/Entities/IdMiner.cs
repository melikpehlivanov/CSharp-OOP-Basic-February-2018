public abstract class IdMiner
{
    private string id;

    protected IdMiner(string id)
    {
        this.Id = id;
    }

    public string Id
    {
        get => this.id;
        protected set => this.id = value;
    }
}

