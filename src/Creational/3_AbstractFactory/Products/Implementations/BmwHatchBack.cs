namespace DesignPattern.Creational.AbstractFactory.Products.Implementations;

using DesignPattern.Creational.AbstractFactory.Products.Abstractions;

internal class BmwHatchBack : IHatchBack
{
    public String HatchBackMethodA() => nameof(BmwHatchBack);
    public String HatchBackCollabsWithSedan(ISedan sedanCollab)
    {
        var result = sedanCollab.SedanMethodA();

        return $"This is {nameof(BmwHatchBack)} collabing with -- {{{result}}}";
    }
    public String HatchBackCollabsWithSedanAndSuv(ISedan sedanCollab, ISuv suvCollab)
    {
        var resultSedan = sedanCollab.SedanMethodA();
        var resultSuv = suvCollab.SuvMethodA();

        return $"This is {nameof(BmwHatchBack)} collabing with -- {{{resultSedan}}} and {{{resultSuv}}}";
    }
}
