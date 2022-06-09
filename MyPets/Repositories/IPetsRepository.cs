namespace MyPets.Repositories;

public interface IPetsRepository
{
    Task<List<Pet>> GetAllPets();
    Task InsertPet(Pet pet);
}