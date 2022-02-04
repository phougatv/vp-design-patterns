namespace DesignPattern.Creational.AbstractFactory.Products.Implementations;

using DesignPattern.Creational.AbstractFactory.Products.Abstractions;

internal class BmwSuv : ISuv
{
    public String SuvMethodA() => nameof(BmwSuv);
}
