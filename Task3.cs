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
            Console.WriteLine("Введите число: ");
            int cube = Convert.ToInt32(Console.ReadLine());

            void Cube(int[] cube){
                int n = 0;
                int length = cube.Length;
                while (n < length){
                    cube[n] = Convert.ToInt32(Math.Pow(n, 3));
                    n++;
                }
            }
            void PrintArry(int[] coll){
                int num = coll.Length;
                int index = 0
                while(index < num){
                    Console,WriteLine(coll[index]+ "  ");
                    index++;
                }
            }
            int[] arry = new int[cube+1];
            Cube(arry);
            PrintArry(arry);
        }
    }
}