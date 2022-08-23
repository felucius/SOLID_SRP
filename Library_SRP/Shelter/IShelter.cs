
namespace Library_SRP.Shelter
{
    public interface IShelter
    {
        string Name { get; set; }
        string Address { get; set; }

        DateTime Established { get; set; }
        List<IRoom> Rooms { get; set; }
    }
}
