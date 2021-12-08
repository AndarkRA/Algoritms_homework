using System;


namespace Homeworks
{
    class Program
    {
        /*1. Напишите на C# функцию согласно блок-схеме
        Требуется реализовать на C# функцию согласно блок-схеме. Блок-схема описывает алгоритм проверки, простое число или нет.
        Написать консольное приложение.
        Алгоритм реализовать отдельно в функции согласно блок-схеме.
        Написать проверочный код в main функции .
        Код выложить на GitHub.
        */
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int n = int.Parse(Console.ReadLine());
            EasyOrHard(n);
        }

        private static string EasyOrHard(int n)
        {
            int d = 0;
            int i = 2;

            while (i < n)
            {
                if ((n % i) == 0)
                {
                    d++;
                }
                i++;
            }

            if (d == 0)
            {
                Console.WriteLine($"{n} простое число");
                return "простое";
            }
            else
            {
                Console.WriteLine($"{n} непростое число");
                return "не простое";
            }
        }
    }
}


/*
2. Посчитайте сложность функции
public static int  StrangeSum(int[] inputArray)
{
    int sum = 0; //O(1)
    for (int i = 0; i < inputArray.Length; i++) //О(N)
    {
        for (int j = 0; j < inputArray.Length; j++) //О(N)
        {
            for (int k = 0; k < inputArray.Length; k++) //О(N)
            {
                int y = 0; //O(1)
                if (j != 0) // O(N + 1)
                {
                    y = k / j; //O(2)
                }
                sum += inputArray[i] + i + k + j + y; //O(5)
            }
        }
    }
    return sum; //O(1)
}
Сложность: 9 + (N+1) + N^3
*/
