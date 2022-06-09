namespace MyPets.Services;

public interface IPetsService
{
    Task<List<Pet>> GetAll();
    Task Insert(Pet pet);
}