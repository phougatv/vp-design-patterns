namespace DesignPattern.Creational.AbstractFactory.Products.Implementations;

using DesignPattern.Creational.AbstractFactory.Products.Abstractions;

internal class AudiSuv : ISuv
{
    public String SuvMethodA() => nameof(AudiSuv);
}
