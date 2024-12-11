namespace Eglite
{
    internal class GetArray
    {
        public static char[,] GetArrayTree(int sizeX, int sizeY)
        {
            char[,] cells = new char[sizeX, sizeY];
            int offset = 0;
            int mid = sizeY / 2;

            for (int x = 0; x < (sizeX / 2) + 1; x++)
            {
                for (int y = 0; y < sizeY; y++)
                {
                    if (y < mid - offset || y > mid + offset)
                    {
                        cells[x, y] = '0';
                    }
                    else
                    {
                        cells[x, y] = '1';
                    }
                    if (mid < offset)
                    {
                        break;
                    }
                }
                offset++;
            }

            return cells;
        }
    }
}
