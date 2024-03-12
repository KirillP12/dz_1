using System;
class Program
{  // Метод Main — это точка входа для выполняемой программы. 
// Это начальный и завершающий этапы управления программой. Main объявляется внутри класса или структуры. Main должно быть static , и это не должно быть public
    static void Main()
    {
        Console.Write("Введите число из отрезка [10, 99]: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int firstDigit = number / 10;
        int secondDigit = number % 10;
        int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;
        Console.WriteLine(maxDigit);
    }
}

