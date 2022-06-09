using Microsoft.EntityFrameworkCore;
using MyPets.Database;

namespace MyPets.Repositories;

public class PetsRepository : IPetsRepository
{
    private readonly MyPetsDatabaseContext _context;
    
    public PetsRepository(MyPetsDatabaseContext context)
    {
        _context = context;
    }

    public async Task<List<Pet>> GetAllPets() => await _context.Pets.ToListAsync();

    public async Task InsertPet(Pet pet)
    {
        _context.Pets.Add(pet);
        await _context.SaveChangesAsync();
    }
}