using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MyPets;

public class Pet
{
    public Guid PetId { get; set; }
    public DateTime BirthDate { get; set; }
    [Required]
    public string Name { get; set; }
    public double Weight { get; set; }
    [Required]
    public PetType PetType { get; set; }
}

public enum PetType
{
    Dog,
    Cat,
    Parrot,
    Snake
}