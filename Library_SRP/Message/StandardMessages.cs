
using Library_SRP.Animal;
using Library_SRP.Employee;
using Library_SRP.Shelter;

namespace Library_SRP.Message
{
    public class StandardMessages
    {
        public static void WelcomeMessage(IShelter shelter)
        {
            Console.WriteLine(String.Format("Welcome to {0} on {1} that has been established since {2}", shelter.Name, shelter.Address, shelter.Established));
        }

        public static void SayHelloMessage(string message, IAnimal animal)
        {
            Console.WriteLine(string.Format("The following greeting: {0} was send to the animal {1}", message, animal.Name));
        }

        public static void FeedAnimalMessage(ICareTaker careTaker, IAnimal animal)
        {
            Console.WriteLine(string.Format("The animal with name: {0} has been fed by care taker {1}", animal.Name, careTaker.Name));
        }

        public static void CleanRoomMessage(ICareTaker careTaker, IAnimal animal)
        {
            Console.WriteLine(string.Format("The room where {0} sleeps in, has now been cleaned by care taker {1}", animal.Name, careTaker.Name));
        }

        public static void GroomAnimalMessage(ICareTaker careTaker, IAnimal animal)
        {
            Console.WriteLine(string.Format("{0} has now been groomed by care taker: {1}", animal.Name, careTaker.Name));
        }

        public static void CleanRoomMessage(IJanitor janitor, IAnimal animal)
        {
            Console.WriteLine(String.Format("Janitor {0} has cleaned the room for animal {1}", janitor.Name, animal.Name));
        }

        public static void LockUpBuildingMessage(IJanitor janitor)
        {
            Console.WriteLine(string.Format("Janitor {0} locked up the building", janitor.Name));
        }
    }
}
