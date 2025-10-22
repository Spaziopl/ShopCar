// See https://aka.ms/new-console-template for more information


using System.Linq;
using MyWebApp.Data;
using MyWebApp.Models;
using Microsoft.EntityFrameworkCore;

using var context = new AppDbConetext();

//var owner = new Owner { Name = "Kasia" };

//owner.Cars.Add(new Car { Brand = "BMW", YearProdcution = 2022 });

//context.Add(owner);

//context.SaveChanges();
//Console.WriteLine("Data saved to databes successfully");


var owners = context.Owners.Include(o => o.Cars).ToList();

foreach (var owner in owners)
{
    Console.WriteLine($"Name: {owner.Name}");
    foreach(var car  in owner.Cars)
    {
        Console.WriteLine($"Car: {car.Brand}, {car.YearProdcution}");
    }
}


