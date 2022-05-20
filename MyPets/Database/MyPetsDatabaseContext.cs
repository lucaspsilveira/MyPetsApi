using Microsoft.EntityFrameworkCore;

namespace MyPets.Database;

public class MyPetsDatabaseContext : DbContext
{
    public DbSet<Pet> Pets { get; set; }
    public DbSet<Tutor> Tutors { get; set; }
    
    public string DbPath { get; }

    public MyPetsDatabaseContext()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = System.IO.Path.Join(path, "mypets.db");
    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");
}