using System;

namespace MyFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1
            string r;
            Console.WriteLine("Введите имя студента: ");
            r = Console.ReadLine();
            Console.WriteLine("Имя студента: " + r);
            // Задание 2
            Console.WriteLine("Введите коэффициент a: ");
            int.TryParse(Console.ReadLine(), out int a);
            Console.WriteLine("Введите коэффициент b: ");
            int.TryParse(Console.ReadLine(), out int b);
            Console.WriteLine("Введите коэффициент c: ");
            int.TryParse(Console.ReadLine(), out int c);
            double dis, x1, x2;
            dis = b ^ 2 - 4 * a * c;
            if (dis > 0)
            {
                x1 = (-b + Math.Sqrt(dis)) / 2 * a;
                x2 = (-b - Math.Sqrt(dis)) / 2 * a;
                Console.WriteLine("Коэффициент x1: " + x1);
                Console.WriteLine("Коэффициент x2: " + x2);
            }
            if (dis == 0)
            {
                x1 = -b / 2 * a; 
                x2 = -b / 2 * a;
                Console.WriteLine("Коэффициент x1, x2: " + x1 + x2);
            }
            if (dis < 0) 
            {
                Console.WriteLine("Коэффициентов не существует!");
            }
            // Задание 3
            double g, h, gip;
            Console.WriteLine("Введите длину первого катета: ");
            double.TryParse(Console.ReadLine(), out g);
            Console.WriteLine("Введите длину второго катета: ");
            double.TryParse(Console.ReadLine(), out h);
            gip = Math.Sqrt(g * g + h * h);
            Console.WriteLine("Длина гипотенузы: " + gip);

            // Задание 4
            double kyt, kyt1;
            kyt = Math.Tan(a / b) * 180 / Math.PI;
            kyt1 = 90 - kyt;
            Console.WriteLine("Угол 1: " + kyt);
            Console.WriteLine("Угол 2: " + kyt1);

            // Задание 5
            
            Console.WriteLine("Нажмите любую клавишу для завершение программы: ");
            Console.ReadKey();
        }
    }
}
