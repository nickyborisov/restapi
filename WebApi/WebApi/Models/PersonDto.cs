namespace WebApi.Models
{
    public class PersonDto : BaseModel
    {
        public string First { get; set; }

        public string Last { get; set; }

        public string Phone { get; set; }

        public string Version { get; set; }
    }
}
