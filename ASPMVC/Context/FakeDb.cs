using ASPMVC.Models;

namespace ASPMVC.Context;

public static class FakeDb
{
    public static List<Car> Cars { get; set; } = new List<Car>()
    {
        new Car(1, "BMW", "440D"),
        new Car(2,"Citroen", "C4"),
        new Car(3, "Seat", "Leon"),
        new Car(4, "BMW", "Serie 1"),
        new Car(5 , "Toyota", "Supra")
    };

    public static List<User> Users { get; set; } = new List<User>()
    {
        new User(1, "PaulK@gmail.com", "Test123="),
        new User(2, "MireilleM@gmail.com", "Test123="),
        new User(3, "BradP@gmail.com", "Test123="),
        new User(4, "BillG@gmail.com", "Test123=")
    };
}

