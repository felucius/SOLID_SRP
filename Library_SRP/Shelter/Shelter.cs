
namespace Library_SRP.Shelter
{
    public class Shelter : IShelter
    {
        public string? Name { get; set; }
        public string? Address { get; set; }
        public DateTime Established { get; set; }
        public List<IRoom>? Rooms { get; set; }
    }
}
