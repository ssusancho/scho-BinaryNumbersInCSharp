using System;

namespace scho_BinaryNumbersInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            x = 42;
            Console.WriteLine(x);
            
            string x_binary = "0b" + Convert.ToString(x, 2);
            Console.WriteLine(x_binary);
            string x_hex = "0x" + Convert.ToString(x, 16);
            Console.WriteLine(x_hex);

            int y;
            y = -1;
            string y_binary = "0b" + Convert.ToString(y, 2);
            Console.WriteLine(y_binary);

            int z;
            z = y - 1;
            string z_binary = "0b" + Convert.ToString(z, 2);
            Console.WriteLine(z_binary);

            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);

             string max_binary = "0b" + Convert.ToString(int.MaxValue, 2);
             Console.WriteLine(max_binary);
             string min_binary = "0b" + Convert.ToString(int.MinValue, 2);
             Console.WriteLine(min_binary);

             int max = int.MaxValue;
             int max_plus_1 = max + 1;
             Console.WriteLine(max_plus_1);
             string max_plus_1_binary = "0b" + Convert.ToString(max_plus_1, 2);
             Console.WriteLine(max_plus_1_binary);

        }
    }
}
