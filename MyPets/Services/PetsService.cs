namespace MyPets.Services;

public class PetsServiceSingleton
{
    public string GetText = Guid.NewGuid().ToString();
}


public class PetsServiceScoped
{
    public string GetText = Guid.NewGuid().ToString();
}

public class PetsServiceTransient
{
    public string GetText = Guid.NewGuid().ToString();
}

