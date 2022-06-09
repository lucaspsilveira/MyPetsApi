using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Moq;
using MyPets.Controllers;
using MyPets.Services;
using Xunit;

namespace MyPets.UnitTests;

public class PetsControllerTests
{
    private readonly Mock<IPetsService> _petService;
    private Mock<ILogger<PetsController>> _logger;
    
    public PetsControllerTests()
    {
        _logger = new Mock<ILogger<PetsController>>();
        _petService = new Mock<IPetsService>();
    }

    [Fact]
    public async Task Should_ReturnPetsList_WhenPetsExists()
    {
        // arrange
        var pets = new List<Pet>()
        {
            new Pet
            {
                BirthDate = DateTime.Now,
                Name = "Pinta",
                PetId = new Guid(),
                PetType = PetType.Dog,
                Weight = 13.1
            },
            new Pet
            {
                BirthDate = DateTime.Now,
                Name = "Pinta 2",
                PetId = new Guid(),
                PetType = PetType.Dog,
                Weight = 13.1
            }
        };
        _petService.Setup(ps => ps.GetAll()).ReturnsAsync(pets);
        // act
        var sut = new PetsController(_logger.Object, _petService.Object);
        var result = await sut.Get();
        // assert
        Assert.NotEmpty(result);
        Assert.NotNull(result);
        Assert.Equal(2, result.Count());
        var expectedFirst = pets.First();
        var firstPet = result.First();
        
        Assert.Equal(expectedFirst.Name, firstPet.Name);
        Assert.Equal(expectedFirst.PetType, firstPet.PetType);
        Assert.Equal(expectedFirst.PetId, firstPet.PetId);
        Assert.Equal(expectedFirst.Weight, firstPet.Weight);
        Assert.Equal(expectedFirst.BirthDate, firstPet.BirthDate);

    }
}