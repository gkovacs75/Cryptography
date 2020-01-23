using System.Numerics;

namespace Ciphers
{
    public class RSAPublicKey
    {
        public BigInteger N { get; set; }

        public BigInteger E { get; set; }

        private RSAPublicKey()
        {
            // Don't allow construction without params
        }

        public RSAPublicKey(BigInteger n, BigInteger e)
        {
            this.N = n;
            this.E = e;
        }
    }
}
