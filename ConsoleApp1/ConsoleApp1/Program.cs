using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            char key = char.Parse(Console.ReadLine());

            char[] shifr = new char[text.Length];
            byte[] scripted = new byte[shifr.Length];
            for (int i = 0; i < shifr.Length; i++)
            {

                shifr[i] = text[i];
                scripted[i] = Convert.ToByte(shifr[i] + key);
                Console.Write(scripted[i]);
            }


        }
    }
}