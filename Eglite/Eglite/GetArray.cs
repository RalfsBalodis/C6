using System;

namespace Eglite
{
    internal class GetArray
    {
        public static char[,] GetTreeArray (int sizeX, int sizeY)
        {
            char[,] cells = new char[sizeX, sizeY];
            int offset = 0;
            int mid = sizeY / 2;

            for (int x = 0; x < sizeX; x++)
            {
                for (int y = 0; y < sizeY; y++)
                {
                    if (y < mid - offset || y > mid + offset)
                    {
                        cells[x, y] = '.';
                    }
                    else if (mid - offset >= 0)
                    {
                        cells[x, y] = '*';
                    }
                    if (mid < offset)
                    {
                        cells[x, y] = '_';
                    }
                }
                offset++;
            }
            return cells;
        }
    }
}
