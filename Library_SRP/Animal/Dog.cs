
namespace Library_SRP.Animal
{
    public class Dog : Animal
    {
        public bool IsDomesticated { get; set; }

        public override string ShowAnimalInformation()
        {
            return string.Format("Animal type: {0} with name: {1} has age: {2}.", Name, Age, AnimalType.Dog);
        }
    }
}
