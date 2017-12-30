using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deshifr
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] input = System.IO.File.ReadAllBytes("input.txt");
            byte[] key = System.IO.File.ReadAllBytes("key.txt");
            byte[] output = new byte[input.Length];
            for (int i = 0; i < key.Length; i++)
            {
                output[i] = Convert.ToByte(input[i] - key[i]);
            }
            System.IO.File.WriteAllBytes("output.txt", output);
        }
    }
}
