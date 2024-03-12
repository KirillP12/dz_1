Console.Write("Введите строку:");
            string str = Console.ReadLine();
 
            int max = int.Parse(str[0].ToString());
 
            for (int i = 1; i < str.Length; i++)
            {
                if (max < int.Parse(str[i].ToString()))
                    max = int.Parse(str[i].ToString());
            }
                Console.WriteLine("Наибольшая цифра = " + max);
            Console.ReadKey();


