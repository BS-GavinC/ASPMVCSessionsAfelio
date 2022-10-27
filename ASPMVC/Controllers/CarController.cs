using ASPMVC.Context;
using ASPMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPMVC.Controllers;

public class CarController : Controller
{
    // GET
    public IActionResult ShowOneCar(int id)
    {
        Car car = FakeDb.Cars.FirstOrDefault(c => c.Id == id, new Car{
            Id = 0,
            Brand = "No Brand",
            Model = "No Model"
        });
        return View(car);
    }

    public IActionResult ShowAll()
    {
        return View(FakeDb.Cars);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(CarCreateViewModel createViewModel)
    {
        if (!ModelState.IsValid)
        {
            return View();
        }
        
        FakeDb.Cars.Add(new Car
        {
            Id = FakeDb.Cars.Last().Id + 1,
            Brand = createViewModel.Brand,
            Model = createViewModel.Model
        });

        return RedirectToAction("ShowAll");
    }
}