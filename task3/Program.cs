//  Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt(Console.ReadLine());
            

            if ( a / 10 > a % 10  )
             {
             Console.WriteLine("a / 10");
            
             else ( a /  10 < a % 10 )
             {
             Console.WriteLine("a % 10");
             }
             }
        }

    }
}