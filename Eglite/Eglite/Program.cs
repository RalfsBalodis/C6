using System;

namespace Eglite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = GetInput.GetArraySize();
            PrintOutput.PrintArray(GetArray.GetArrayTree(x, x));
        }

    }
}
