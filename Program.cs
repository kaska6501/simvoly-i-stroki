using System;

namespace simvoly_i_stroki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;

            //Console.WriteLine("Введите символ:");
            //char symbol = (char)Console.Read();

            //if (Char.IsLetter(symbol)) // == true
            //    Console.WriteLine("Вы ввели букву!");
            //else Console.WriteLine("Вы ввели НЕ букву");

            //if (Char.IsLetterOrDigit(symbol)) // == true
            //    Console.WriteLine("Вы ввели букву или число!");
            //else Console.WriteLine("Вы ввели какой-то другой символ!");

            //if (Char.IsLower(symbol))
            //{
            //    Console.Write("Буква в нижнем регистре. Меняем на верхний: ");
            //    Console.WriteLine(Char.ToUpper(symbol));
            //}
            //else
            //{
            //    Console.Write("      Буква в верхнем регистре. Меняем на нижний: ");
            //    Console.WriteLine(Char.ToLower(symbol));
            //}

            char[] town = { 'К', 'и', 'р', 'о', 'в', 'с', 'к' };

            //for (int i = 0; i < town.Length; i++)
            //{ 
            //    Console.Write(town[i]);
            //}

            string str = "Дратути"; //инициализация
            //string str1 = null; //строка есть, но в ней ничего нет; используется для сравнения
            //string str2 = String.Empty; //строка есть, но она пустая
            //string str3 = new String('a', 7);
            //Console.WriteLine(str3);
            //string str4 = new String(town); //собираю массив строку
            //Console.WriteLine(str4);
            //Console.Write($"Длина строки: {str4.Length}");
            //Console.WriteLine(str);
            //Console.Write($"Длина строки: {str.Length}");

            string str5 = " всем";
            //str += str5;
            //Console.WriteLine(str);

            //str = String.Concat(str, str5);
            //Console.WriteLine(str);

            //if (String.Compare(str, str5) == 1)
            //    Console.WriteLine("Строки совпадают!");
            //else Console.WriteLine("Строки НЕ совпадают!");
            string[] values = { str, str5 };
            str = String.Join("", values);
            Console.WriteLine(str);

            Console.ReadKey();
        }
    }
}
