namespace Library_SRP.Animal
{
    public abstract class Animal : IAnimal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public AnimalType AnimalType { get; set; }

        public abstract string ShowAnimalInformation();
    }
}