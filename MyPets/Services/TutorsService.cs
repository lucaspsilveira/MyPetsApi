using MyPets.Repositories;

namespace MyPets.Services;

public class TutorsService : ITutorsService
{
    private readonly ITutorsRepository _tutorsRepository;

    public TutorsService(ITutorsRepository tutorsRepository)
    {
        _tutorsRepository = tutorsRepository;
    }
    
    public async Task<List<Tutor>> GetAll()
    {
        return await _tutorsRepository.GetAllTutors();
    }

    public async Task Insert(Tutor tutor)
    {
        await _tutorsRepository.InsertTutor(tutor);
    }
}