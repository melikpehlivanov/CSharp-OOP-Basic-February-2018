public class Robot : SocietyMember
{
    public Robot(string id, string model)
        : base(id)
    {
        this.Model = model;
    }

    public string Model { get; }
}