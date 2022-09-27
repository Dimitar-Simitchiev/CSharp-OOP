using System;
using System.Collections.Generic;
using System.Text;

namespace LabPolymorphism
{
    public class Animal
    {
        public Animal(string name,string favouriteFood)
        {
            FavouriteFood = favouriteFood;
            Name = name;
        }
        string Name;
        string FavouriteFood; 
        public virtual string ExplainSelf()
        {
            return $" I am {this.Name} and my favourite food is {this.FavouriteFood}";
        }
    }
}
