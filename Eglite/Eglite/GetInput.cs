using System;

namespace Eglite
{
    internal class GetInput
    {
        public static int GetArraySize()
        {
            Console.WriteLine("Enetr tree size...");           
            string input = Console.ReadLine();
            Console.Clear();
            int x = 0;     
            string output = "";

            foreach (var c in input)
            {
                if (char.IsDigit(c))
                {
                    output += c;
                }
            }
            if (output != "")
            {
                if (output.Length > 9)
                {
                    output = output.Substring(0, 9);
                }
                Int32.TryParse(output, out x);

                if (x % 2 == 0)
                {               
                    x += 1;
                }

                if (x > 51)
                {
                    x = 51;
                }
            }
            return x;
        }
    }
}
