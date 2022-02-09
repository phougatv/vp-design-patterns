namespace DesignPattern.Creational.Prototype.Products;
public class Person
{
    public Int32 Id { get; set; }
    public Name Name { get; set; }
    public DateTime Dob { get; set; }
    public String RandomProp { get; set; }

    public Person ShallowCopy() => (Person)MemberwiseClone();
    public Person DeepCopy()
    {
        var replica = (Person)MemberwiseClone();
        replica.Name = new Name(Name);
        replica.RandomProp = String.Copy(RandomProp);

        return replica;
    }

    public void DisplayToConsole()
    {
        Console.WriteLine("  Id                 : {0:d}", Id);
        Console.WriteLine("  Name               : {0:s} {1:s}", Name.First, Name.Last);
        Console.WriteLine("  Date of Birth      : {0:s}", Dob.ToString("dd MMM, yyyy | HH:mm:ss"));
        Console.WriteLine("  Random Property    : {0:s}", RandomProp);
    }
}
