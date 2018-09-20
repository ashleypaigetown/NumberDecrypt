using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Townsend_Ashley_Homework_Ex_542_decrypt
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initalize variables
            int encrypted;
            int number = 1;
            int first;
            int second;
            int third;
            int fourth;
            

            //prompt user to input number
            Console.Write(" Enter encrypted number: ");
            encrypted = Convert.ToInt16(Console.ReadLine());

            //extract digits 
            fourth = ((encrypted % 10) + 3) % 10;
            encrypted /= 10;

            third = ((encrypted % 10) + 3) % 10;
            encrypted /= 10;

            second = ((encrypted % 10) + 3) % 10;
            encrypted /= 10;

            first = ((encrypted % 10) + 3) % 10;


            //swap digits and convert to a number
            number = number * third * 1000;
            number = number + (fourth * 100);
            number = number + (first * 10);
            number = (number + second);

            //display decrypted number
            Console.WriteLine($"The decrypted number is {number:D4}");
            Console.ReadKey();
        }
    }
}
