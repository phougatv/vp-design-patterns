namespace DesignPattern.Creational.AbstractFactory.Builders.Implementations;

using DesignPattern.Creational.AbstractFactory.Builders.Abstractions;
using DesignPattern.Creational.AbstractFactory.Products.Abstractions;
using DesignPattern.Creational.AbstractFactory.Products.Implementations;

internal class BmwBuilder : AutoBuilder
{
    public override IHatchBack BuildHatchBack() => new BmwHatchBack();
    public override ISedan BuildSedan() => new BmwSedan();
    public override ISuv BuildSuv() => new BmwSuv();
}
