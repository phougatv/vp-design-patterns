namespace DesignPattern.Creational.Prototype.Products;
public class Name
{
    public Name(Name name)
    {
        First = name.First;
        Last = name.Last;
    }

    public Name(String first, String last)
    {
        First = first;
        Last = last;
    }

    public String First { get; set; }
    public String Last { get; set; }
}
