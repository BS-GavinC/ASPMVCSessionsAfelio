using ASPMVC.Context;
using ASPMVC.Models;
using ASPMVC.Services;
using Microsoft.AspNetCore.Mvc;

namespace ASPMVC.Controllers;

public class AuthController : Controller
{

    private readonly SessionManager _session;

    public AuthController(SessionManager session)
    {
        _session = session;
    }
    // GET
    public IActionResult Login()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Login(LoginViewModel loginViewModel)
    {
        if (!ModelState.IsValid)
        {
            return View();
        }

        User? user = FakeDb.Users.SingleOrDefault(u => u.Email.ToUpper() == loginViewModel.Email.ToUpper(), null);

        if (user == null)
        {
            return View();
        }

        if (user.Password != loginViewModel.Password)
        {
            return View();
        }

        _session.Email = user.Email;

        return RedirectToAction("Index", "Home");

    }

    public IActionResult Logout()
    {
        _session.Logout();

        return RedirectToAction("Index", "Home");
    }
}