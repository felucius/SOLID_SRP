
using Library_SRP.Animal;
using Library_SRP.Employee;
using Library_SRP.Message;

StandardMessages.WelcomeMessage();

CareTaker careTakerEmployee = new CareTaker
{
    Name = "Roberta",
    Age = 44,
    Salary = 1500,
    WorkingHoursPerWeek = 22,
    HasAnimalAssigned = true
};

IAnimal cat = new Cat
{
    Age = 3,
    Name = "Felix",
    AnimalType = AnimalType.Cat,
    IsVacinnated = true
};

var assignedAnimal = careTakerEmployee.AssignedAnimal(cat);

StandardMessages.SayHello("Hello my dearest", cat);
StandardMessages.CleanRoom(careTakerEmployee, cat);
StandardMessages.GroomAnimal(careTakerEmployee, cat);
StandardMessages.FeedAnimal(careTakerEmployee, cat);

