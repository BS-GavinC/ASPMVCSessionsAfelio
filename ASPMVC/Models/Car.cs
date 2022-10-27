namespace ASPMVC.Models;

public class Car
{

    public Car()
    {
        
    }
    public Car(int id, string brand, string model)
    {
        Id = id;
        Brand = brand;
        Model = model;
    }
    public int Id { get; set; }
    public string Brand { get; set; }
    public string Model { get; set; }
}