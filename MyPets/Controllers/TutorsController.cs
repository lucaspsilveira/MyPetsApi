using Microsoft.AspNetCore.Mvc;
using MyPets.Services;

namespace MyPets.Controllers;

[ApiController]
[Route("[controller]")]
public class TutorsController : ControllerBase
{
    private readonly ITutorsService _tutorsService;

    public TutorsController(ITutorsService tutorsService)
    {
        _tutorsService = tutorsService;
    }

    [HttpGet]
    public async Task<IEnumerable<Tutor>> Get() => await _tutorsService.GetAll();

    [HttpPost]
    public void Post(Tutor tutor)
    {
        _tutorsService.Insert(tutor);
    }
}