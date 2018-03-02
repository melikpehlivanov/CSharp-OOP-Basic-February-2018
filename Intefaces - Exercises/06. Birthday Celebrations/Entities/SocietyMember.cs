namespace _06.Birthday_Celebrations
{
    public class SocietyMember : IIdentifiable
    {
        public SocietyMember(string id)
        {
            this.Id = id;
        }

        public string Id { get; }

        public bool HasInvalidIdEnding(string pattern)
        {
            return this.Id.EndsWith(pattern);
        }
    }
}
