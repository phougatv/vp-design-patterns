namespace DesignPattern.Creational.AbstractFactory.Products.Implementations;

using DesignPattern.Creational.AbstractFactory.Products.Abstractions;

internal class AudiHatchBack : IHatchBack
{
    public String HatchBackCollabsWithSedan(ISedan sedanCollab)
    {
        var result = sedanCollab.SedanMethodA();

        return $"This is {nameof(AudiHatchBack)} collabing with -- {{{result}}}";
    }

    public String HatchBackCollabsWithSedanAndSuv(ISedan sedanCollab, ISuv suvCollab)
    {
        var resultSedan = sedanCollab.SedanMethodA();
        var resultSuv = suvCollab.SuvMethodA();

        return $"This is {nameof(AudiHatchBack)} collabing with -- {{{resultSedan}}} and {{{resultSuv}}}";
    }

    public String HatchBackMethodA() => nameof(AudiHatchBack);
}
