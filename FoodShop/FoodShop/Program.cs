using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Foods foods = new Foods();
            decimal sum = 0;
            Console.WriteLine("Hello to your shop!");
            Console.WriteLine("Buy some of aour food");
            Console.WriteLine("Write the food and then use space to write how many of this food you want");
            Console.WriteLine("Food list: banana - 0.8lv");
            Console.WriteLine("Food list: meat - 4lv");
            Console.WriteLine("Food list: cola - 1.2lv");
            Console.WriteLine("Food list: cheese - 3lv");
            Console.WriteLine("Food list: water - 1lv");
            Console.WriteLine("Please write /end/ when you finish");

            string[] input = Console.ReadLine().Split(' ');
            while (input[0]!="end")
            {
                if (foods.foodsdictinary.ContainsKey(input[0]))
                {
                    decimal howmany=decimal.Parse(input[1]);
                    decimal  price= foods.foodsdictinary[input[0]];
                    sum += howmany * price;
                   
                }
                 
                if (decimal.Parse(input[1])<0|| decimal.Parse(input[1])>200)
                {
                    throw new ArgumentOutOfRangeException("Must be form 0 to 199");
                }
                input = Console.ReadLine().Split(' ');

            }
            Console.WriteLine($"Total price is {sum}!");

            





        }
    }
}
