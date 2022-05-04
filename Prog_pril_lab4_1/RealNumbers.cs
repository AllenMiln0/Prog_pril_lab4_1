using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Prog_pril_lab4_1
{
    class RealNumbers
    {
        private double x, y, z;

        public RealNumbers(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public RealNumbers()
        {
            this.x = 234.1;
            this.y = 0;
            this.z = 7.0003;
        }
        public double getX() { return x; }
        public double getY() { return y; }
        public double getZ() { return z; }
        public void setX(double x1) { x = x1; }
        public void setY(double x1) { y = x1; }
        public void setZ(double x1) { z = x1; }

        public void diskIn()/*пользовательские данные в файл*/
        {
            StreamWriter F = new StreamWriter("test.txt", false);
            Console.Write("Введите Х: "); 
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите Y: ");
            y = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите Z: ");
            z = Convert.ToDouble(Console.ReadLine());
            string str_f1, str_f2;
            str_f1 = x.ToString() + " " + y.ToString() + " " + z.ToString();
            str_f2 = Convert.ToString(sr_geom()) + " " + Convert.ToString(count_digit());
            string str = String.Format("{0,-15:F6}{1,-15:F6}{2, -15:F6}{3, -20:F6}{4}\n", x, y, z, sr_geom(), count_digit());
            Console.WriteLine(str);
            F.WriteLine(str_f1);
            F.WriteLine(str_f2);
            F.Close();
        }
        
        public void diskOut()/*чтение из файла*/
        {

            StreamReader F = new StreamReader("test.txt");
            string data;
            data = F.ReadLine();
            string [] str2 = data.Split(' ');
            x = Convert.ToDouble(str2[0]);
            y = Convert.ToDouble(str2[1]);
            z = Convert.ToDouble(str2[2]);
            Console.WriteLine("X\t\tY\t\tZ\tCреднее геометрическое   Количество цифр суммы");
            
            string str = String.Format("{0,-15:F6}{1,-15:F6}{2, -15:F6}{3, -20:F6}{4}\n", x, y, z, sr_geom(), count_digit());
            Console.WriteLine(str);
            F.Close();
            
        }
        public double sr_geom()
        {
            double rez = 0;
            double temp = x * y * z;
            rez = Math.Pow(temp, (1.0 / 3.0));
            return rez;
        }

        public int count_digit()
        {
            int rez = 0;
            double temp = x + y + z;
            string temp1 = temp.ToString();
            if (temp1.Length == 1) rez = temp1.Length;
            else rez = temp1.Length - 1;
            return rez;
        }


        public int CompareTo(RealNumbers obj)
        {
            x.CompareTo(obj.getX());
            y.CompareTo(obj.getY());
            z.CompareTo(obj.getZ());
            return 0;
        }

    }
}
