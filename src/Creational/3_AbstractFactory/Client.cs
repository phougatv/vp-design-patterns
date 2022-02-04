namespace DesignPattern.Creational.AbstractFactory;

using DesignPattern.Creational.AbstractFactory.Builders.Abstractions;
using DesignPattern.Creational.AbstractFactory.Builders.Implementations;
using static System.Console;

internal class Client
{
    internal static void Init()
    {
        WriteLine($"Audi-Builder in progress...");
        InternalInit(new AudiBuilder());
        WriteLine();

        WriteLine($"Bmw-Builder in progress...");
        InternalInit(new BmwBuilder());
        WriteLine();
    }

    private static void InternalInit(AutoBuilder autoBuilder)
    {
        var hatchBack = autoBuilder.BuildHatchBack();
        var sedan = autoBuilder.BuildSedan();
        var suv = autoBuilder.BuildSuv();

        WriteLine(hatchBack.HatchBackCollabsWithSedan(sedan));
        WriteLine(hatchBack.HatchBackCollabsWithSedanAndSuv(sedan, suv));
    }
}
