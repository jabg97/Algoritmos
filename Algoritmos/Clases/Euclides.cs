
namespace Algoritmos
{
    public class Euclides
    {
        public ulong MCD(ulong n1, ulong n2)
        {
            return (n1 % n2 == 0) ? n2 : MCD(n2, n1 % n2);
        }
    }

}
