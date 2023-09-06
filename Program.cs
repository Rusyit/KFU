using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog02092023
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задание 1
            Console.WriteLine("Задание 1. Выводит на экран Мир Труд Май");
            Console.WriteLine("Мир Труд Май");
            Console.WriteLine("Мир");
            Console.WriteLine("  Труд");
            Console.WriteLine("     Май");

            // Задание 2
            Console.WriteLine("Задание 2. Программа меняет местами две переменные");
            Console.WriteLine("ВВедите два числовые переменные: ");
            int num1 = 0, num2 = 0;
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num2 + "," + num1);

            // Задание 3

            Console.WriteLine("Задание 3. Программа находит длину окружности и площадь круга");
            Console.WriteLine("Введите радиус окружности");
            double znach1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Длина окружности = {0}", Math.PI * znach1 * 2);
            Console.WriteLine("Площадь круга = {0}", Math.PI * Math.Pow(znach1, 2));

            // Задание 4
            Console.WriteLine("Задание 4. Находит y = cos(x)");
            Console.WriteLine("Введите угол");
            double znach2 = double.Parse(Console.ReadLine());
            double znach3 = znach2 * (Math.PI) / 180;
            Console.WriteLine("Cos = {0}", Math.Cos(znach3));

            // Задание 5

            Console.WriteLine("Задание 5. Программа находит корни квадратного уравнения");
            Console.Write("Введите a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Введите c: ");
            double c = double.Parse(Console.ReadLine());
            double discrim = Math.Pow(b, 2) - 4 * a * c;
            if (discrim < 0)
            {
                Console.WriteLine("Не имеет корней");
            }
            else
            {
                double x1 = ((-b + Math.Sqrt(discrim)) / (a * 2));
                double x2 = ((-b - Math.Sqrt(discrim))/ (a * 2));
                Console.WriteLine($"x1 = {x1}; x2 = {x2}");
            }


            // Задание 6

            Console.WriteLine("Задание 6. Программа обмена значениями трех переменных");
            Console.Write("Введите a: ");
            double a1 = double.Parse(Console.ReadLine());
            Console.Write("Введите b: ");
            double b1 = double.Parse(Console.ReadLine());
            Console.Write("Введите c: ");
            double c1 = double.Parse(Console.ReadLine());
            (a1, b1, c1) = (b1, c1, a1);
            Console.Write("a ");
            Console.WriteLine(a1 + "," + b1 + "," + c1);
            (a1, b1, c1) = (c1, a1, b1);
            (a1, b1, c1) = (c1, a1, b1);
            Console.Write("b ");
            Console.WriteLine(a1 + "," + b1 + "," + c1);

            // Задание 7

            Console.WriteLine("Задание 7. Программа выводит столбиком четыре случайных чисел");
            Random random = new Random();

            Console.WriteLine(random.Next());
            Console.WriteLine(random.Next());
            Console.WriteLine(random.Next());
            Console.WriteLine(random.Next());

            // Задание 8
            Console.WriteLine("Задание 8. Программа меняет местами последнюю и первую цифру трехзначного числа");
            Console.WriteLine("Введите трёхзначное число");
            int num11 = Int32.Parse(Console.ReadLine()); // вводим трёхзначное натуральное число 
            int numl = num11 % 10 * 100;
            int nums = num11 / 10;
            int numlast = numl + nums;
            Console.WriteLine(numlast);

            // Задание 9
            Console.WriteLine("Задание 9. Программа находит стоимость покупки");
            double k, p, y, kg1, kg2, kg3, pokup;

            Console.WriteLine("Сколько кг конфет куплено?");
            k = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Сколько кг печенья куплено?");
            p = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Сколько кг яблок куплено?");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Сколько стоит 1 кг конфет?");
            kg1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Сколько стоит 1 кг печенья?");
            kg2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Сколько стоит 1 кг яблок?");
            kg3 = Convert.ToDouble(Console.ReadLine());

            pokup = (k * kg1) + (p * kg2) + (y * kg3);

            Console.WriteLine();
            Console.WriteLine("Cтоимость всей покупки " + pokup);
        }
        
    }
    
}
