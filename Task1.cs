using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args){
            Console.WriteLine("Введите число");
            string? number = Console.ReadLine();

            void CheckingNumber(string number){
              if (number[0] == number[4] && number[1] == number[3]){
                  Console.WriteLine("Ваше число "  + number +  " палиндром.");
              }
              else Console.WriteLine("Ваше число "  + number +  " не палиндром.");
            
            if (numder!.Length == 5){
                CheckingNumber(number);        
            }
            else {
                Console.WriteLine($"Введи правильное число");
            }

            }
    }    
}