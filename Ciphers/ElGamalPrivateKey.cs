using System.Numerics;

namespace Ciphers
{
    public class ElGamalPrivateKey
    {
        public BigInteger A { get; set; }

        private ElGamalPrivateKey()
        {
            // Don't allow construction without params
        }

        public ElGamalPrivateKey(BigInteger a)
        {
            this.A = a;
        }
    }
}
