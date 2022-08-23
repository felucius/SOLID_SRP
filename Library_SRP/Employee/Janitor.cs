using Library_SRP.Animal;
using Library_SRP.Message;

namespace Library_SRP.Employee
{
    public class Janitor : IJanitor
    {
        public bool HasKeysToWholeFacility { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double WorkingHoursPerWeek { get; set; }
        public double Salary { get; set; }

        public void CleanRoom(IJanitor janitor, IAnimal animal)
        {
            StandardMessages.CleanRoomMessage(janitor, animal);
        }

        public bool LockUpBuilding(IJanitor janitor)
        {
            StandardMessages.LockUpBuildingMessage(janitor);
            return true;
        }
    }
}
