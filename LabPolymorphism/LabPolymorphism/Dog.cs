using System;
using System.Collections.Generic;
using System.Text;

namespace LabPolymorphism
{
    internal class Dog:Animal
    {
        string Name;
        string FavouriteFood;
        public Dog(string name, string favouriteFood) : base(name, favouriteFood)
        {

        }
        public override string ExplainSelf()
        {
            return base.ExplainSelf() + "Bauuuu";
        }
    }
}
