
namespace Library_SRP.Employee
{
    public interface IJanitor : IEmployee
    {
        bool HasKeysToWholeFacility { get; set; }

        void CleanRoom();

        bool LockUpBuilding();
    }
}
