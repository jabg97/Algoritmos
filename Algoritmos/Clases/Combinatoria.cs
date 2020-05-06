
using System;
namespace Algoritmos
{
    public class Combinatoria
    {
        private Factorial factorial = new Factorial();
        private Pascal pascal = new Pascal();

        /*
        * Formula: combinacion(n,r) = combinacion(n-1, r-1) + combinacion(n-1, r)
        */
        public ulong FormulaPascal(uint n, uint r)
        {
            return Combinaciones(n - 1, r - 1) + Combinaciones(n - 1, r);
        }

        public ulong TrianguloPascal(uint n, uint r)
        {
            return pascal.AlgoritmoBase(n,r);
        }

        /*
        * Formula: n!/r! * (n - r)!
        * Es decir permutacion(n,r) * 1/r!
        */
        public ulong Combinaciones(uint n, uint r)
        {
            return Convert.ToUInt64(Permutaciones(n, r) * (1.0 / (factorial.FactorialIterativo(r))));
        }

        /*
        * Formula: n!/(n - r)!
        */
        public ulong Permutaciones(uint n, uint r)
        {
            return factorial.FactorialIterativo(n) / factorial.FactorialIterativo(n - r);
        }
    }
}
