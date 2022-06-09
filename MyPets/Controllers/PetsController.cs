using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using MyPets.Database;
using MyPets.Services;

namespace MyPets.Controllers;

[ApiController]
[Route("[controller]")]
public class PetsController : ControllerBase
{
    private readonly ILogger<PetsController> _logger;
    private readonly IPetsService _petsService;

    public PetsController(ILogger<PetsController> logger, IPetsService petsService)
    {
        _logger = logger;
        _petsService = petsService;
    }

    [HttpGet]
    public async Task<IEnumerable<Pet>> Get()
    {
        return await _petsService.GetAll();
    }

    [HttpPost]
    public async Task<ObjectResult> Post(Pet pet)
    {
        await _petsService.Insert(pet);
        return Ok("Success.");
    }
}