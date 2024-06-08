using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Program
    {
        static void Main(string[] args)
        {
            var pizzaBase = new MediumPizza();
            var mediumPizzaWithCheese = new CheesePizzaDecorator(pizzaBase);

            Console.WriteLine($"mediumPizzaWithCheese: {mediumPizzaWithCheese.CalculatePrice()} zł");

            var mediumPizzaWithCheeseSalami = new SalamiPizzaDecorator(mediumPizzaWithCheese);

            Console.WriteLine($"mediumPizzaWithCheeseSalami: {mediumPizzaWithCheeseSalami.CalculatePrice()} zł");

            var doubleSalamiPizzaCheese = new SalamiPizzaDecorator(mediumPizzaWithCheeseSalami);

            Console.WriteLine($"doubleSalamiPizzaCheese: {doubleSalamiPizzaCheese.CalculatePrice()} zł");

            Console.ReadLine();
        }
    }
}
