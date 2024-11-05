using System.Security;

namespace ZahidConsoleApp;

public  class Animal
{
    public int Id { get; set; }
    public string Name { get; set; }


    public void DisplayDetails(Animal obj)
    {
        Console.WriteLine("The Id of animal is " + obj.Id);
        Console.WriteLine("The Name of Animal is " + obj.Name);
    }
}
    