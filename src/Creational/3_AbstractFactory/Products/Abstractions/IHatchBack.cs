namespace DesignPattern.Creational.AbstractFactory.Products.Abstractions;

using System;

public interface IHatchBack
{
    String HatchBackMethodA();
    String HatchBackCollabsWithSedan(ISedan sedanCollab);
    String HatchBackCollabsWithSedanAndSuv(ISedan sedanCollab, ISuv suvCollab);
}
