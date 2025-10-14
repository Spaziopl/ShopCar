// See https://aka.ms/new-console-template for more information


using myApp.Models;


internal class Program
{
    static void Main(string[] args)
    {
        Person person1 = new Person("Andrzej", 23);
        person1.Introduce();
    }
}

