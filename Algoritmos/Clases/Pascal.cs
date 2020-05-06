using System;

namespace Algoritmos
{
    public class Pascal
    {
        private ulong[][] triangle;

        public void SetHeight(uint h)
        {
            triangle = new ulong[h + 1][];
            for (uint y = 1; y <= h; y++)
            {
                triangle[y] = new ulong[y + 1];
            }
        }


        public ulong AlgoritmoBase(uint y, uint x)
        {
            return (x == 1 || x == y) ? 1 : AlgoritmoBase(y - 1, x - 1) + AlgoritmoBase(y - 1, x);
        }

        public ulong PascalMemory(uint y, uint x)
        {
            if (triangle[y][x] != 0)
            {
                return triangle[y][x];
            }
            if (x == 1 || x == y)
            {
                triangle[y][x] = 1;
                return 1;
            }
            triangle[y][x] = PascalMemory(y - 1, x - 1) + PascalMemory(y - 1, x);
            return triangle[y][x];
        }

        

        public void PascalRecursivo(uint h)
        {
            for (uint y = 1; y <= h; y++)
            {
                for (int i = 0; i < h - y; i++)
                {
                    Console.Write(" ");
                }
                for (uint x = 1; x <= y; x++)
                {
                    Console.Write(" " + AlgoritmoBase(y, x));
                }
                Console.WriteLine();
            }
        }

        public void PascalRecursivoMemory(uint h)
        {
            for (uint y = 1; y <= h; y++)
            {
                for (uint x = 1; x <= y; x++)
                {
                    PascalMemory(y, x);
                }
            }
        }

        public void PascalIterativo(uint h)
        {
            for (uint y = 1; y <= h; y++)
            {
                for (uint x = 1; x <= y; x++)
                {
                    if (x == 1 || x == y)
                    {
                        triangle[y][x] = 1;
                    }
                    else
                    {
                        triangle[y][x] = triangle[y - 1][x - 1] + triangle[y - 1][x];
                    }
                }
            }
        }

        public void DibujarPascal()
        {
            for (uint y = 1; y < triangle.Length; y++)
            {
                for (int i = 0; i < triangle.Length - y; i++)
                {
                    Console.Write(" ");
                }
                for (uint x = 1; x <= y; x++)
                {
                    Console.Write(" " + triangle[y][x]);
                }
                Console.WriteLine();
            }
        } 
    }
}
