using System;

namespace Eglite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = GetInput.GetArraySize();
            PrintOutput.PrintArray(GetArray.GetTreeArray(x, x));

            Console.ReadLine();
        }

    }
}
