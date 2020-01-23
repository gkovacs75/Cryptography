Project
Gabor Kovacs
11/5/2018
-----------------------------------------------------------------------------------------------


How to Execute
-----------------------------------------------------------------------------------------------
Run the file:  
Cryptography\Project\bin\Debug\Project.exe

Note, just as Java requires the Java Framework, c# apps requires the .Net framework.
Dot Net framework 4.0 is required on the client machine to run this app. 
If for some unlikely reason you don't have .Net Framework already installed (most machines will), then you have two options:
1. Install it from https://www.microsoft.com/en-us/download/details.aspx?id=49981
2. Run Windows updates, this should take care of it
3. Run this on any machine with Windows 7 - 10

Understanding the App
-----------------------------------------------------------------------------------------------
1. You will be shown a large form with options to set the key size, Asymmetric Algorithm, Symmetric Algorithm, Primality test, and security parameter t (defaulted to 1000).
2. Click the button: Project - Start Test
3. Two forms will popup, they should fill the screen evenly, but if not, you can adjust the size so that they are side by side.
4. Click "Request Key" on either form. If the numbers are too long, you can stretch the forms.
5. Now that you have the public key from the other user, you can create, encrypt, and send a master key.
6. Decrypt the master key on the other user and now you can exchange messages using the Symmetric algorithm, 3DES.


Architecture - Understanding the Solution Files/Relevant Files
-----------------------------------------------------------------------------------------------

This folder structure contains the files for the earlier assignments and also for this project.
Below are the files relevant for the project, you can ignore all other files/folders.

1. Cryptography\Ciphers\BitBlock.cs - Stores an internal array of bools. Used for various bitblock manipulations: Shifting, splitting, etc.
2. Cryptography\Ciphers\ElGamal.cs - Main class for ElGamal related functionality. Encrypt/Decrypt, Encrypt/Decrypt with Chunking, etc.
3. Cryptography\Ciphers\ElGamalPrivateKey.cs - Simple class that holds the private key.
4. Cryptography\Ciphers\ElGamalPublicKey.cs - Simple class that holds the public key.
5. Cryptography\Ciphers\Helpers.cs - Methods for SquareAndMultiply, Euclidian, etc.
6. Cryptography\Project\Main.cs - Plumbing and form code, not too relevant to the purpose of the project.
6. Cryptography\Project\User.cs - The user form code. Mostly plumbing, but this uses the ElGamal class.
7. Cryptography\Ciphers\RSA.cs
8. Cryptography\Ciphers\RSAPrivateKey.cs - Simple class that holds the private key.
9. Cryptography\Ciphers\RSAPublicKey.cs - Simple class that holds the public key.
10. Cryptography\Ciphers\3DES.cs - Contains the code for triple DES.
11. Cryptography\Ciphers\DESTables.cs - Hardcoded 2D arrays containing all of the DES references tables. Permuatation, ExpansionTable, etc.