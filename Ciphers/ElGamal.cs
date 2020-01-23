using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;

namespace Ciphers
{
    public class ElGamal
    {
        #region Declarations/Properties

        private RNGCryptoServiceProvider cryptoServiceProvider = new RNGCryptoServiceProvider(); // Used to provide random numbers
        private PrimalityTest primalityTestToUse { get; set; }
        private int securityToken;

        private BigInteger p;
        private BigInteger alpha;
        private BigInteger a;
        private BigInteger alphaToA;
        //private BigInteger k;
        //private BigInteger gamma;
        //private BigInteger delta;

        public ElGamalPublicKey PublicKey { get; private set; }
        public ElGamalPrivateKey PrivateKey { get; private set; }

        #endregion

        #region Constructors

        private ElGamal()
        {

        }

        public ElGamal(PrimalityTest primalityTest, int securityToken)
        {
            this.primalityTestToUse = primalityTest;
            this.securityToken = securityToken;
        }
        #endregion

        #region Public Methods

        public void KeyGeneration(int keySize)
        {
            this.p = this.GenerateP(keySize);
            this.alpha = Helpers.GetRandomBigInteger(1, p - 1);
            this.a = Helpers.GetRandomBigInteger(1, p - 2);
            this.alphaToA = Helpers.SquareAndMultiply(alpha, a, p);

            this.PublicKey = new ElGamalPublicKey(p, alpha, alphaToA);
            this.PrivateKey = new ElGamalPrivateKey(a);
        }

        public List<Tuple<BigInteger, BigInteger>> EncryptWithChunking(string plainText, ElGamalPublicKey publicKey)
        {
            List<string> plainTextChunks = new List<string>();

            chunkIfRequired(plainText, publicKey.P, plainTextChunks);

            List<Tuple<BigInteger, BigInteger>> encryptedChunks = new List<Tuple<BigInteger, BigInteger>>();

            BigInteger k = Helpers.GetRandomBigInteger(1, publicKey.P - 2);
            BigInteger gamma = Helpers.SquareAndMultiply(publicKey.Alpha, k, publicKey.P);

            foreach (string chunk in plainTextChunks)
            {
                byte[] chunkAsBytes = Encoding.UTF8.GetBytes(chunk);
                BigInteger chunkAsNumber = new BigInteger(chunkAsBytes);

                BigInteger delta = (chunkAsNumber * Helpers.SquareAndMultiply(publicKey.AlphaToA, k, publicKey.P)) % publicKey.P;
                Tuple<BigInteger, BigInteger> encryptedChunk = new Tuple<BigInteger, BigInteger>(gamma, delta);

                encryptedChunks.Add(encryptedChunk);
            }

            return encryptedChunks;
        }

        public string DecryptWithChunking(List<Tuple<BigInteger, BigInteger>> encryptedChunks)
        {
            StringBuilder completePlainText = new StringBuilder();

            foreach (Tuple<BigInteger, BigInteger> chunk in encryptedChunks)
            {
                BigInteger gamma = chunk.Item1;
                BigInteger delta = chunk.Item2;

                BigInteger gammaToTheNegativeA = Helpers.SquareAndMultiply(gamma, (p - 1 - a), p);

                BigInteger chunkDecryptedAsBigNumber = gammaToTheNegativeA * delta % p;

                byte[] chunkDecryptedAsBytes = chunkDecryptedAsBigNumber.ToByteArray();

                string chunkAsPlainText = Encoding.UTF8.GetString(chunkDecryptedAsBytes);

                completePlainText.Append(chunkAsPlainText);
            }

            //BigInteger x = BigInteger.Parse(completePlainText.ToString());

            //byte[] plainTextAsBytes = x.ToByteArray();

            //string plainText = Encoding.UTF8.GetString(plainTextAsBytes);

            return completePlainText.ToString();
        }

        public Tuple<BigInteger, BigInteger> Encrypt(string plainText, ElGamalPublicKey publicKey)
        {
            byte[] plainTextAsBytes = Encoding.UTF8.GetBytes(plainText);

            BigInteger plainTextAsNumber = new BigInteger(plainTextAsBytes);

            if (plainTextAsNumber > publicKey.P)
            {
                throw new Exception("The Master Key cannot exceed n");

            }

            BigInteger k = Helpers.GetRandomBigInteger(1, publicKey.P - 2);
            BigInteger gamma = Helpers.SquareAndMultiply(publicKey.Alpha, k, publicKey.P);
            BigInteger delta = (plainTextAsNumber * Helpers.SquareAndMultiply(publicKey.AlphaToA, k, publicKey.P)) % publicKey.P;
            Tuple<BigInteger, BigInteger> cipherText = new Tuple<BigInteger, BigInteger>(gamma, delta);

            return cipherText;
        }

        public string Decrypt(BigInteger gamma, BigInteger delta)
        {
            BigInteger gammaToTheNegativeA = Helpers.SquareAndMultiply(gamma, (p - 1 - a), p);

            BigInteger plainTextAsBigInteger = gammaToTheNegativeA * delta % p;

            byte[] plainTextAsBytes = plainTextAsBigInteger.ToByteArray();

            string plainText = Encoding.UTF8.GetString(plainTextAsBytes);

            return plainText;
        }

        public void RunTest()
        {
            // Done by sender
            //BigInteger p = 2357;
            BigInteger p = this.GenerateP(32);
            //BigInteger alpha = 2;
            BigInteger alpha = Helpers.GetRandomBigInteger(1, p - 1);
            //BigInteger a = 1751;
            BigInteger a = Helpers.GetRandomBigInteger(1, p - 2);
            BigInteger alphaToA = Helpers.SquareAndMultiply(alpha, a, p);
            ElGamalPublicKey publicKey = new ElGamalPublicKey(p, alpha, alphaToA);
            ElGamalPrivateKey privateKey = new ElGamalPrivateKey(a);

            // Done by receiver            
            int message = 2035;
            //BigInteger k = 1520; // Random number 1 <= k <= p-2
            BigInteger k = Helpers.GetRandomBigInteger(1, p - 2); // Random number 1 <= k <= p-2
            BigInteger gamma = Helpers.SquareAndMultiply(alpha, k, p);
            BigInteger delta = (message * Helpers.SquareAndMultiply(publicKey.AlphaToA, k, p)) % p;
            Tuple<BigInteger, BigInteger> cipherText = new Tuple<BigInteger, BigInteger>(gamma, delta);

            // Done by receiver
            BigInteger gammaToTheNegativeA = Helpers.SquareAndMultiply(gamma, (p - 1 - a), p);

            BigInteger plainText = gammaToTheNegativeA * delta % p;

            Console.WriteLine("plainText: " + message);
            Console.WriteLine("cipherText: (" + gamma + "," + delta + ")");
            Console.WriteLine("plainText: " + plainText);
        }

        #endregion

        #region Private Methods

        private BigInteger GenerateP(int desiredSize)
        {
            // Create 2 empty blocks for p and q
            BitBlock p_asBitBlock = new BitBlock(desiredSize);

            BigInteger p = 0;

            bool isPPrime = false;

            do
            {
                // Convert p to byte array
                byte[] p_asByteArray = BitBlock.ConvertToByteArray(p_asBitBlock);

                // Fill p with random bits
                cryptoServiceProvider.GetBytes(p_asByteArray);

                // Convert p to Big Integer
                p = new BigInteger(p_asByteArray);

                // If we created negative p/q, change to positive
                if (p.Sign == -1)
                {
                    p *= -1;
                }

                // Primality Test  
                switch (this.primalityTestToUse)
                {
                    case PrimalityTest.Fermat:
                        isPPrime = Helpers.FermatPrimalityTest(p, this.securityToken);
                        break;
                    case PrimalityTest.RabinMiller:
                        isPPrime = Helpers.MillerRabinPrimalityTest(p, this.securityToken);
                        break;
                }

            } while (!isPPrime);

            return p;
        }

        private void chunkIfRequired(string plainText, BigInteger numberToTestAgainst, List<string> chunks)
        {
            byte[] plainTextAsBytes = Encoding.UTF8.GetBytes(plainText);

            BigInteger numberToTestAsBigNumber = new BigInteger(plainTextAsBytes);

            if (numberToTestAsBigNumber > numberToTestAgainst)
            {
                int plainTextLength = plainText.Length;
                int floorOfHalfPlainTextLength = plainTextLength / 2;

                string leftSide = plainText.Substring(0, floorOfHalfPlainTextLength);
                string rightSide = plainText.Substring(floorOfHalfPlainTextLength, plainTextLength - floorOfHalfPlainTextLength);

                chunkIfRequired(leftSide, numberToTestAgainst, chunks);
                chunkIfRequired(rightSide, numberToTestAgainst, chunks);
            }
            else
            {
                chunks.Add(plainText);
            }
        }

        #endregion
    }
}
