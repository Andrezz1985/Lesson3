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
            int x1 = Crd("x", "A");
            int y1 = Crd("y", "A");
            int z1 = Crd("z", "A");
            int x2 = Crd("x", "B");
            int y2 = Crd("x", "B");
            int z2 = Crd("x", "B");

            int Crd(string coor_name, string point_name){
                Console.WriteLine($"Введите координату {coor_name} точки {point_name}: ");
                return Convert.ToInt16(Console.ReadLine());

            double Decision(double x1, double x2, double y1, double y2, double z1, double z2){
                return Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2) + Math.Pow((z2-z1), 2)); 
            }
            double segmentLength = Math.Round(Decision(x1, x2, y1, y2, z1, z2));
            Console.WriteLine($"Длина {segmentLength}");    
            }
        }
    }
}            