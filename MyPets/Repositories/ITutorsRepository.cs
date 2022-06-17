namespace MyPets.Repositories;

public interface ITutorsRepository
{
    Task<List<Tutor>> GetAllTutors();
    Task InsertTutor(Tutor tutor);
}