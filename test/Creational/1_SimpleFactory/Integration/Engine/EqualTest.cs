namespace DesignPattern.Creational.SimpleFactory.Test.Integration.Engine;
using DesignPattern.Creational.SimpleFactory.Enums;
using DesignPattern.Creational.SimpleFactory.Factories;
using DesignPattern.Creational.SimpleFactory.Products.Abstractions;
using DesignPattern.Creational.SimpleFactory.Products.Implementations;
using Xunit;

public class EqualTest
{
    private const EngineType DefaultEngine = EngineType.DefaultEngine;
    private const EngineType DieselEngine = EngineType.DieselEngine;
    private const EngineType PetrolEngine = EngineType.PetrolEngine;

    [Fact]
    public void WhenOnlyOneInstanceIsNull_ReturnsFalse()
    {
        //Arrange
        var expectedDefaultEngine = new DefaultEngine();
        var expectedDieselEngine = new DieselEngine();
        var expectedPetrolEngine = new PetrolEngine();

        //Act
        var actualEngine = null as Engine;

        //Assert
        Assert.NotNull(expectedDefaultEngine);
        Assert.NotNull(expectedDieselEngine);
        Assert.NotNull(expectedPetrolEngine);

        Assert.Null(actualEngine);

        Assert.False(expectedDefaultEngine.Equals(actualEngine));
        Assert.False(expectedDieselEngine.Equals(actualEngine));
        Assert.False(expectedPetrolEngine.Equals(actualEngine));
    }

    [Fact]
    public void WhenBothInstancesAreNull_ReturnsTrue()
    {
        //Arrange
        var expectedEngine = null as Engine;
        var expectedDefaultEngine = null as DefaultEngine;
        var expectedDieselEngine = null as DieselEngine;
        var expectedPetrolEngine = null as PetrolEngine;

        //Act
        var actual = null as Engine;

        //Assert
        Assert.Null(expectedEngine);
        Assert.Null(expectedDefaultEngine);
        Assert.Null(expectedDieselEngine);
        Assert.Null(expectedPetrolEngine);
        Assert.Null(actual);

        Assert.True(expectedEngine == actual);
        Assert.True(expectedDefaultEngine == actual);
        Assert.True(expectedDieselEngine == actual);
        Assert.True(expectedPetrolEngine == actual);
    }

    [Fact]
    public void WhenInstancesAreEqual_ReturnsTrue()
    {
        //Arrange
        var expectedDefaultEngine = new DefaultEngine();
        var expectedDieselEngine = new DieselEngine();
        var expectedPetrolEngine = new PetrolEngine();

        //Act
        var actualDefaultEngine = EngineBuilder.Build(DefaultEngine);
        var actualDieselEngine = EngineBuilder.Build(DieselEngine);
        var actualPetrolEngine = EngineBuilder.Build(PetrolEngine);

        //Assert
        Assert.NotNull(expectedDefaultEngine);
        Assert.NotNull(expectedDieselEngine);
        Assert.NotNull(expectedPetrolEngine);

        Assert.NotNull(actualDefaultEngine);
        Assert.NotNull(actualDieselEngine);
        Assert.NotNull(actualPetrolEngine);

        Assert.True(expectedDefaultEngine == actualDefaultEngine);
        Assert.True(expectedDieselEngine == actualDieselEngine);
        Assert.True(expectedPetrolEngine == actualPetrolEngine);
    }
}
