using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//А где из файла считывание и графический интерфейс? тыж вроде делал
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            string text = Console.ReadLine();
            byte[] key = new byte[text.Length];
            for(int i =0; i < text.Length; i++)
            {
                key[i] = Convert.ToByte( rand.Next(0, 100));
                Console.Write(key[i]);
            }

            Console.WriteLine();
            
            char[] shifr = new char[text.Length];
            byte[] scripted = new byte[shifr.Length];
            for (int i = 0; i < shifr.Length; i++)
            {

                shifr[i] = text[i];
                scripted[i] = Convert.ToByte(shifr[i] + key[i]);

                Console.Write(scripted[i]);
            }
            

        }
    }
}