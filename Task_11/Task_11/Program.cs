using System;

namespace ConsoleApplication12
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "", output = "";//входная строка и строка с результатом
            bool ok, onlyBinary;
            do
            {
                ok = false;
                onlyBinary = false;
                Console.WriteLine("Введите последовательность только из 0 и 1, количество символов кратно 3");
                input = Console.ReadLine();
                // проверка на содержание символов помимо 0 и 1
                string tempstr = input.Replace("0", "");
                tempstr = tempstr.Replace("1", "");
                onlyBinary = tempstr.Length == 0;
                if (!onlyBinary)
                {
                    Console.WriteLine("Сообщение содержит посторонние символы!");
                }
                else
                {
                    // поскольку каждый символ кодируется тремя, то количество 0 и 1 должно быть кратно трём
                    if (input.Length % 3 == 0)
                        ok = true;
                    else
                        Console.WriteLine("Количество символов не кратно 3!");
                }

            }
            while ((!ok) || (!onlyBinary));
            char temp;

            //алгоритм для декодирования
            for (int i = 0; i < input.Length / 3; i++)
            {
                //блоки по три символа
                temp = input[i * 3];
                //если первый символ не один в кодировке, то является расшифровкой
                if ((temp == input[i * 3 + 1]) || (temp == input[i * 3 + 2]))
                {
                    output += temp;
                }
                else
                //иначе расшифровкой являются остальные два символа
                {
                    if (input[i * 3 + 1] == input[i * 3 + 2])
                        output += input[i * 0 + 1];
                }
            }
            Console.WriteLine("Расшифровка: " + output);
            Console.ReadLine();

        }
    }
}

