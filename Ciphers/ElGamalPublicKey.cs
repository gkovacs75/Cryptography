using System.Numerics;

namespace Ciphers
{
    public class ElGamalPublicKey
    {
        public BigInteger P { get; set; }

        public BigInteger Alpha { get; set; }

        public BigInteger AlphaToA { get; set; }

        private ElGamalPublicKey()
        {
            // Don't allow construction without params
        }

        public ElGamalPublicKey(BigInteger p, BigInteger alpha, BigInteger alphaToA)
        {
            this.P = p;
            this.Alpha = alpha;
            this.AlphaToA = alphaToA;
        }
    }
}
