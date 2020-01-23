using System;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;

namespace Ciphers
{
    public class RSA
    {
        #region Declarations/Properties

        private RNGCryptoServiceProvider cryptoServiceProvider = new RNGCryptoServiceProvider(); // Used to provide random numbers        
        private PrimalityTest primalityTestToUse { get; set; }
        private int securityToken;

        private BigInteger p;
        private BigInteger q;
        private BigInteger n;
        private BigInteger phi;
        private BigInteger e;
        private BigInteger d;

        public RSAPublicKey PublicKey { get; private set; }
        public RSAPrivateKey PrivateKey { get; private set; }

        #endregion

        #region Constructors

        private RSA()
        {

        }

        public RSA(PrimalityTest primalityTest, int securityToken)
        {
            this.primalityTestToUse = primalityTest;
            this.securityToken = securityToken;
        }

        #endregion

        #region Public Methods

        public void KeyGeneration(int keySize)
        {
            this.n = GenerateN(keySize, out p, out q);
            this.phi = (p - 1) * (q - 1);
            this.e = GenerateE(phi);
            this.d = Helpers.MultiplicativeInverse(e, phi);

            this.PublicKey = new RSAPublicKey(n, e);
            this.PrivateKey = new RSAPrivateKey(p, q, phi, d);
        }

        public string Encrypt(string plainText, RSAPublicKey publicKey)
        {
            byte[] plainTextAsBytes = Encoding.UTF8.GetBytes(plainText);

            BigInteger plainTextAsNumber = new BigInteger(plainTextAsBytes);

            if (plainTextAsNumber > publicKey.N)
            {
                // Chunking is not suported since it was implemented already in Assignment 3.
                throw new Exception("The Master Key cannot exceed n");
            }

            BigInteger cipherTextAsBigInteger = Helpers.SquareAndMultiply(plainTextAsNumber, publicKey.E, publicKey.N);

            byte[] cipherTextAsBytes = cipherTextAsBigInteger.ToByteArray();

            string cipherText = Convert.ToBase64String(cipherTextAsBytes);

            return cipherText;
        }

        public string Decrypt(string cipherText)
        {
            byte[] cipherTextAsBytes = Convert.FromBase64String(cipherText);

            BigInteger cipherTextAsBigInteger = new BigInteger(cipherTextAsBytes);

            BigInteger plainTextAsBigInteger = Helpers.SquareAndMultiply(cipherTextAsBigInteger, d, n);

            byte[] plainTextAsBytes = plainTextAsBigInteger.ToByteArray();

            string plainText = Encoding.UTF8.GetString(plainTextAsBytes);

            return plainText;
        }

        public BigInteger Encrypt(BigInteger plainTextAsBigInteger, RSAPublicKey publicKey)
        {
            BigInteger cipherTextAsBigInteger = Helpers.SquareAndMultiply(plainTextAsBigInteger, publicKey.E, publicKey.N);

            return cipherTextAsBigInteger;
        }

        public BigInteger Decrypt(BigInteger cipherTextAsBigInteger)
        {
            BigInteger plainTextAsBigInteger = Helpers.SquareAndMultiply(cipherTextAsBigInteger, d, n);

            return plainTextAsBigInteger;
        }

        public void RunTest()
        {
            int desiredBitSize = 32;

            BigInteger p;
            BigInteger q;
            BigInteger n = GenerateN(desiredBitSize, out p, out q);
            BigInteger phi = (p - 1) * (q - 1);
            BigInteger e = GenerateE(phi);
            BigInteger d = Helpers.MultiplicativeInverse(e, phi);
            RSAPublicKey publicKey = new RSAPublicKey(n, e);

            // PUBLIC KEY RECEIVED. ENCRYPT SOMETHING.
            int message = 4;

            BigInteger cipherText = Helpers.SquareAndMultiply(message, e, n);

            Console.WriteLine("cipherText: " + cipherText);

            BigInteger plainText = Helpers.SquareAndMultiply(cipherText, d, n);

            Console.WriteLine("plainText: " + plainText);

        }

        #endregion

        #region Private Methods

        private BigInteger GenerateRandomPrime(int desiredSize)
        {
            // Create empty blocks for our prime
            BitBlock potentialPrime_asBitBlock = new BitBlock(desiredSize);

            BigInteger potentialPrime;

            do
            {
                // Convert potential prime to byte array
                byte[] potentialPrime_asByteArray = BitBlock.ConvertToByteArray(potentialPrime_asBitBlock);

                // Fill potential prime with random bits
                cryptoServiceProvider.GetBytes(potentialPrime_asByteArray);

                // Convert potential prime to Big Integers
                potentialPrime = new BigInteger(potentialPrime_asByteArray);

                // If we created negative potential prime, change to positive
                if (potentialPrime.Sign == -1)
                {
                    potentialPrime *= -1;
                }

            } while (!isPrime(potentialPrime, securityToken));

            return potentialPrime;
        }

        private BigInteger GenerateN(int desiredSize, out BigInteger p, out BigInteger q)
        {
            // Calculate half the desired length in bits
            int half = desiredSize / 2;

            BigInteger n = 0;

            int n_length = 0;

            // Run the loop until the result of pXq is of the desired length and n is a prime
            do
            {
                p = GenerateRandomPrime(half);
                q = GenerateRandomPrime(half);

                n = p * q;

                // Convert n to byte array
                byte[] n_asByteArray = n.ToByteArray();

                // Convert n to Bit Block
                BitBlock n_asBitBlock = new BitBlock(n_asByteArray);

                // Get n's length
                n_length = n_asBitBlock.Length;

            } while (n_length != desiredSize); // Repease until n is the right lenth

            return n;
        }

        private BigInteger GenerateE(BigInteger phi)
        {
            BigInteger e;

            bool isCoprime = false;

            do
            {
                e = Helpers.GetRandomBigInteger(1, phi);

                isCoprime = Helpers.Euclidian(e, phi) == 1;

            } while (!isCoprime);

            return e;
        }

        private bool isPrime(BigInteger potentialPrime, int securityToken)
        {
            switch (this.primalityTestToUse)
            {
                case PrimalityTest.Fermat:
                    return Helpers.FermatPrimalityTest(potentialPrime, securityToken);
                case PrimalityTest.RabinMiller:
                    return Helpers.MillerRabinPrimalityTest(potentialPrime, securityToken);
                default:
                    throw new Exception("No Primality Test Defined");
            }
        }

        #endregion

    }
}
