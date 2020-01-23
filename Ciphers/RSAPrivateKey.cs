using System.Numerics;

namespace Ciphers
{
    public class RSAPrivateKey
    {
        public BigInteger P { get; set; }

        public BigInteger Q { get; set; }

        public BigInteger Phi { get; set; }

        public BigInteger D { get; set; }

        private RSAPrivateKey()
        {
            // Don't allow construction without params
        }

        public RSAPrivateKey(BigInteger p, BigInteger q, BigInteger phi, BigInteger d)
        {
            this.P = p;
            this.Q = q;
            this.Phi = phi;
            this.D = d;
        }
    }
}
