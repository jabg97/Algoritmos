
namespace Algoritmos
{
    public class Fibonacci
    {
        private ulong[] buffer;

        public void SetBuffer(uint n)
        {
            buffer = new ulong[n + 1];
        }

        public ulong FibonacciRecursivo(uint n)
        {
            return (n == 0 || n == 1) ? 1 : FibonacciRecursivo(n - 1) + FibonacciRecursivo(n - 2);
        }

        public ulong FibonacciIterativo(uint n)
        {
            ulong resultado = 1;
            if (n== 0 || n == 1)
            {
                return 1;
            }
            for (uint i = 2; i <= n; i++)
            {
                resultado += (i-1) + (i-2);
            }
            return resultado;
        }

        public ulong FibonacciMemory(uint n)
        {
            if (buffer[n] != 0)
            {
                return buffer[n];
            }
            if (n == 0 || n == 1)
            {
                return 1;
            }
            buffer[n] = FibonacciMemory(n - 1) + FibonacciMemory(n - 2);
            return buffer[n];
        }
    }

}
