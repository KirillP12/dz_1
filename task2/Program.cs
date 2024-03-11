// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x: ");
            double x = Convert.ToDouble(Console.ReadLine());
 
            Console.WriteLine("Введите y: ");
            double y = Convert.ToDouble(Console.ReadLine());
 
            if (x > 0 && y > 0)      // фукция && ( и ) может работать при обведении переменных в скобочки с функцикцией > а может работать и без скобочек дополнительных в теле функции,
            // может работь и так if ((X<0)&&(Y>0)) и так if (X>0 && Y<0 )  
                Console.Write("I четверть"); // функция Console.WriteLine выводит на экран ту надпись которую мы посестим в скобки между ковычками
            else
            {
                if ((x < 0) && (y > 0))
                    Console.WriteLine("II четверть");
                else
                {
                    if ((x < 0) && (y < 0))
                        Console.WriteLine("III четверть");
                    else
                    {
                        if ((x > 0) && (y < 0))
                            Console.WriteLine("IV четверть");
                        else
                            Console.WriteLine("Точка лежит на оси");
                    }
                    Console.ReadKey();     
                }
            }
        }  // надо заметить что все условия в скобочках друг у друга при выполнении алгоритма условияя, функция в функции. 
    }
}