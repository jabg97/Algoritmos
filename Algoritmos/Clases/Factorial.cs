using System;

namespace Algoritmos
{
    public class Factorial
    {
        private ulong[] buffer;

        public void SetBuffer(uint n)
        {
            buffer = new ulong[n + 1];
        }

        public ulong FactorialRecursivo(uint n)
        {
            return (n == 1) ? 1 : FactorialRecursivo(n - 1) * n;
        }

        public ulong FactorialIterativo(uint n)
        {
            ulong resultado = 1;
            for (uint i = 1; i <= n; i++)
            {
                resultado *= i;
            }
            return resultado;
        }

        public ulong FactorialMemory(uint n)
        {
            if (buffer[n] != 0)
            {
                return buffer[n];
            }
            if (n == 1)
            {
                return 1;
            }
            buffer[n] = FactorialMemory(n - 1) * n;
            return buffer[n];
        }

    }

}
