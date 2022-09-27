using System;
using System.Collections.Generic;
using System.Text;

namespace LabPolymorphism
{
    public class Cat : Animal
    {
        string Name;
        string FavouriteFood;
        public Cat(string name, string favouriteFood) : base(name, favouriteFood)
        {

        }
        public override string ExplainSelf()
        {
            return base.ExplainSelf() + "Meewwwwww";
        }
    }
}
