using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toes
{
    internal class Program
    {
        static void Main(string[] args)
        {   Board board = new Board(); 
            bool isRandomMove = true;
            while (true)
            {




                try
                {
                    if (isRandomMove)
                    {
                       
                        
                        
                            Console.Clear();
                            board.RandomMove();
                            isRandomMove = false;
                        if (board.EndGame())
                        {
                            break;
                        }




                    }
                    else
                    {

                        while (!board.CantPutSymbol())
                        {
                            board.Row = int.Parse(Console.ReadLine());
                            board.Colums = int.Parse(Console.ReadLine());
                            while ((board.Row > 2 && board.Colums > 2) || (board.Row < 0 && board.Colums < 0))
                            {
                                Console.WriteLine("numbers and form 0-2!");
                                board.Row = int.Parse(Console.ReadLine());
                                board.Colums = int.Parse(Console.ReadLine());

                            }
                        }     
                        board.BoardWritelane();    
                        isRandomMove = true;
                        if (board.EndGame())
                        {
                            break;
                        }



                    }
                   

                }
                catch (Exception)
                {
                    Console.WriteLine("Row and Colums must numbers and form 0-2!");
                   
                }
                    
                    

               
                
                


                



            }
            
            
            
            
           
            
        }
    }
}
