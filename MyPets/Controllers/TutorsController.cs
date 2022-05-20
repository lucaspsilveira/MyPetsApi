using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyPets.Database;

namespace MyPets.Controllers;

[ApiController]
[Route("[controller]")]
public class TutorsController : ControllerBase
{
    private readonly MyPetsDatabaseContext _context;

    public TutorsController(MyPetsDatabaseContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IEnumerable<Tutor> Get() => _context.Tutors.Include(x => x.Pets).ToList();

    [HttpPost]
    public void Post(Tutor tutor)
    {
        _context.Tutors.Add(tutor);
        _context.SaveChanges();
    }
}