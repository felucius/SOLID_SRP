using Library_SRP.Animal;
using Library_SRP.Message;

namespace Library_SRP.Employee
{
    public class CareTaker : ICareTaker
    {
        public bool HasAnimalAssigned { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double WorkingHoursPerWeek { get; set; }
        public double Salary { get; set; }

        public IAnimal AssignedAnimal(IAnimal animal)
        {
            return animal;
        }

        public void GiveFood(ICareTaker careTaker, IAnimal animal)
        {
            StandardMessages.FeedAnimal(careTaker, animal);
        }

        public void GroomAnimal(ICareTaker careTaker, IAnimal animal)
        {
            StandardMessages.GroomAnimal(careTaker, animal);
        }
    }
}
