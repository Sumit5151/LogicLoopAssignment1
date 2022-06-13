using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            //instance of Patterns class
            Pattrens pattrens = new Pattrens();

            //Accept any number form user to print patterns and calculate factorial
            Console.WriteLine("Please enter the number");
            var number = Convert.ToInt32(Console.ReadLine());

            //Show two patterns
            pattrens.Pattern1(number);
            pattrens.Pattern2(number);

            //Calcualate and show Factorial of a number
            pattrens.Factorial(number);


            //Create chess.html file
            Chessboard chessboard = new Chessboard(8, 8);
            chessboard.DrawChessBoad();


            Console.ReadLine();

        }
    }
}
