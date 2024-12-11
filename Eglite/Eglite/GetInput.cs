using System;

namespace Eglite
{
    internal class GetInput
    {
        public static int GetArraySize()
        {
            int x = 0;
            string input = Console.ReadLine();
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
                output = output.Substring(0,9);
                Int32.TryParse(output, out x);
                if (x > 100)
                {
                    x = 100;
                }
            }
            return x;
        }
    }
}
