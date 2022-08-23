
using Library_SRP.Animal;
using Library_SRP.Employee;
using Library_SRP.Message;
using Library_SRP.Shelter;

Shelter shelter = new Shelter
{
    Name = "The animal shelter",
    Address = "LongRoad 23",
    Established = new DateTime(1980, 11, 13),
    Rooms = new List<IRoom> 
    { 
        new Room
        {
            MultipleAnimalAllowed = true,
            SizeinSquareMeters = 20
        },
        new Room
        {
            MultipleAnimalAllowed = false,
            SizeinSquareMeters = 10
        }
    }
};

StandardMessages.WelcomeMessage(shelter);

CareTaker careTakerEmployee = new CareTaker
{
    Name = "Roberta",
    Age = 44,
    Salary = 1500,
    WorkingHoursPerWeek = 22,
    HasAnimalAssigned = true
};

Janitor janitorEmployee = new Janitor
{
    Name = "Robert",
    Age = 45,
    HasKeysToWholeFacility = true,
    Salary = 1800,
    WorkingHoursPerWeek = 32
};

IAnimal cat = new Cat
{
    Age = 3,
    Name = "Felix",
    AnimalType = AnimalType.Cat,
    IsVacinnated = true
};

IAnimal dog = new Dog
{
    Age = 12,
    Name = "Max",
    AnimalType = AnimalType.Dog,
    IsDomesticated = true
};

careTakerEmployee.AssignedAnimal(cat);

StandardMessages.SayHelloMessage("Hello my dearest", cat);
StandardMessages.CleanRoomMessage(careTakerEmployee, cat);
StandardMessages.GroomAnimalMessage(careTakerEmployee, cat);
StandardMessages.FeedAnimalMessage(careTakerEmployee, cat);

StandardMessages.CleanRoomMessage(janitorEmployee, dog);
StandardMessages.LockUpBuildingMessage(janitorEmployee);
