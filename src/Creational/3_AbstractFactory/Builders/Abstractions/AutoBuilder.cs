namespace DesignPattern.Creational.AbstractFactory.Builders.Abstractions;

using DesignPattern.Creational.AbstractFactory.Products.Abstractions;

public abstract class AutoBuilder
{
    public abstract IHatchBack BuildHatchBack();
    public abstract ISedan BuildSedan();
    public abstract ISuv BuildSuv();
}
