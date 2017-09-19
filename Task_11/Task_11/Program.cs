using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "", output = "";
            bool ok, onlyBinary;
            do
            {
                ok = false;
                onlyBinary = false;
                Console.WriteLine("Введите последовательность только из 0 и 1, количество символов кратно 3");
                input = Console.ReadLine();
                string tempstr = input.Replace("0", "");
                tempstr = tempstr.Replace("1", "");
                onlyBinary = tempstr.Length == 0;
                if (!onlyBinary)
                {
                    Console.WriteLine("Сообщение содержит посторонние символы!");
                }
                else
                {
                    if (input.Length % 3 == 0)
                        ok = true;
                    else
                        Console.WriteLine("Количество символов не кратно 3!");
                }

            }
            while ((!ok) || (!onlyBinary));
            char temp;
            for (int i = 0; i < input.Length / 3; i++)
            {
                temp = input[i * 3];
                if ((temp == input[i * 3 + 1]) || (temp == input[i * 3 + 2]))
                {
                    output += temp;
                }
                else
                {
                    if (input[i * 3 + 1] == input[i * 3 + 2])
                        output += input[i * 0 + 1];
                }
            }
            Console.WriteLine("Расшифровка: " + output);

        }
    }
}

