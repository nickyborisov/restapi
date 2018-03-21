namespace Domain
{
    public class Person : BaseEntity
    {
        public string First { get; set; }

        public string Last { get; set; }

        public string Phone { get; set; }

        public byte[] Version { get; set; }
    }
}
