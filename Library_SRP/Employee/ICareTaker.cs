using Library_SRP.Animal;

namespace Library_SRP.Employee
{
    public interface ICareTaker : IEmployee
    {
        bool HasAnimalAssigned { get; set; }
        IAnimal AssignedAnimal(IAnimal animal);

        void GroomAnimal(ICareTaker careTaker, IAnimal animal);

        void GiveFood(ICareTaker careTaker, IAnimal animal);
    }
}
