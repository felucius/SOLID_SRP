
using Library_SRP.Animal;
using Library_SRP.Employee;

namespace Library_SRP.Message
{
    public class StandardMessages
    {
        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to the Friendly Animal shelter");
        }

        public static void SayHello(string message, IAnimal animal)
        {
            Console.WriteLine(string.Format("The following greeting: {0} was send to the animal {1}", message, animal.Name));
        }

        public static void FeedAnimal(ICareTaker careTaker, IAnimal animal)
        {
            Console.WriteLine(string.Format("The animal with name: {0} has been fed by care taker {1}", animal.Name, careTaker.Name));
        }

        public static void CleanRoom(ICareTaker careTaker, IAnimal animal)
        {
            Console.WriteLine(string.Format("The room where {0} sleeps in, has now been cleaned by care taker {1}", animal.Name, careTaker.Name));
        }

        public static void GroomAnimal(ICareTaker careTaker, IAnimal animal)
        {
            Console.WriteLine(string.Format("{0} has now been groomed by care taker: {1}", animal.Name, careTaker.Name));
        }
    }
}
