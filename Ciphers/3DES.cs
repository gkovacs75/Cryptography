using System;
using System.Text;

namespace Ciphers
{
    /// <summary>
    /// https://en.wikipedia.org/wiki/Triple_DES
    /// </summary>
    public class TripleDES
    {
        #region Declarations

        private enum ProcessType
        {
            Encrypt = 1,
            Decrypt = 2
        }

        private DesReferenceTables tables;

        #endregion

        #region Constructors

        public TripleDES()
        {
            tables = new DesReferenceTables();
        }

        #endregion

        #region Public Methods

        public string Encrypt(string plainText, string masterKey)
        {
            string key1 = String.Empty;
            string key2 = String.Empty;
            string key3 = String.Empty;

            Create3keysFromMasterKey(masterKey, out key1, out key2, out key3);
            
            string masterKeyPadded1 = PadMasterKey(key1);
            string masterKeyPadded2 = PadMasterKey(key2);
            string masterKeyPadded3 = PadMasterKey(key3);

            BitBlock masterKey1 = new BitBlock(masterKeyPadded1);
            BitBlock masterKey2 = new BitBlock(masterKeyPadded2);
            BitBlock masterKey3 = new BitBlock(masterKeyPadded3);

            BitBlock[] subKeysForEncryption1 = GenerateSubKeys(ProcessType.Encrypt, masterKey1);
            BitBlock[] subKeysForDecryption2 = GenerateSubKeys(ProcessType.Decrypt, masterKey2);
            BitBlock[] subKeysForEncryption3 = GenerateSubKeys(ProcessType.Encrypt, masterKey3);

            string plainTextPadded = PadPlainText(plainText);

            char[] plainTextCharArray = plainTextPadded.ToCharArray();

            byte[] allEncryptedBytes = new byte[plainTextCharArray.Length];

            int inputIndex = 0;

            int numberOfInputBlocksof64BitsToEncrypt = plainTextCharArray.Length / 8;

            for (int i = 0; i < numberOfInputBlocksof64BitsToEncrypt; i++)
            {
                byte[] next8BytesToEncrypt = Encoding.UTF8.GetBytes(plainTextCharArray, inputIndex, 8);


                byte[] encryptedBytes_Pass1 = Process(subKeysForEncryption1, next8BytesToEncrypt);
                byte[] decryptedBytes_Pass2 = Process(subKeysForDecryption2, encryptedBytes_Pass1);
                byte[] encryptedBytes_Pass3 = Process(subKeysForEncryption3, decryptedBytes_Pass2);

                Array.Copy(encryptedBytes_Pass3, 0, allEncryptedBytes, inputIndex, 8);

                inputIndex += 8;
            }

            string cipherText = Convert.ToBase64String(allEncryptedBytes);

            return cipherText;
        }

        public string Decrypt(string cipherText, string masterKey)
        {
            string key1 = String.Empty;
            string key2 = String.Empty;
            string key3 = String.Empty;
            
            Create3keysFromMasterKey(masterKey, out key1, out key2, out key3);
            
            string masterKeyPadded1 = PadMasterKey(key1);
            string masterKeyPadded2 = PadMasterKey(key2);
            string masterKeyPadded3 = PadMasterKey(key3);

            BitBlock masterKey1 = new BitBlock(masterKeyPadded1);
            BitBlock masterKey2 = new BitBlock(masterKeyPadded2);
            BitBlock masterKey3 = new BitBlock(masterKeyPadded3);

            BitBlock[] subKeysForDecryption1 = GenerateSubKeys(ProcessType.Decrypt, masterKey1);
            BitBlock[] subKeysForEncryption2 = GenerateSubKeys(ProcessType.Encrypt, masterKey2);
            BitBlock[] subKeysForDecryption3 = GenerateSubKeys(ProcessType.Decrypt, masterKey3);

            byte[] encryptedBytes = Convert.FromBase64String(cipherText);

            StringBuilder plainText = new StringBuilder();

            int inputIndex = 0;

            int numberOfInputBlocksof64BitsToDecrypt = encryptedBytes.Length / 8;

            for (int i = 0; i < numberOfInputBlocksof64BitsToDecrypt; i++)
            {
                byte[] next8BytesToDecrypt = SubArray(encryptedBytes, inputIndex, 8);


                byte[] decryptedBytes_Pass1 = Process(subKeysForDecryption1, next8BytesToDecrypt);
                byte[] encryptedBytes_Pass2 = Process(subKeysForEncryption2, decryptedBytes_Pass1);
                byte[] decryptedBytes_Pass3 = Process(subKeysForDecryption3, encryptedBytes_Pass2);


                string decryptedString = Encoding.UTF8.GetString(decryptedBytes_Pass3);

                plainText.Append(decryptedString);

                inputIndex += 8;
            }

            return plainText.ToString().TrimEnd();
        }

        //public string Encrypt(string plainText, string key)
        //{
        //    string plainTextPadded = PadPlainText(plainText);

        //    string masterKeyPadded = PadMasterKey(key);

        //    BitBlock masterKey = new BitBlock(masterKeyPadded);

        //    BitBlock[] subKeysForEncryption = GenerateSubKeys(ProcessType.Encrypt, masterKey);
        //    BitBlock[] subKeysForDecryption = GenerateSubKeys(ProcessType.Decrypt, masterKey);

        //    char[] plainTextCharArray = plainTextPadded.ToCharArray();

        //    byte[] allEncryptedBytes = new byte[plainTextCharArray.Length];

        //    int inputIndex = 0;

        //    int numberOfInputBlocksof64BitsToEncrypt = plainTextCharArray.Length / 8;

        //    for (int i = 0; i < numberOfInputBlocksof64BitsToEncrypt; i++)
        //    {
        //        byte[] next8BytesToEncrypt = Encoding.UTF8.GetBytes(plainTextCharArray, inputIndex, 8);


        //        byte[] encryptedBytes_Pass1 = Process(subKeysForEncryption, next8BytesToEncrypt);
        //        byte[] decryptedBytes_Pass2 = Process(subKeysForDecryption, encryptedBytes_Pass1);
        //        byte[] encryptedBytes_Pass3 = Process(subKeysForEncryption, decryptedBytes_Pass2);

        //        Array.Copy(encryptedBytes_Pass3, 0, allEncryptedBytes, inputIndex, 8);

        //        inputIndex += 8;
        //    }

        //    string cipherText = Convert.ToBase64String(allEncryptedBytes);

        //    return cipherText;
        //}

        //public string Decrypt(string cipherText, string key)
        //{
        //    key = PadMasterKey(key);

        //    BitBlock masterKey = new BitBlock(key);

        //    BitBlock[] subKeysForEncryption = GenerateSubKeys(ProcessType.Encrypt, masterKey);
        //    BitBlock[] subKeysForDecryption = GenerateSubKeys(ProcessType.Decrypt, masterKey);

        //    byte[] encryptedBytes = Convert.FromBase64String(cipherText);

        //    StringBuilder plainText = new StringBuilder();

        //    int inputIndex = 0;

        //    int numberOfInputBlocksof64BitsToDecrypt = encryptedBytes.Length / 8;

        //    for (int i = 0; i < numberOfInputBlocksof64BitsToDecrypt; i++)
        //    {
        //        byte[] next8BytesToDecrypt = SubArray(encryptedBytes, inputIndex, 8);


        //        byte[] decryptedBytes_Pass1 = Process(subKeysForDecryption, next8BytesToDecrypt);
        //        byte[] encryptedBytes_Pass2 = Process(subKeysForEncryption, decryptedBytes_Pass1);
        //        byte[] decryptedBytes_Pass3 = Process(subKeysForDecryption, encryptedBytes_Pass2);


        //        string decryptedString = Encoding.UTF8.GetString(decryptedBytes_Pass3);

        //        plainText.Append(decryptedString);

        //        inputIndex += 8;
        //    }

        //    return plainText.ToString().TrimEnd();
        //}

        private byte[] Process(BitBlock[] subKeys, byte[] next8ByteBlock)
        {
            BitBlock next64BitBlock = new BitBlock(next8ByteBlock);

            BitBlock initialPermutation_Output = InitialPermutation(next64BitBlock);

            BitBlock leftSide = initialPermutation_Output.LeftSide();

            BitBlock rightSide = initialPermutation_Output.RightSide();

            // 16 Rounds of Encryption/Decryption
            for (int i = 0; i <= 15; i++)
            {
                BitBlock F_Output = F(rightSide, subKeys[i]);

                BitBlock tempRightSide = leftSide ^ F_Output;

                leftSide = rightSide;
                rightSide = tempRightSide;
            }

            BitBlock finalPermutation_Output = FinalPermutation(rightSide + leftSide);

            byte[] byteArray = BitBlock.ConvertToByteArray(finalPermutation_Output);

            return byteArray;
        }

        #endregion

        #region Private Methods

        private BitBlock InitialPermutation(BitBlock next64BitBlock)
        {
            return BlockTransmutation(tables.InitialPermutationTable, next64BitBlock, 64);
        }

        private BitBlock F(BitBlock r, BitBlock subKey)
        {
            BitBlock expansion_Output = Expansion(r);

            BitBlock xor_Output = expansion_Output ^ subKey;

            BitBlock s1 = SubDivide(xor_Output, 0, 5);
            BitBlock s2 = SubDivide(xor_Output, 6, 11);
            BitBlock s3 = SubDivide(xor_Output, 12, 17);
            BitBlock s4 = SubDivide(xor_Output, 18, 23);
            BitBlock s5 = SubDivide(xor_Output, 24, 29);
            BitBlock s6 = SubDivide(xor_Output, 30, 35);
            BitBlock s7 = SubDivide(xor_Output, 36, 41);
            BitBlock s8 = SubDivide(xor_Output, 42, 47);

            BitBlock s1_Output = S(s1, 1);
            BitBlock s2_Output = S(s2, 2);
            BitBlock s3_Output = S(s3, 3);
            BitBlock s4_Output = S(s4, 4);
            BitBlock s5_Output = S(s5, 5);
            BitBlock s6_Output = S(s6, 6);
            BitBlock s7_Output = S(s7, 7);
            BitBlock s8_Output = S(s8, 8);

            BitBlock sBlocksConcatenated = s1_Output + s2_Output + s3_Output + s4_Output + s5_Output + s6_Output + s7_Output + s8_Output;

            BitBlock permutation_Output = Permutation(sBlocksConcatenated);

            return permutation_Output;
        }

        private BitBlock Expansion(BitBlock r0)
        {
            return BlockTransmutation(tables.ExpansionTable, r0, 48);
        }

        private BitBlock S(BitBlock input, int sreferenceTableNumber)
        {
            BitBlock outerBits = new BitBlock(2);
            BitBlock middleBits = new BitBlock(4);

            outerBits[0] = input[0];
            outerBits[1] = input[5];

            middleBits[0] = input[1];
            middleBits[1] = input[2];
            middleBits[2] = input[3];
            middleBits[3] = input[4];


            int middleNumber = BitBlock.ConvertBinaryToDecimal(middleBits);
            int outerNumber = BitBlock.ConvertBinaryToDecimal(outerBits);

            int tableValue = 0;

            switch (sreferenceTableNumber)
            {
                case 1:
                    tableValue = tables.SBox1Table[outerNumber, middleNumber];
                    break;
                case 2:
                    tableValue = tables.SBox2Table[outerNumber, middleNumber];
                    break;
                case 3:
                    tableValue = tables.SBox3Table[outerNumber, middleNumber];
                    break;
                case 4:
                    tableValue = tables.SBox4Table[outerNumber, middleNumber];
                    break;
                case 5:
                    tableValue = tables.SBox5Table[outerNumber, middleNumber];
                    break;
                case 6:
                    tableValue = tables.SBox6Table[outerNumber, middleNumber];
                    break;
                case 7:
                    tableValue = tables.SBox7Table[outerNumber, middleNumber];
                    break;
                case 8:
                    tableValue = tables.SBox8Table[outerNumber, middleNumber];
                    break;
            }

            BitBlock bitBlock = BitBlock.ConvertDecimalToBinary(tableValue, 4);

            return bitBlock;
        }

        private BitBlock Permutation(BitBlock input)
        {
            return BlockTransmutation(tables.PermutationTable, input, 32);
        }

        private BitBlock[] GenerateSubKeys(ProcessType process, BitBlock masterKey)
        {
            BitBlock PC1_Output = PC1(masterKey);

            BitBlock cBlock = PC1_Output.LeftSide();
            BitBlock dBlock = PC1_Output.RightSide();

            BitBlock[] subKeys = new BitBlock[16];

            switch (process)
            {
                case ProcessType.Encrypt:

                    #region Encrypt

                    for (int round = 1; round <= 16; round++)
                    {
                        if (round == 1 || round == 2 || round == 9 || round == 16)
                        {
                            cBlock = cBlock << 1;
                            dBlock = dBlock << 1;
                        }
                        else
                        {
                            cBlock = cBlock << 2;
                            dBlock = dBlock << 2;
                        }

                        BitBlock key = PC2(cBlock + dBlock);

                        subKeys[round - 1] = key;
                    }
                    break;

                #endregion

                case ProcessType.Decrypt:

                    #region Decrypt

                    for (int round = 1; round <= 16; round++)
                    {
                        if (round == 1)
                        {
                            // No Rotation
                        }
                        else if (round == 2 || round == 9 || round == 16)
                        {
                            cBlock = cBlock >> 1;
                            dBlock = dBlock >> 1;
                        }
                        else
                        {
                            cBlock = cBlock >> 2;
                            dBlock = dBlock >> 2;
                        }

                        BitBlock key = PC2(cBlock + dBlock);

                        subKeys[round - 1] = key;
                    }

                    break;

                    #endregion
            }

            return subKeys;
        }

        private BitBlock PC1(BitBlock masterKey)
        {
            return BlockTransmutation(tables.PC1Table, masterKey, 56);
        }

        private BitBlock PC2(BitBlock CnDn)
        {
            return BlockTransmutation(tables.PC2Table, CnDn, 48);
        }

        private BitBlock FinalPermutation(BitBlock input)
        {
            return BlockTransmutation(tables.FinalPermutationTable, input, 64);
        }

        #region Helpers

        /// <summary>
        /// Pads the plaintext with spaces (' ') so that it can be divided into 8 byte chunks
        /// These spaces are trimmer when decrypting
        /// </summary>
        /// <param name="plainText">Plaintext</param>
        /// <returns>The padded plaintext</returns>
        private string PadPlainText(string plainText)
        {
            int remainder = plainText.Length % 8;

            int plainTextPadSizeRequired = 8 - remainder;

            if (remainder > 0)
            {
                string rightPadding = String.Empty;

                plainText += rightPadding.PadRight(plainTextPadSizeRequired, ' ');
            }

            return plainText;
        }

        private string PadMasterKey(string masterKey)
        {
            int remainder = masterKey.Length % 8;

            int masterKeyPadSizeRequired = 8 - remainder;

            if (remainder > 0)
            {
                string rightPadding = String.Empty;

                masterKey += rightPadding.PadRight(masterKeyPadSizeRequired, '-');
            }

            return masterKey;
        }

        /// <summary>
        /// Uses reference tables to copy values from the input block to the output block
        /// </summary>
        /// <param name="referenceTable">Rerefence Table</param>
        /// <param name="inputBlock">Input Block</param>
        /// <param name="outputBlockSize">Output Block Size</param>
        /// <returns></returns>        
        private static BitBlock BlockTransmutation(int[,] referenceTable, BitBlock inputBlock, int outputBlockSize)
        {
            int i = 0;

            BitBlock outputBlock = new BitBlock(outputBlockSize);

            for (int row = 0; row < referenceTable.GetLength(0); row++)
            {
                for (int col = 0; col < referenceTable.GetLength(1); col++)
                {
                    int val = referenceTable[row, col];

                    outputBlock[i++] = inputBlock[--val];
                }
            }

            return outputBlock;
        }

        private BitBlock SubDivide(BitBlock input, int start, int finish)
        {
            BitBlock output = new BitBlock(finish - start + 1);

            int j = 0;

            for (int i = start; i <= finish; i++)
            {
                output[j++] = input[i];
            }

            return output;
        }

        private byte[] SubArray(byte[] input, int index, int length)
        {
            byte[] result = new byte[length];

            Array.Copy(input, index, result, 0, length);

            return result;
        }

        /// <summary>
        /// Keying option 2 from https://en.wikipedia.org/wiki/Triple_DES
        /// </summary>
        /// <param name="masterKey"></param>
        /// <param name="key1"></param>
        /// <param name="key2"></param>
        /// <param name="key3"></param>
        private void Create3keysFromMasterKey(string masterKey, out string key1, out string key2, out string key3)
        {
            int halfLengthOfMasterKey = masterKey.Length / 2;

            key1 = masterKey.Substring(0, halfLengthOfMasterKey);
            key2 = masterKey.Substring(halfLengthOfMasterKey, masterKey.Length - halfLengthOfMasterKey);
            key3 = key1;
        }

        #endregion

        #endregion
    }
}
