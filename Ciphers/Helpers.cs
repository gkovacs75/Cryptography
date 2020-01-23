using System;
using System.Numerics;
using System.Security.Cryptography;

namespace Ciphers
{
    public static class Helpers
    {
        public static BigInteger SquareAndMultiply(BigInteger a, BigInteger exponent, BigInteger modulus)
        {
            BigInteger b = 1;

            if (exponent == 0)
            {
                return b; // a^0 would be 1
            }

            BigInteger A = a;

            byte[] exponentAsBytes = exponent.ToByteArray();

            Array.Reverse(exponentAsBytes); // Reverse little endian

            BitBlock temp = new BitBlock(exponentAsBytes);
            BitBlock kbits = new BitBlock(temp.ToString().TrimStart('0').ToCharArray()); // Trim leading 0s

            kbits.Reverse(); // Reverse the bits so that k[0] will return the right most element

            if (kbits[0] == true) // Odd?
            {
                b = a;
            }

            for (int i = 1; i < kbits.Length; i++)
            {
                A = BigInteger.Pow(A, 2) % modulus;

                if (kbits[i] == true)
                {
                    b = (A * b) % modulus;
                }
            }

            return b;
        }

        /// <summary>
        /// Returns the GCD of x and y
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static BigInteger Euclidian(BigInteger x, BigInteger y)
        {
            while (y != 0)
            {
                BigInteger r = x % y;
                x = y;
                y = r;
            }

            return x;
        }

        /// <summary>
        /// Extended Euclidian
        /// </summary>
        /// <param name="value1"></param>
        /// <param name="value2"></param>
        /// <returns>Bezout Coefficient for values 1 and 2</returns>
        public static Tuple<BigInteger, BigInteger> ExtendedEuclidian(BigInteger value1, BigInteger value2)
        {
            BigInteger x = 1, y = 0;
            BigInteger xLast = 0, yLast = 1;
            BigInteger q, r, m, n;

            while (value1 != 0)
            {
                q = value2 / value1;
                r = value2 % value1;
                m = xLast - q * x;
                n = yLast - q * y;
                xLast = x;
                yLast = y;
                x = m;
                y = n;
                value2 = value1;
                value1 = r;
            }

            Tuple<BigInteger, BigInteger> becoutCoefficients = new Tuple<BigInteger, BigInteger>(xLast, yLast);

            return becoutCoefficients;
        }

        public static BigInteger MultiplicativeInverse(BigInteger value, BigInteger modulus)
        {
            Tuple<BigInteger, BigInteger> bezoutCoefficients = ExtendedEuclidian(value, modulus);

            BigInteger becoutCoefficientForValue;
            BigInteger becoutCoefficientForModulus;

            if ((bezoutCoefficients.Item1 * value) + (bezoutCoefficients.Item2 * modulus) == 1)
            {
                becoutCoefficientForValue = bezoutCoefficients.Item1;
                becoutCoefficientForModulus = bezoutCoefficients.Item2;
            }
            else if ((bezoutCoefficients.Item1 * modulus) + (bezoutCoefficients.Item2 * value) == 1)
            {
                becoutCoefficientForValue = bezoutCoefficients.Item2;
                becoutCoefficientForModulus = bezoutCoefficients.Item1;
            }
            else
            {
                throw new Exception("Multiplicative Inverse Internal Error");
            }

            while (becoutCoefficientForValue < 0)
            {
                becoutCoefficientForValue += modulus;
            }

            return becoutCoefficientForValue;
        }

        /// <summary>
        /// Generates a random BigInteger x s.t. x is between min and max, inclusize
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public static BigInteger GetRandomBigInteger(int min, BigInteger max)
        {
            RNGCryptoServiceProvider cryptoServiceProvider = new RNGCryptoServiceProvider(); // Used to provide random numbers

            // Get the length of max in bytes
            int numberOfBytesMax = max.ToByteArray().Length;

            // Get a random number between 1 and numberOfBytesMax
            Random random = new Random();
            int randomNumberBetween1andMax = random.Next(1, numberOfBytesMax + 1);

            // Create an array of random length, between 1 byte and the number of bytes in max
            byte[] randomLengthArray = new byte[randomNumberBetween1andMax];

            // Create a BigInteger from the random length array
            BigInteger bigInt = new BigInteger(randomLengthArray);

            // While bigInt is outside the excepted range
            do
            {
                // Fill the randomLengthArray with random data
                cryptoServiceProvider.GetBytes(randomLengthArray);

                bigInt = new BigInteger(randomLengthArray);

                // If we created negative bigInt, change to positive
                if (bigInt.Sign == -1)
                {
                    bigInt *= -1;
                }

            } while (bigInt < min || bigInt >= max);

            return bigInt;
        }

        public static bool FermatPrimalityTest(BigInteger p, int t)
        {
            if (t < 1)
            {
                throw new Exception("Security token t must be greater than or equal to 1");
            }

            if (p <= 1)
            {
                return false;
            }
            else if (p == 2 || p == 3)
            {
                return true;
            }
            else if (p == 4) // if "a" must be between 2 and p-2, the p must be 5 or greater
            {
                return false;
            }

            for (int i = 1; i < t; i++)
            {
                BigInteger a = GetRandomBigInteger(2, p - 2);

                BigInteger r = SquareAndMultiply(a, (p - 1), p);

                if (r != 1)
                {
                    return false;
                }
            }

            return true;
        }

        public static bool MillerRabinPrimalityTest(BigInteger p, int t)
        {
            BigInteger s = 0;
            BigInteger r = p - 1;

            if (t < 1)
            {
                throw new Exception("Security token t must be greater than or equal to 1");
            }

            if (p <= 1)
            {
                return false;
            }
            else if (p == 2 || p == 3)
            {
                return true;
            }
            else if (p == 4) // if "a" must be between 2 and p-2, the p must be 5 or greater
            {
                return false;
            }

            do
            {
                s++;
                r /= 2;

            } while (r % 2 == 0);

            for (int i = 1; i < t; i++)
            {
                BigInteger a = GetRandomBigInteger(2, p - 2);

                BigInteger y = SquareAndMultiply(a, r, p);

                if (y != 1 && y != p - 1)
                {
                    int j = 1;

                    while (j <= (s - 1) && y != (p - 1))
                    {
                        y = SquareAndMultiply(y, 2, p);

                        if (y == 1)
                        {
                            return false;
                        }

                        j++;
                    }

                    if (y != p - 1)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }

            return true;
        }

        /// <summary>
        /// Pads a string to make sure it is 8 characters long
        /// </summary>
        /// <param name="input"></param>
        /// <param name="padder"></param>
        /// <returns></returns>
        public static string PadMod8(string input, char padder)
        {
            int remainder = input.Length % 8;

            int plainTextPadSizeRequired = 8 - remainder;

            if (remainder > 0)
            {
                string rightPadding = String.Empty;

                input += rightPadding.PadRight(plainTextPadSizeRequired, padder);
            }

            return input;
        }

        /// <summary>
        /// Returns a portion of an array from position index to length
        /// </summary>
        /// <param name="input"></param>
        /// <param name="index"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        public static byte[] SubArray(byte[] input, int index, int length)
        {
            byte[] result = new byte[length];

            Array.Copy(input, index, result, 0, length);

            return result;
        }
    }
}
