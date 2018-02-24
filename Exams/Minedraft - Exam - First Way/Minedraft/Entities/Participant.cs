public abstract class Participant
{
    private string id;

    protected Participant(string id)
    {
        this.Id = id;
    }

    public string Id
    {
        get => this.id;
        private set => this.id = value;
    }

    public abstract string GetTypeName();
}