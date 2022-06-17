using Microsoft.EntityFrameworkCore;
using MyPets.Database;

namespace MyPets.Repositories;

public class TutorsRepository : ITutorsRepository
{
    private readonly MyPetsDatabaseContext _context;

    public TutorsRepository(MyPetsDatabaseContext context)
    {
        _context = context;
    }
    
    public async Task<List<Tutor>> GetAllTutors() => await _context.Tutors.ToListAsync();
    
    public async Task InsertTutor(Tutor tutor)
    {
        _context.Tutors.Add(tutor);
        await _context.SaveChangesAsync();
    }

}