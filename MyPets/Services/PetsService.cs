using MyPets.Repositories;

namespace MyPets.Services;

public class PetsService : IPetsService
{
    private readonly IPetsRepository _petsRepository;
    public PetsService(IPetsRepository petsRepository)
    {
        _petsRepository = petsRepository;
    }

    public async Task<List<Pet>> GetAll()
    {
        return await _petsRepository.GetAllPets();
    }

    public async Task Insert(Pet pet)
    {
        await _petsRepository.InsertPet(pet);
    }
}