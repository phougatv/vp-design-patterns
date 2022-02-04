namespace DesignPattern.Creational.AbstractFactory.Builders.Implementations;

using DesignPattern.Creational.AbstractFactory.Builders.Abstractions;
using DesignPattern.Creational.AbstractFactory.Products.Abstractions;
using DesignPattern.Creational.AbstractFactory.Products.Implementations;

internal class AudiBuilder : AutoBuilder
{
    public override IHatchBack BuildHatchBack() => new AudiHatchBack();
    public override ISedan BuildSedan() => new AudiSedan();
    public override ISuv BuildSuv() => new AudiSuv();
}
