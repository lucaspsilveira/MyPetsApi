using Microsoft.AspNetCore.Mvc;
using MyPets.Services;

namespace MyPets.Controllers;

[ApiController]
[Route("[controller]")]
public class TestController: ControllerBase
{
    private readonly PetsServiceScoped _scoped;
    private readonly PetsServiceSingleton _singleton;
    private readonly PetsServiceTransient _transient;


    public TestController(PetsServiceScoped scoped, PetsServiceSingleton singleton, PetsServiceTransient transient)
    {
        _scoped = scoped;
        _singleton = singleton;
        _transient = transient;
    }

    [HttpGet("SCOPED")]
    public string GetScoped() => _scoped.GetText;
    [HttpGet("TRANSIENTE")]
    public string GetTramsient() => _transient.GetText;
    [HttpGet("SINGLEOTN")]
    public string Getsingleton() => _singleton.GetText;
    
}