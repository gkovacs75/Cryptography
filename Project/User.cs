using Ciphers;
using System;
using System.Diagnostics;
using System.Numerics;
using System.Text;
using System.Windows.Forms;

namespace Project
{
    public partial class User : Form
    {
        #region Declarations

        public bool IsClosing { get; set; }
        public User ReferenceToOtherUser { get; set; }
        private RSAPublicKey OtherUsersRSAPublicKey { get; set; }
        private ElGamalPublicKey OtherUsersElGamalPublicKey { get; set; }
        public int KeySize { get; set; }
        public PrimalityTest PrimalityTestToUse { get; set; }
        public int SecurityToken { get; set; }
        public AsymmetricScheme AsymmetricSchemeToUse { get; set; }
        private RSA rsa;
        private ElGamal elGamal;

        #endregion

        #region Constructors
        public User()
        {
            InitializeComponent();
        }

        #endregion

        #region Asymmetric Encryption Related

        private void requestPublicKeyButton_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                Stopwatch sw = new Stopwatch();
                sw.Start();

                switch (this.AsymmetricSchemeToUse)
                {
                    case AsymmetricScheme.RSA:

                        // Get a public key from the other user
                        this.OtherUsersRSAPublicKey = ReferenceToOtherUser.RequestRSAPublicKey();

                        this.nLabel.Text = this.OtherUsersRSAPublicKey.N.ToString();
                        this.eLabel.Text = this.OtherUsersRSAPublicKey.E.ToString();

                        break;

                    case AsymmetricScheme.ElGamal:

                        // Get a public key from the other user
                        this.OtherUsersElGamalPublicKey = ReferenceToOtherUser.RequestElGamalPublicKey();

                        this.p2Label.Text = this.OtherUsersElGamalPublicKey.P.ToString();
                        this.alphaLabel.Text = this.OtherUsersElGamalPublicKey.Alpha.ToString();
                        this.alphaToALabel.Text = this.OtherUsersElGamalPublicKey.AlphaToA.ToString();

                        break;
                }

                this.requestPublicKeyButton.Enabled = false;
                this.ReferenceToOtherUser.requestPublicKeyButton.Enabled = false;
                this.masterKeyTextBox.Enabled = true;
                this.encryptMasterKeyButton.Enabled = true;
                this.ReferenceToOtherUser.masterKeyTextBox.Visible = false;

                this.ReferenceToOtherUser.masterKeyLabel.Visible = true;
                this.ReferenceToOtherUser.masterKeyTextBox.Visible = false;

                this.masterKeyTextBox.Focus();
                this.AcceptButton = this.encryptMasterKeyButton;

                sw.Stop();
                string elapseTime = sw.Elapsed.Duration().ToString("mm\\:ss\\.ff");

                this.elapsedTimeLabel.Text = "Elapsed Time: " + elapseTime;
                this.elapsedTimeLabel.Visible = true;
            }
            finally
            {

                Cursor.Current = Cursors.Default;
            }
        }

        /// <summary>
        /// Encrypt the Master Key
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void encryptMasterKeyButton_Click(object sender, EventArgs e)
        {
            string message = this.masterKeyTextBox.Text;

            if (String.IsNullOrWhiteSpace(message))
            {
                MessageBox.Show("A Master Key is Required", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (message.Length < 3)
            {
                MessageBox.Show("The Master Key Must be at Least 3 Characters Long", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    string cipherText;

                    switch (this.AsymmetricSchemeToUse)
                    {
                        case AsymmetricScheme.RSA:

                            RSA rsa = new RSA(this.PrimalityTestToUse, this.SecurityToken);
                            cipherText = rsa.Encrypt(message, this.OtherUsersRSAPublicKey);
                            this.encryptedMasterKeyLabel.Text = cipherText;

                            break;

                        case AsymmetricScheme.ElGamal:

                            ElGamal elGamal = new ElGamal(this.PrimalityTestToUse, this.SecurityToken);

                            Tuple<BigInteger, BigInteger> cipherText2 = elGamal.Encrypt(message, this.OtherUsersElGamalPublicKey);

                            this.gammaLabel.Text = cipherText2.Item1.ToString();
                            this.deltaLabel.Text = cipherText2.Item2.ToString();

                            this.encryptedMasterKeyLabel.Text = "(" + cipherText2.Item1.ToString() + " / " + cipherText2.Item2.ToString() + ")";

                            break;
                    }


                    // Encrypt the Master Key




                    this.requestPublicKeyButton.Enabled = false;
                    this.encryptMasterKeyButton.Enabled = false;
                    this.decryptMasterKeyButton.Enabled = false;
                    this.sendMasterKeyButton.Enabled = true;
                    this.sendMasterKeyButton.Focus();
                    this.masterKeyLabel.Text = this.masterKeyTextBox.Text;
                    this.masterKeyTextBox.Visible = false;
                    this.masterKeyLabel.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void decryptMasterKeyButton_Click(object sender, EventArgs e)
        {
            string cipherText = this.encryptedMasterKeyLabel.Text;
            string plainText = String.Empty;

            switch (this.AsymmetricSchemeToUse)
            {
                case AsymmetricScheme.RSA:

                    plainText = this.rsa.Decrypt(cipherText);

                    break;

                case AsymmetricScheme.ElGamal:

                    plainText = this.elGamal.Decrypt(BigInteger.Parse(this.gammaLabel.Text), BigInteger.Parse(this.deltaLabel.Text)).ToString();

                    break;
            }




            this.masterKeyLabel.Text = plainText;

            this.decryptMasterKeyButton.Enabled = false;
            this.plainTextTextBox.Enabled = true;
            this.ReferenceToOtherUser.plainTextTextBox.Enabled = true;
            this.encryptPlainTextButton.Enabled = true;
            this.ReferenceToOtherUser.encryptPlainTextButton.Enabled = true;
            this.decryptCipherTextButton.Enabled = true;
            this.ReferenceToOtherUser.decryptCipherTextButton.Enabled = true;
            this.sendCipherTextButton.Enabled = true;
            this.ReferenceToOtherUser.sendCipherTextButton.Enabled = true;


        }

        private void sendMasterKeyButton_Click(object sender, EventArgs e)
        {
            // Send the encrypted master key to the other user
            this.ReferenceToOtherUser.encryptedMasterKeyLabel.Text = this.encryptedMasterKeyLabel.Text;
            this.ReferenceToOtherUser.encryptMasterKeyButton.Enabled = false;
            this.ReferenceToOtherUser.sendMasterKeyButton.Enabled = false;
            this.ReferenceToOtherUser.decryptMasterKeyButton.Enabled = true;
            this.sendMasterKeyButton.Enabled = false;

            switch (this.AsymmetricSchemeToUse)
            {
                case AsymmetricScheme.RSA:


                    break;

                case AsymmetricScheme.ElGamal:


                    this.ReferenceToOtherUser.gammaLabel.Text = this.gammaLabel.Text;
                    this.ReferenceToOtherUser.deltaLabel.Text = this.deltaLabel.Text;

                    break;
            }


        }

        /// <summary>
        /// Handles a public key request from another user
        /// </summary>
        /// <returns></returns>
        public RSAPublicKey RequestRSAPublicKey()
        {
            rsa = new RSA(this.PrimalityTestToUse, this.SecurityToken);

            rsa.KeyGeneration(KeySize);

            RSAPublicKey publicKey = rsa.PublicKey;

            this.nLabel.Text = publicKey.N.ToString();
            this.eLabel.Text = publicKey.E.ToString();

            RSAPrivateKey privateKey = rsa.PrivateKey;

            this.pLabel.Text = privateKey.P.ToString();
            this.qLabel.Text = privateKey.Q.ToString();
            this.dLabel.Text = privateKey.D.ToString();
            this.phiLabel.Text = privateKey.Phi.ToString();

            return publicKey;
        }

        public ElGamalPublicKey RequestElGamalPublicKey()
        {
            elGamal = new ElGamal(this.PrimalityTestToUse, this.SecurityToken);

            elGamal.KeyGeneration(KeySize);

            ElGamalPublicKey publicKey = elGamal.PublicKey;

            this.p2Label.Text = publicKey.P.ToString();
            this.alphaLabel.Text = publicKey.Alpha.ToString();
            this.alphaToALabel.Text = publicKey.AlphaToA.ToString();

            ElGamalPrivateKey privateKey = elGamal.PrivateKey;

            this.aLabel.Text = privateKey.A.ToString();
            //this.qLabel.Text = privateKey.Q.ToString();
            //this.dLabel.Text = privateKey.D.ToString();
            //this.phiLabel.Text = privateKey.Phi.ToString();

            return publicKey;
        }

        #endregion

        #region Symmetric Encryption Related

        private void encryptPlainTextButton_Click(object sender, EventArgs e)
        {
            string plainText = this.plainTextTextBox.Text;

            if (String.IsNullOrWhiteSpace(plainText))
            {
                MessageBox.Show("Plain Text is Blank", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string masterKey = masterKeyLabel.Text;

                TripleDES des = new TripleDES();

                string cipherText = des.Encrypt(plainText, masterKey);

                this.cipherTextLabel.Text = cipherText;

            }
        }

        private void decryptCipherTextButton_Click(object sender, EventArgs e)
        {
            string cipherText = this.cipherTextLabel.Text;

            if (String.IsNullOrWhiteSpace(cipherText))
            {
                MessageBox.Show("Cipher Text is Blank", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string masterKey = masterKeyLabel.Text;

                TripleDES des = new TripleDES();

                string plainText = des.Decrypt(cipherText, masterKey);

                this.plainTextTextBox.Text = plainText;
            }
        }

        private void sendCipherTextButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(this.cipherTextLabel.Text))
            {
                MessageBox.Show("Cipher Text is Blank", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                this.ReferenceToOtherUser.cipherTextLabel.Text = this.cipherTextLabel.Text;

                this.ReferenceToOtherUser.plainTextTextBox.Enabled = true;
                this.ReferenceToOtherUser.encryptPlainTextButton.Enabled = true;
                this.ReferenceToOtherUser.decryptCipherTextButton.Enabled = true;
                this.ReferenceToOtherUser.sendCipherTextButton.Enabled = true;
            }
        }

        private void clearTextButton_Click(object sender, EventArgs e)
        {
            this.plainTextTextBox.Text = "";
        }

        #endregion

        private void User_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!this.ReferenceToOtherUser.IsClosing)
            {
                this.ReferenceToOtherUser.IsClosing = true;
                this.ReferenceToOtherUser.Close();
            }
        }


    }
}
