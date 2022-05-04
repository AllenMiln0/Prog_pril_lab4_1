using System;
using System.IO;
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

            int choise = 0;

            bool temp = true;
            while (temp)
            {
                Console.WriteLine("Выберите способ ввода: 1- чтение из файла, 2 - ввод вручную");
                
                choise = Convert.ToInt32(Console.ReadLine());
                if (choise == 1 || choise == 2) temp = false;
                if (temp) Console.WriteLine("Введите снова.");
            }

            if (choise == 1)
            {
                xyz.diskOut();
            }
            else xyz.diskIn();
           /* xyz.diskIn();
            xyz.diskOut(); 
            
            //объект, инициализированный конструктором без параметров
            RealNumbers st1 = new RealNumbers();
            Console.WriteLine("Инициализация конструктором без параметров: "); 
            st1.diskOut();
            
            //объект, инициализированный конструктором с параметрами
            RealNumbers st2 = new RealNumbers(0.0001, 2, 345);
            Console.WriteLine("Инициализация конструктором c параметрами: ");
            st2.setY(0.03);
            st2.diskOut();
            Console.ReadKey(true);

            */
            
        }
    }
}
