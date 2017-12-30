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
            Random rand = new Random();
            string input = Console.ReadLine();
            byte[] byteinput = System.Text.Encoding.UTF8.GetBytes(input);
            byte[] key = new byte[byteinput.Length];
            byte[] output = new byte[input.Length];
            for (int i = 0; i < key.Length; i++)
            {
                key[i] = Convert.ToByte( rand.Next(1,100));
                output[i] = Convert.ToByte(key[i] + byteinput[i]);
            }
            System.IO.File.WriteAllBytes("key.txt", key);
            System.IO.File.WriteAllBytes("scripted.txt", output);
        }
    }
}