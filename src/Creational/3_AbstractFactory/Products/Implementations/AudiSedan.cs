namespace DesignPattern.Creational.AbstractFactory.Products.Implementations;

using DesignPattern.Creational.AbstractFactory.Products.Abstractions;

internal class AudiSedan : ISedan
{
    public String SedanMethodA() => nameof(AudiSedan);
}
