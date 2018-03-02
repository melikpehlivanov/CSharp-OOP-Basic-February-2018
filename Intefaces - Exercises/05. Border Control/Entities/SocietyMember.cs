using _05.Border_Control;

public abstract class SocietyMember : IIdentifiable
{
    protected SocietyMember(string id)
    {
        this.Id = id;
    }

    public string Id { get; }

    public bool HasInvalidIdEnding(string pattern)
    {
        return this.Id.EndsWith(pattern);
    }
}