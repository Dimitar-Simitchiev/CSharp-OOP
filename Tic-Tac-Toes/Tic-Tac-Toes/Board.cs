using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Tic_Tac_Toes
{
    public enum Symbols
    {
        x=1,
        O=2,
        
        

    }
    
    public class Board:Gamemaneger
    {
        Random random = new Random();
        // string positionX = "X";
        // string position0 = "0";
        // string positionEmpty = "-";
        public int Row{ get; set; }
        public int Colums { get; set; }
        Symbols[,]board=new Symbols[3,3];

        public void BoardWritelane()
        {


            { board[Row, Colums] = Symbols.x;





                





                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {


                            Console.Write(board[i, j] + " ");

                        }
                        Console.WriteLine();

                    }
                
              







            }

            
        }
        public void RandomMove() 
        {
                Row = random.Next(0, 3);
                Colums = random.Next(0, 3);

                if (CantPutSymbol())
                {
                    board[Row, Colums] = Symbols.O;

                }
                else
                {
                    while (!CantPutSymbol())
                    {
                        Row = random.Next(0, 3);
                        Colums = random.Next(0, 3);

                    }
                    board[Row, Colums] = Symbols.O;
                }
              


                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {


                        Console.Write(board[i, j] + " ");

                    }
                    Console.WriteLine();

                }

                



        } 

        public bool EndGame()
        {
            if (((board[0, 0] == board[0, 1] && board[0, 0] == board[0, 2])) && ((board[0, 0] != 0)))
            {
                Console.WriteLine("The winer is :"+board[0, 0]);
                return  true;

            }
            if (((board[1, 0] == board[1, 1] && board[0, 0] == board[1, 0])) && ((board[1, 0] != 0)))
            {
                Console.WriteLine("The winer is :" + board[1, 0]);
                return  true;

            }
            if (((board[2, 0] == board[2, 1] && board[2, 0] == board[2, 2])) && ((board[2, 0] != 0)))
            {
                Console.WriteLine("The winer is :" + board[2, 0]);
                return  true;

            }
            if (((board[0, 0] == board[1, 0] && board[0, 0] == board[2, 0])) && ((board[0, 0] != 0)))
            {
                Console.WriteLine("The winer is :" + board[0, 0]);
                return true;

            }
            if (((board[0, 1] == board[1, 1] && board[0, 1] == board[2, 1])) && ((board[0, 1] != 0)))
            {
                Console.WriteLine("The winer is Player whit symbol- " + board[0, 1]);
                return true;

            }
            if (((board[0, 2] == board[1, 2] && board[0, 2] == board[2, 2])) && ((board[0, 2] !=0)))
            {
                Console.WriteLine("The winer is :" + board[0, 2]);
                return true;


            }
            if (((board[0, 0] == board[1, 1] && board[0, 0] == board[2, 2])) && ((board[0, 0] != 0)))
            {
                Console.WriteLine("The winer is :" + board[0, 0]);
                return true;

            }
            if (((board[2, 0] == board[1, 1] && board[2, 0] == board[0, 2])) && ((board[2, 0] != 0)))
            {
                Console.WriteLine("The winer is :" + board[2, 0]);
                return true;

            }
            else
            {
                return false;
            }
        }

        public bool CantPutSymbol()
        {
            if (board[Row,Colums]!=0)
            {
                
                return false;
            }
            else
            { 
                return true;
            }
        }
    }
}
