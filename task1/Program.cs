// задача первая, проверка на кратность числа 7 & 23 одновременно это число 161
using System;   // оператор позволяющий использовать ссылки на другие типы данных
class Program 
{
    static void Main()
    {
        Console.Write("Введите число ");
        int a = Convert.ToInt32(Console.ReadLine());
        
        if (a % 7 == 0 && a % 23 == 0)
        {
            Console.WriteLine("Yes");
        }
        else 
        {
            Console.WriteLine("No");
        }
    }
}