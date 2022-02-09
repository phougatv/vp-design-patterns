namespace DesignPattern.Creational.Prototype;

using DesignPattern.Creational.Prototype.Products;
using static System.Console;

internal class Client
{
    internal static void Init() => InternalInit();

    private static void InternalInit()
    {
        //Create an instance of Person and assign values to it.
        var originalPerson = new Person
        {
            Id = 1,
            Name = new Name("Rui", "Costa"),
            Dob = new DateTime(2000, 01, 15, 23, 59, 59),
            RandomProp = "Some random string value"
        };

        //1. Perform a ShallowCopy
        var shallowCopyPerson = originalPerson.ShallowCopy();

        //2. Display values of originalPerson and shallowCopyPerson
        InternalDisplayToConsole(originalPerson, "---- Original Person ----");
        InternalDisplayToConsole(shallowCopyPerson, "---- Shallow Copy Person ----");

        //2. Change the values of originalPerson properties and display the values of p1 and p2.
        originalPerson.Id = 2;
        originalPerson.Name.First = "Lionel";
        originalPerson.Name.Last = "Messi";
        originalPerson.RandomProp = ";)";
        WriteLine(">>>> Values of Original Person changed <<<<");
        InternalDisplayToConsole(originalPerson, "---- Original Person ----");
        InternalDisplayToConsole(shallowCopyPerson, "---- Shallow Copy Person ----");

        //3. Perform a DeepCopy
        var deepCopyPerson = originalPerson.DeepCopy();

        //4. Change the members of the originalPerson class to new values to show the deep copy.
        originalPerson.Id = 100;
        originalPerson.Name.First = "Ronaldinho";
        originalPerson.Name.Last = "";
        originalPerson.Dob = new DateTime(1980, 01, 10, 10, 10, 10);
        originalPerson.RandomProp = "asdf asdf asdf asdf asdf";

        //5. Display values of originalPerson and deepCopyPerson
        InternalDisplayToConsole(originalPerson, "---- Original Person ----");
        InternalDisplayToConsole(deepCopyPerson, "---- Deep Copy Person ----");
    }

    private static void InternalDisplayToConsole(Person person, String message)
    {
        WriteLine(message);
        person.DisplayToConsole();
        WriteLine();
    }
}
