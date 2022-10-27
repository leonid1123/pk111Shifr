using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pk111Shifr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string alfavit = "абвгдеёжзийклмнопрстуфхцчшщъыьэюяабвгдеёжзийклмнопрстуфхцчшщъыьэюя";
            Console.WriteLine("Добро пожаловать в программу шифрования по методу 'Шифр Цезаря'");
            Console.WriteLine("Введите текст не длинее 200 символов с учетом пробелов и нажмите ENTER");
            string userInput = Console.ReadLine();
            Console.WriteLine("Вы написали:" + userInput);
            Console.WriteLine("Укажите величину сдвига в виде целого числа и нажмите ENTER");
            int sdvig = 0;
            bool uspeh = false;
            do
            {
                string userInputSdvig = Console.ReadLine();
                uspeh = int.TryParse(userInputSdvig, out sdvig);
                if (!uspeh)
                {
                    Console.WriteLine("Цифра введена неверно! Попробуйте еще раз.");
                }
            } while (!uspeh) ;
            Console.WriteLine("Вы написали:" + sdvig);
            Console.WriteLine("Успешность преобразования:" + uspeh);
            string newAlfavit="";
            for(int i = 0; i < 33; i++)
            {
                newAlfavit = newAlfavit + alfavit[i+sdvig];
            }
            Console.WriteLine(alfavit);
            Console.WriteLine(newAlfavit);
            for(int i = 0; i < userInput.Length; i++)
            {
                int nomer = alfavit.IndexOf(userInput[i]);
                Console.Write(newAlfavit[nomer]);
            }
            Console.ReadLine();
        }
    }
}
