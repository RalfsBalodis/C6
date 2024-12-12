using System;

namespace Eglite
{
    internal class PrintOutput
    {
        public static void PrintArray(char[,] tree)
        {
            int printedX = 0;

            Console.Clear();
            if (tree.GetLength(0) == 0)
            {
                Console.WriteLine("Input is 0. No tree for you!");
            }
            else
            {
                bool stop = false;

                for (int x = 0; x < tree.GetLength(0); x++)
                {
                    for (int y = 0; y < tree.GetLength(1); y++)
                    {
                        if (tree[x, y] == '_')
                        {
                            stop = true;
                            break;
                        }
                        else
                        {
                            Console.Write(tree[x, y]);                        
                        }
                    }
                    if (!stop)
                    {
                        Console.WriteLine();
                        printedX++;                        
                    }
                    else
                    {                        
                        Console.WriteLine($"\nArrray size: {tree.GetLength(0)} x {tree.GetLength(1)}\nPrinted lines: {printedX}\nPress Enter to close...");
                        break;
                    }
                }
            }
        }
    }
}
