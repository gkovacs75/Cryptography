using System;
using System.Collections;
using System.Text;

namespace Ciphers
{
    public class BitBlock : IEnumerable
    {
        #region Declarations

        private bool[] bits;

        #endregion

        #region Constructors

        private BitBlock()
        {
            // Don't allow construction without parameter
        }

        /// <summary>
        /// Takes a string, converts it into a byte array and passes that byte array to
        /// the other constructor of BitBlock which takes byte arrays
        /// </summary>
        /// <param name="text"></param>
        public BitBlock(string text) : this(Encoding.UTF8.GetBytes(text))
        {
        }

        public BitBlock(int size)
        {
            bits = new bool[size];
        }

        public BitBlock(char[] charArray)
        {
            bits = new bool[charArray.Length];

            for (int i = 0; i < charArray.Length; i++)
            {
                if (charArray[i] == '0')
                {
                    bits[i] = false;
                }
                else
                {
                    bits[i] = true;
                }                
            }
        }

        /// <summary>
        /// Convert the incoming byte array into a BitBlock
        /// </summary>
        /// <param name="bytes"></param>
        public BitBlock(byte[] bytes)
        {
            // Create internal structure
            this.bits = new bool[bytes.Length * 8];

            // Loop through the bytes to convert
            for (int i = 0; i < bytes.Length; i++)
            {
                // Grab each byte
                byte b = bytes[i];

                // Convert it into a BitBlock
                BitBlock bb = ConvertDecimalToBinary(b, 8);

                // Concatenate all the bits
                for (int j = 0; j < bb.Length; j++)
                {
                    this.bits[j + (i * 8)] = bb[j];
                }
            }
        }

        #endregion

        #region Properties

        public bool this[int index]
        {
            get
            {
                return bits[index];
            }
            set
            {
                bits[index] = value;
            }
        }

        public int Length
        {
            get
            {
                return bits.Length;
            }
        }

        #endregion
        
        #region Public Methods

        /// <summary>
        /// Returns the left half of inputBlock
        /// </summary>
        /// <param name="inputBlock"></param>
        /// <returns>A BitArray array consisting of the left side of inputBlock</returns>
        public BitBlock LeftSide()
        {
            int halfInputBlockLength = this.bits.Length / 2;

            BitBlock outputBlock = new BitBlock(halfInputBlockLength);

            for (int i = 0; i <= halfInputBlockLength - 1; i++)
            {
                outputBlock[i] = this.bits[i];
            }

            return outputBlock;
        }

        /// <summary>
        /// Returns the right half of inputBlock
        /// </summary>
        /// <param name="inputBlock"></param>
        /// <returns>A BitArray array consisting of the right side of inputBlock</returns>
        public BitBlock RightSide()
        {
            int halfInputBlockLength = this.bits.Length / 2;

            BitBlock outputBlock = new BitBlock(halfInputBlockLength);

            for (int i = 0; i <= halfInputBlockLength - 1; i++)
            {
                outputBlock[i] = this.bits[i + halfInputBlockLength];
            }

            return outputBlock;
        }

        /// <summary>
        /// Reverse the bits in the internal array
        /// </summary>
        public void Reverse()
        {
            Array.Reverse(this.bits);
        }

        /// <summary>
        /// Converts a base2 binary value into a base10 integer
        /// </summary>
        /// <returns></returns>
        public static byte ConvertBinaryToDecimal(BitBlock input)
        {
            int[] bitsAsOnesAndZeros = ConvertToIntegerArrayOfBits(input);

            double intRepresentation = 0;

            int exponent = 0;

            for (int i = (bitsAsOnesAndZeros.Length - 1); i >= 0; i--)
            {
                intRepresentation += bitsAsOnesAndZeros[i] * (Math.Pow(2, exponent));
                exponent++;
            }

            return (byte)intRepresentation;
        }

        /// <summary>
        /// Converts a base10 integer into a base2 binary
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static BitBlock ConvertDecimalToBinary(int decimalNumber, int bitBlockSizeNeeded)
        {
            int remainder;

            BitBlock output = new BitBlock(bitBlockSizeNeeded);

            int i = bitBlockSizeNeeded - 1;

            while (decimalNumber > 0)
            {
                remainder = decimalNumber % 2;
                decimalNumber /= 2;

                if (remainder == 1)
                {
                    output[i] = true;
                }
                else
                {
                    output[i] = false;
                }

                i--;
            }

            return output;
        }

        /// <summary>
        /// Converts a BitBlock into an array of bytes.
        /// The number of items in the BitBlock must be divisible by 8.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static byte[] ConvertToByteArray(BitBlock input)
        {
            int size = input.Length;

            if (size % 8 != 0)
            {
                throw new Exception("Input lenght must be divisible and greater by/than 8");
            }

            byte[] byteArray = new byte[size / 8];

            int b = 0;

            BitBlock bb = new BitBlock(8);

            for (int i = 0; i < size; i++)
            {
                bb[i % 8] = input[i];

                if ((i + 1) % 8 == 0)
                {
                    byte _byte = BitBlock.ConvertBinaryToDecimal(bb);

                    byteArray[b++] = _byte;
                }
            }

            return byteArray;
        }

        /// <summary>
        /// Converts the internal array of bools into an array of integers
        /// </summary>
        /// <returns></returns>
        public static int[] ConvertToIntegerArrayOfBits(BitBlock input)
        {
            int[] intArray = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == false)
                {
                    intArray[i] = 0;
                }
                else
                {
                    intArray[i] = 1;
                }
            }

            return intArray;
        }

        /// <summary>
        /// Returns a portion of the input bit block from position index to length
        /// </summary>
        /// <param name="input"></param>
        /// <param name="index"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        public static BitBlock SubDivide(BitBlock input, int index, int length)
        {
            BitBlock output = new BitBlock(length - index + 1);

            int j = 0;

            for (int i = index; i <= length; i++)
            {
                output[j++] = input[i];
            }

            return output;
        }

        /// <summary>
        /// Left Shift
        /// </summary>
        /// <param name="input"></param>
        /// <param name="unitsToShift"></param>
        /// <returns></returns>
        public static BitBlock operator <<(BitBlock input, int unitsToShift)
        {
            int size = input.Length;

            BitBlock output = new BitBlock(size);

            for (int i = 0; i < size; i++)
            {
                output[i] = input[(i + unitsToShift) % size];
            }

            return output;
        }

        /// <summary>
        /// Right Shift
        /// </summary>
        /// <param name="input"></param>
        /// <param name="unitsToShift"></param>
        /// <returns></returns>
        public static BitBlock operator >>(BitBlock input, int unitsToShift)
        {
            int size = input.Length;

            BitBlock output = new BitBlock(size);

            for (int i = 0; i < size; i++)
            {
                output[(i + unitsToShift) % size] = input[i];
            }

            return output;
        }

        /// <summary>
        /// Concatenates two BitBlocks into one
        /// </summary>
        /// <param name="leftSide"></param>
        /// <param name="rightSide"></param>
        /// <returns></returns>
        public static BitBlock operator +(BitBlock leftSide, BitBlock rightSide)
        {
            int size = leftSide.Length + rightSide.Length;
            int half = size / 2;

            BitBlock output = new BitBlock(size);

            for (int i = 0; i < leftSide.Length; i++)
            {
                output[i] = leftSide[i];
            }

            for (int i = 0; i < rightSide.Length; i++)
            {
                output[i + leftSide.Length] = rightSide[i];
            }

            return output;
        }

        /// <summary>
        /// XOR
        /// </summary>
        /// <param name="leftSide"></param>
        /// <param name="rightSide"></param>
        /// <returns></returns>
        public static BitBlock operator ^(BitBlock leftSide, BitBlock rightSide)
        {
            if (leftSide.Length != rightSide.Length)
            {
                throw new Exception("Bit Block lenghts need to match");
            }

            int size = leftSide.Length;

            BitBlock outputBlock = new BitBlock(size);

            for (int i = 0; i < size; i++)
            {
                outputBlock[i] = leftSide[i] ^ rightSide[i];
            }

            return outputBlock;
        }       

        /// <summary>
        /// Provides a 0|1 representation of the internal bool array.
        /// Used for debugging primaraly
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < this.bits.Length; i++)
            {
                if (this.bits[i])
                {
                    sb.Append("1");
                }
                else
                {
                    sb.Append("0");
                }
            }

            return sb.ToString();
        }

        /// <summary>
        /// Prints the contents of block to the console - used for testing
        /// </summary>
        /// <param name="block"></param>
        public void Print(string name)
        {
            Console.WriteLine();
            Console.WriteLine("Block Name: " + name);
            Console.WriteLine("Block Count: " + bits.Length);
            Console.WriteLine();

            foreach (bool b in bits)
            {
                char bit = b == true ? '1' : '0';
                Console.Write(bit);
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Requirement of the IEnumerable inteface
        /// </summary>
        /// <returns></returns>
        public IEnumerator GetEnumerator()
        {
            return bits.GetEnumerator();
        }

        #endregion       

    }
}
