using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_pril_lab4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Введите кол-во студентов: ");
            //int n = int.Parse(Console.ReadLine());
            RealNumbers xyz = new RealNumbers();
            
            xyz.input();
            xyz.output();
            
            //объект, инициализированный конструктором без параметров
            RealNumbers st1 = new RealNumbers();
            Console.WriteLine("Инициализация конструктором без параметров: "); 
            st1.output();
            
            //объект, инициализированный конструктором с параметрами
            RealNumbers st2 = new RealNumbers(0.0001, 2, 345);
            Console.WriteLine("Инициализация конструктором c параметрами: ");
            st2.setY(0.03);
            st2.output();
            Console.ReadKey(true);

            

        }
    }
}
