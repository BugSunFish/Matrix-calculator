using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Project_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int menu = 1;
            bool end = false;
            while (true)
            {
                Console.WriteLine("Какую операцию вы хотите провести?\n");
                if (menu == 1)
                {
                    Console.WriteLine("\t> Сложение");
                }
                else
                {
                    Console.WriteLine("\tСложение");
                }
                if (menu == 2)
                {
                    Console.WriteLine("\t> Вычитание");
                }
                else
                {
                    Console.WriteLine("\tВычитание");
                }
                if (menu == 3)
                {
                    Console.WriteLine("\t> Умножение");
                }
                else
                {
                    Console.WriteLine("\tУмножение");
                }
                ConsoleKeyInfo consoleKeyInfo = Console.ReadKey(true);
                switch (consoleKeyInfo.Key)
                {
                    case ConsoleKey.W:
                        menu--;
                        break;
                    case ConsoleKey.S:
                        menu++;
                        break;
                    case ConsoleKey.Spacebar:
                        end = true;
                        break;
                    default:
                        break;
                }
                if (menu == 0) { menu++; }
                if (end) { break; }
                Console.Clear();
            }
            Console.Clear();
            switch(menu)
            {
                case (1):
                    Console.WriteLine("Сложение матриц:\n");
                    Console.WriteLine("Введите числа первой матрицы через пробел - ");
                    break;
                case (2):
                    Console.WriteLine("Вычитание матриц:\n");
                    Console.WriteLine("Введите числа первой матрицы через пробел - ");
                    break;
                case (3):
                    Console.WriteLine("Умножение матриц:\n");
                    Console.WriteLine("Введите числа первой матрицы через пробел - ");
                    break;
            }
            //Массивы матриц
            int[,] arr = new int[3, 3];
            int[,] arr2 = new int[3, 3];
            //Первая матрица
            int number = 0;
            bool minus = false;
            for (int i = 0; i < arr.GetUpperBound(0) + 1;)
                {
                    for (int j = 0; j < arr.GetUpperBound(1) + 1;)
                    {
                        ConsoleKeyInfo consoleKeyInfo = Console.ReadKey(true);
                        switch (consoleKeyInfo.Key)
                        {
                            case ConsoleKey.D1:
                                Console.Write("1");
                                if (number != 0)
                                {
                                    number *= 10;
                                    number += 1;
                                }
                                else
                                {
                                    number += 1;
                                }
                                break;
                            case ConsoleKey.D2:
                                Console.Write("2");
                                if (number != 0)
                                {
                                    number *= 10;
                                    number += 2;
                                }
                                else
                                {
                                    number += 2;
                                }
                                break;
                            case ConsoleKey.D3:
                                Console.Write("3");
                                if (number != 0)
                                {
                                    number *= 10;
                                    number += 3;
                                }
                                else
                                {
                                    number += 3;
                                }
                                break;
                            case ConsoleKey.D4:
                                Console.Write("4");
                                if (number != 0)
                                {
                                    number *= 10;
                                    number += 5;
                                }
                                else
                                {
                                    number += 4;
                                }
                                break;
                            case ConsoleKey.D5:
                                Console.Write("5");
                                if (number != 0)
                                {
                                    number *= 10;
                                    number += 5;
                                }
                                else
                                {
                                    number += 5;
                                }
                                break;
                            case ConsoleKey.D6:
                                Console.Write("6");
                                if (number != 0)
                                {
                                    number *= 10;
                                    number += 6;
                                }
                                else
                                {
                                    number += 6;
                                }
                                break;
                            case ConsoleKey.D7:
                                Console.Write("7");
                                if (number != 0)
                                {
                                    number *= 10;
                                    number += 7;
                                }
                                else
                                {
                                    number += 7;
                                }
                                break;
                            case ConsoleKey.D8:
                                Console.Write("8");
                                if (number != 0)
                                {
                                    number *= 10;
                                    number += 8;
                                }
                                else
                                {
                                    number += 8;
                                }
                                break;
                            case ConsoleKey.D9:
                                Console.Write("9");
                                if (number != 0)
                                {
                                    number *= 10;
                                    number += 9;
                                }
                                else
                                {
                                    number += 9;
                                }
                                break;
                            case ConsoleKey.D0:
                                Console.Write("0");
                                if (number != 0)
                                {
                                    number *= 10;
                                    number += 0;
                                }
                                else
                                {
                                    number += 0;
                                }
                                break;
                        case ConsoleKey.OemMinus:
                            if (minus == false)
                            {
                                Console.Write("-");
                                minus = true;
                            }
                            break;
                        case ConsoleKey.Spacebar:
                            Console.Write("\t");
                            if (minus)
                            {
                                number *= -1;
                            }
                            arr[i, j] = number;
                            number = 0;
                            minus = false;
                            j++;
                            break;
                        default:
                            break;
                        }
                    }
                    i++;
                    Console.WriteLine();
                }
            Console.WriteLine();
            //Вторая матрица
            Console.WriteLine("Введите через пробел вторую матрицу");
            number = 0;
            minus = false;
            for (int i = 0; i < arr.GetUpperBound(0) + 1;)
            {
                for (int j = 0; j < arr.GetUpperBound(1) + 1;)
                {
                    ConsoleKeyInfo consoleKeyInfo = Console.ReadKey(true);
                    switch (consoleKeyInfo.Key)
                    {
                        case ConsoleKey.D1:
                            Console.Write("1");
                            if (number != 0)
                            {
                                number *= 10;
                                number += 1;
                            }
                            else
                            {
                                number += 1;
                            }
                            break;
                        case ConsoleKey.D2:
                            Console.Write("2");
                            if (number != 0)
                            {
                                number *= 10;
                                number += 2;
                            }
                            else
                            {
                                number += 2;
                            }
                            break;
                        case ConsoleKey.D3:
                            Console.Write("3");
                            if (number != 0)
                            {
                                number *= 10;
                                number += 3;
                            }
                            else
                            {
                                number += 3;
                            }
                            break;
                        case ConsoleKey.D4:
                            Console.Write("4");
                            if (number != 0)
                            {
                                number *= 10;
                                number += 5;
                            }
                            else
                            {
                                number += 4;
                            }
                            break;
                        case ConsoleKey.D5:
                            Console.Write("5");
                            if (number != 0)
                            {
                                number *= 10;
                                number += 5;
                            }
                            else
                            {
                                number += 5;
                            }
                            break;
                        case ConsoleKey.D6:
                            Console.Write("6");
                            if (number != 0)
                            {
                                number *= 10;
                                number += 6;
                            }
                            else
                            {
                                number += 6;
                            }
                            break;
                        case ConsoleKey.D7:
                            Console.Write("7");
                            if (number != 0)
                            {
                                number *= 10;
                                number += 7;
                            }
                            else
                            {
                                number += 7;
                            }
                            break;
                        case ConsoleKey.D8:
                            Console.Write("8");
                            if (number != 0)
                            {
                                number *= 10;
                                number += 8;
                            }
                            else
                            {
                                number += 8;
                            }
                            break;
                        case ConsoleKey.D9:
                            Console.Write("9");
                            if (number != 0)
                            {
                                number *= 10;
                                number += 9;
                            }
                            else
                            {
                                number += 9;
                            }
                            break;
                        case ConsoleKey.D0:
                            Console.Write("0");
                            if (number != 0)
                            {
                                number *= 10;
                                number += 0;
                            }
                            else
                            {
                                number += 0;
                            }
                            break;
                        case ConsoleKey.OemMinus:
                            if (minus == false)
                            {
                                Console.Write("-");
                                minus = true;
                            }
                            break;
                        case ConsoleKey.Spacebar:
                            Console.Write("\t");
                            if (minus)
                            {
                                number *= -1;
                            }
                            arr2[i, j] = number;
                            number = 0;
                            minus = false;
                            j++;
                            break;
                        default:
                            break;
                    }
                }
                i++;
                Console.WriteLine();
            }
            Console.WriteLine();
            //Вывод в консоль
            int sum = 0;
            Console.WriteLine("\nРезультат вычислений:");
            for (int i = 0; i < arr.GetUpperBound(0) + 1;)
            {
                for (int j = 0; j < arr.GetUpperBound(1) + 1; j++)
                {
                    switch (menu)
                    {
                        case 1:
                            Console.Write((arr[i, j] + arr2[i,j]) + "\t");
                            break;
                        case 2:
                            Console.Write((arr[i, j] + arr2[i, j]) + "\t");
                            break;
                        case 3:
                            for (int k = 0; k < arr.GetUpperBound(0) + 1; k++) 
                            {
                                sum += (arr[i, k] * arr2[k, j]);
                            }
                            Console.Write(sum + "\t");
                            sum = 0;
                            break;
                        default:
                            break;
                    }
                }
                i++;
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
