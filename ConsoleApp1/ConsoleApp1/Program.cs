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
            string input = Console.ReadLine();
            byte[] byteinput = System.Text.Encoding.Unicode.GetBytes(input);
            byte[] key = new byte[byteinput.Length];
            byte[] output = new byte[byteinput.Length];
            for (int i = 0; i < key.Length; i++)
            {
                key[i] = Convert.ToByte( rand.Next(1,100));
                int sum = key[i] + byteinput[i];
                if (sum >= 256) { sum -= 256; }
                output[i] = Convert.ToByte(sum);
            }
            System.IO.File.WriteAllBytes("key.txt", key);
            System.IO.File.WriteAllBytes("scripted.txt", output);
        }
    }
}