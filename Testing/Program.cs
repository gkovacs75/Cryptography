using Ciphers;
using System;
using System.IO;
using System.Numerics;
using System.Reflection;
using System.Text;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            //RunDESTesting();
            //RunTripleDESTesting();

            //RSA rsa = new RSA();
            //rsa.RunTest();

            //ElGamal elgamal = new ElGamal();
            //elgamal.RunTest();

            //bool result = false;
            
            //result = Helpers.MillerRabinPrimalityTest(3989, 100);
            //Console.WriteLine("3989: " + result);

            //result = Helpers.MillerRabinPrimalityTest(7331, 100);
            //Console.WriteLine("7331: " + result);

            //result = Helpers.MillerRabinPrimalityTest(7329, 100);
            //Console.WriteLine("7329: " + result);

            Console.ReadLine();
        }

        private static void RunTripleDESTesting()
        {
            Console.WriteLine("WELCOME TO CRYPTOGRAPHY");
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Enter 'D' to run the demo. Enter C to use your own key and plain text.");
            ConsoleKeyInfo cki = Console.ReadKey(true);

            if (cki.KeyChar == 'd' || cki.KeyChar == 'D')
            {
                Console.WriteLine();
                Console.WriteLine();

                string plainText = GetPlainText(@"PlainText.txt");
                string key = GetMasterKey(@"MasterKey.txt");

                Console.WriteLine(@"MASTER KEY (Read from Cryptography\Testing\MasterKey.txt): " + key);
                Console.WriteLine();

                Console.WriteLine(@"PLAIN TEXT (Read from Cryptography\Testing\PlainText.txt):");
                Console.WriteLine("------------------------------------------------------------------------");
                Console.WriteLine(plainText);
                Console.WriteLine();
                Console.WriteLine();

                TripleDES tripleDES = new TripleDES();

                string cipherText = tripleDES.Encrypt(plainText, key);

                Console.WriteLine("CIPHER TEXT:");
                Console.WriteLine("------------------------------------------------------------------------");
                Console.WriteLine(cipherText);
                Console.WriteLine();
                Console.WriteLine();

                string plainTextAgain = tripleDES.Decrypt(cipherText, key);

                Console.WriteLine("CIPHER TEXT DECRYPTED:");
                Console.WriteLine("------------------------------------------------------------------------");
                Console.WriteLine(plainTextAgain);
                Console.WriteLine();
                Console.WriteLine();
            }
            else if (cki.KeyChar == 'c' || cki.KeyChar == 'C')
            {
                Console.WriteLine();

                Console.WriteLine("Enter a Master Key to use for Encryption/Decryption");
                string key = Console.ReadLine();

                Console.WriteLine();
                Console.WriteLine("Enter Plain Text to be Encrypted");
                string plainText = Console.ReadLine();

                TripleDES des = new TripleDES();

                string cipherText = des.Encrypt(plainText, key);

                Console.WriteLine();
                Console.WriteLine("CIPHER TEXT:");
                Console.WriteLine("------------------------------------------------------------------------");
                Console.WriteLine(cipherText);
                Console.WriteLine();
                Console.WriteLine();

                string plainTextAgain = des.Decrypt(cipherText, key);

                Console.WriteLine("CIPHER TEXT DECRYPTED:");
                Console.WriteLine("------------------------------------------------------------------------");
                Console.WriteLine(plainTextAgain);
                Console.WriteLine();
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Hit Enter to exit");
            Console.ReadLine();
        }

        private static void RunDESTesting()
        {
            Console.WriteLine("WELCOME TO CRYPTOGRAPHY");
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Enter 'D' to run the demo. Enter C to use your own key and plain text.");
            ConsoleKeyInfo cki = Console.ReadKey(true);

            if (cki.KeyChar == 'd' || cki.KeyChar == 'D')
            {
                Console.WriteLine();
                Console.WriteLine();

                string plainText = GetPlainText(@"PlainText.txt");
                string key = GetMasterKey(@"MasterKey.txt");

                Console.WriteLine(@"MASTER KEY (Read from Cryptography\Testing\MasterKey.txt): " + key);
                Console.WriteLine();

                Console.WriteLine(@"PLAIN TEXT (Read from Cryptography\Testing\PlainText.txt):");
                Console.WriteLine("------------------------------------------------------------------------");
                Console.WriteLine(plainText);
                Console.WriteLine();
                Console.WriteLine();

                DES des = new DES();

                string cipherText = des.Encrypt(plainText, key);

                Console.WriteLine("CIPHER TEXT:");
                Console.WriteLine("------------------------------------------------------------------------");
                Console.WriteLine(cipherText);
                Console.WriteLine();
                Console.WriteLine();

                string plainTextAgain = des.Decrypt(cipherText, key);

                Console.WriteLine("CIPHER TEXT DECRYPTED:");
                Console.WriteLine("------------------------------------------------------------------------");
                Console.WriteLine(plainTextAgain);
                Console.WriteLine();
                Console.WriteLine();
            }
            else if (cki.KeyChar == 'c' || cki.KeyChar == 'C')
            {
                Console.WriteLine();

                Console.WriteLine("Enter a Master Key to use for Encryption/Decryption");
                string key = Console.ReadLine();

                Console.WriteLine();
                Console.WriteLine("Enter Plain Text to be Encrypted");
                string plainText = Console.ReadLine();

                DES des = new DES();

                string cipherText = des.Encrypt(plainText, key);

                Console.WriteLine();
                Console.WriteLine("CIPHER TEXT:");
                Console.WriteLine("------------------------------------------------------------------------");
                Console.WriteLine(cipherText);
                Console.WriteLine();
                Console.WriteLine();

                string plainTextAgain = des.Decrypt(cipherText, key);

                Console.WriteLine("CIPHER TEXT DECRYPTED:");
                Console.WriteLine("------------------------------------------------------------------------");
                Console.WriteLine(plainTextAgain);
                Console.WriteLine();
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Hit Enter to exit");
            Console.ReadLine();
        }

        /// <summary>
        /// Loads the contents of a file into memory
        /// </summary>
        /// <returns>Plain text as a string</returns>
        private static string GetPlainText(string fileName)
        {
            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), fileName);

            string plainText = File.ReadAllText(path);

            return plainText;
        }

        /// <summary>
        /// Loads the Master Key into memory
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        private static string GetMasterKey(string fileName)
        {
            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), fileName);

            string masterKey = File.ReadAllText(path);

            return masterKey;
        }
    }
}
