// See https://aka.ms/new-console-template for more information


using myApp.Models;
using System.Linq;
using MyWebApp;

internal class Program
{
    static void Main(string[] args)
    {
        //List<Person> people = new List<Person>();


        //people.Add(new Person("Andrzej", 23));
        //people.Add(new Person("Marek", 12));
        //people.Add(new Person("Mati", 3));

        //var adults = people.Where(p => p.Age > 22).ToList();
        //Console.WriteLine("Adults: ");
        //foreach (var person in adults)
        //{
        //    person.Introduce();
        //}

        //var sortedPeople = people.OrderBy(p => p.Age).ToList();

        //foreach(var person in sortedPeople)
        //{
        //    person.Introduce();
        //}

            List<Car> cars = new List<Car>
    {
        new Car("Audi", 2002),
        new Car("BMW", 1999),
        new Car("Toyota", 2015),
        new Car("Toyota", 2009),
        new Car("Mercedes", 1980),
        new Car("Honda", 2020)
    };
        Console.WriteLine("");

        var carList = cars.Where(p => p.Brand == "Toyota").OrderBy(x => x.YearProduction).ToList();

        foreach (var car in carList) 
        {
            car.Introduce();
        }


    }
}

