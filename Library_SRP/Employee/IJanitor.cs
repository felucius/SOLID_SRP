
using Library_SRP.Animal;

namespace Library_SRP.Employee
{
    public interface IJanitor : IEmployee
    {
        bool HasKeysToWholeFacility { get; set; }

        void CleanRoom(IJanitor janitor, IAnimal animal);

        bool LockUpBuilding(IJanitor janitor);
    }
}
