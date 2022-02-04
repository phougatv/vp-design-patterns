namespace DesignPattern.Creational.AbstractFactory.Products.Implementations;

using DesignPattern.Creational.AbstractFactory.Products.Abstractions;

internal class BmwSedan : ISedan
{
    public String SedanMethodA() => nameof(BmwSedan);
}
