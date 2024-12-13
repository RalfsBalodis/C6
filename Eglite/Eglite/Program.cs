using System;

namespace Eglite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int x = GetInput.GetArraySize();

                PrintOutput.PrintArray(GetArray.GetTreeArray(x, x));

                Console.ReadLine();

                Console.Clear();
            }
        }

    }
}
