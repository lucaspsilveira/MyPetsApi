namespace MyPets.Services;

public interface ITutorsService
{
    Task<List<Tutor>> GetAll();
    Task Insert(Tutor tutor);
}