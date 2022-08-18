namespace Library_SRP.Animal
{
    public interface IAnimal
    {
        string Name { get; set; }
        int Age { get; set; }

        AnimalType AnimalType { get; set; }

        string ShowAnimalInformation();
    }
}
