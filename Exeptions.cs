using System;
using System.Collections.Generic;
using System.Security;
using System.Security.Cryptography;
using System.Text;

namespace Exceptions
{
    public class Program
    {

        static void Main(string[] args)
        {
            List<NewCards> newcardslist = new List<NewCards>();
            string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            var count = input.Length;
            while (count>0)
            {


                try
                {
                    
                    for (int i = 0; i < input.Length; i++)
                    {
                        string[] splitedinput = input[i].Split(" ");
                        bool contains = CreateCard(splitedinput[0].ToString(), splitedinput[1].ToString());
                        if (contains == true)
                        {
                            NewCards current = new NewCards();
                            current.newcardFacen = splitedinput[0];
                            current.newcarSuit = splitedinput[1];

                            newcardslist.Add(current);
                        }
                        else
                        {
                            Console.WriteLine("Invalid card!");
                           
                        }
                        count--;

                    }
                    foreach (var item in newcardslist)
                    {
                        if (item.newcarSuit== "S")
                        {
                            char a = '\u2660';
                            Console.Write($"[{item.newcardFacen}{a}] ");

                        }
                        if (item.newcarSuit == "C")
                        {
                            char a = '\u2663';
                            Console.Write($"[{item.newcardFacen}{a}] ");

                        }
                        if (item.newcarSuit == "D")
                        {
                            char a = '\u2666';
                            Console.Write($"[{item.newcardFacen}{a}] ");

                        }
                        if (item.newcarSuit == "H")
                        {
                            char a = '\u2665';
                            Console.Write($"[{item.newcardFacen}{a}] ");

                        }


                    }


                }
                catch (Exception)
                {

                    Console.WriteLine("Invalid number");
                    count = 0;



                }
             
            }
        }
        public static bool  CreateCard(string face,string suit)
        {


            
            Card cards = new Card();
            NewCards newcards = new NewCards();
            


            if (cards.cardFacen.Contains(face)&&cards.cardSuit.Contains(suit))
            {
                newcards.newcardFacen = face;
                newcards.newcarSuit = suit;
                return true;
              
            }
            
     
           
            else
            {
                return false;
            }
            

        }
      





    }
    public class Card
    {
       
        public List<string> cardFacen = new List<string>() { "2", "4", "5", "6", "7", "8", "9", "10", "J", "K", "Q", "A" };
        public List<string> cardSuit = new List<string>() { "S", "H", "D", "C" };
       

  }
    public class NewCards
    {   public string newcardFacen { get; set; }
        public string newcarSuit { get; set; }

    }
}
