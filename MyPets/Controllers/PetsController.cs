using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using MyPets.Database;

namespace MyPets.Controllers;

[ApiController]
[Route("[controller]")]
public class PetsController : ControllerBase
{
    private static readonly string[] Surnames = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<PetsController> _logger;
    private readonly MyPetsDatabaseContext _context;

    public PetsController(ILogger<PetsController> logger,
        MyPetsDatabaseContext context)
    {
        _logger = logger;
        _context = context;
    }

    [HttpGet]
    public IEnumerable<Pet> Get()
    {
        return _context.Pets.ToList();
    }

    [HttpPost]
    public async Task<ObjectResult> Post(Pet pet)
    {
        _context.Pets.Add(pet);
        await _context.SaveChangesAsync();
        return Ok("Succces.");
    }
}