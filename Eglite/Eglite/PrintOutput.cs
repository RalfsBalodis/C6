using System;

namespace Eglite
{
    internal class PrintOutput
    {
        public static void PrintArray(char[,] tree)
        {
            Console.Clear();
            if (!CheckInputData.ChekArraySize(tree.GetLength(0)))
            { 
                Console.WriteLine("Input is 0. No tree for you!"); 
            }

            else {
                for (int x = 0; x < tree.GetLength(0) / 2 + 1; x++)
                {
                    for (int y = 0; y < tree.GetLength(1); y++)
                    {
                        if (char.IsDigit(tree[x, y]))
                        {
                            Console.Write(tree[x, y]);
                        }
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
