using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 64: Задайте значение N.Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.Выполнить с помощью рекурсии.
            //N = 5-> "5, 4, 3, 2, 1"
            //N = 8-> "8, 7, 6, 5, 4, 3, 2, 1"

            //Задача 66: Задайте значения M и N.Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
            //M = 1; N = 15-> 120
            //M = 4; N = 8. -> 30

            //Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
            //m = 2, n = 3->A(m, n) = 9
            //m = 3, n = 2->A(m, n) = 29
            Console.Write("-----------------------\n");
            Console.WriteLine("задача 64");
            Console.WriteLine(@"Метод рекурсией.
            Выводит числа от n до 1.");
            Console.Write("---------------------------------------------------------\n");
            Console.Write("Введите значение n1 от которого будет начинаться отсчет : ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            PrintNumber(n1, 1);
            Console.WriteLine();
            Console.Write("-----------------------\n");
            Console.WriteLine("задача 66");
            Console.WriteLine("Нахождение суммы натуральных чисел от M до N");
            Console.Write("------------------------------------------------------\n");
            Console.WriteLine("Введите значения M и N ");
            Console.Write("------------------------\n");
            Console.Write("Значения M =");
            int M = Convert.ToInt32(Console.ReadLine());
            Console.Write("Значения N =");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.Write("-----------------------\n");
            int count = 0;
            SummaNumber(M, N, count);
            Console.Write("-----------------------\n");
            Console.WriteLine("задача 68");
            Console.WriteLine("Нахождение вычисления функции Аккермана с помощью рекурсии");
            Console.Write("------------------------------------------------------\n");
            Console.WriteLine("Введите значения m и n ");
            Console.Write("------------------------\n");
            Console.Write("Значения m =");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Значения N =");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("-----------------------\n");
            int functionAkkerman = Ackermann(m, n);
            Console.WriteLine($"Функция Аккермана = {functionAkkerman} ");
        }
        static int PrintNumber(int n1, int number)
        {
            if (n1 < 1)
            {
                return number;
            }
            else
            {
                Console.Write(" {0} ", n1);

                n1--;
                return PrintNumber(n1, number);
            }

        }
        static void SummaNumber(int M, int N, int count)
        {
            count = 0;
            for (int i = M; i <= N; i++)
            {
                count += i;
            }
            Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N  равна {count}");


        }
        static int Ackermann(int m, int n)
        {
            if (m == 0) return n + 1;
            if (m > 0 && n == 0) return Ackermann(m - 1, 1);

            return Ackermann(m - 1, Ackermann(m, n - 1));
        }

    }
}
