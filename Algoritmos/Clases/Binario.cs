using System;

namespace Algoritmos
{
    public class Binario
    {
        public string ImprimirBinario(ulong n)
        {
            return (n <= 1) ? Convert.ToString(n % 2) : ImprimirBinario(n / 2) + Convert.ToString(n % 2);
        }
    }

}
