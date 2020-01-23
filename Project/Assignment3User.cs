using Ciphers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using System.Text;
using System.Windows.Forms;

namespace Project
{
    public partial class Assignment3User : Form
    {
        #region Declarations


        public bool IsClosing { get; set; }
        public Assignment3User ReferenceToOtherAssignment3User { get; set; }
        public ElGamalPublicKey MyPublicKey { get; set; }
        private ElGamalPrivateKey MyPrivateKey { get; set; }
        public int KeySize { get; set; }
        public PrimalityTest PrimalityTestToUse { get; set; }
        public int SecurityToken { get; set; }

        public List<Tuple<BigInteger, BigInteger>> CipherTextChunks { get; set; }

        private ElGamal elGamal;

        #endregion

        #region Constructors
        public Assignment3User()
        {
            InitializeComponent();
        }

        #endregion


        private void generateKeysButton_Click(object sender, EventArgs e)
        {
            elGamal = new ElGamal(this.PrimalityTestToUse, this.SecurityToken);

            elGamal.KeyGeneration(KeySize);

            ElGamalPublicKey publicKey = elGamal.PublicKey;

            this.pLabel.Text = publicKey.P.ToString();
            this.alphaLabel.Text = publicKey.Alpha.ToString();
            this.alphaToALabel.Text = publicKey.AlphaToA.ToString();

            ElGamalPrivateKey privateKey = elGamal.PrivateKey;

            this.aLabel.Text = privateKey.A.ToString();

            this.MyPublicKey = publicKey;
            this.MyPrivateKey = privateKey;
        }

        private void requestOtherUsersPublicKeyButton_Click(object sender, EventArgs e)
        {
            ElGamalPublicKey otherUsersPublicKey = this.ReferenceToOtherAssignment3User.MyPublicKey;

            if (otherUsersPublicKey == null)
            {
                MessageBox.Show("The Other User Hasn't Generated Their Keys Yet", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                this.otherUsersPLabel.Text = otherUsersPublicKey.P.ToString();
                this.otherUsersAlphaLabel.Text = otherUsersPublicKey.Alpha.ToString();
                this.otherUsersAlphaToALabel.Text = otherUsersPublicKey.AlphaToA.ToString();

                this.plainTextTextBox.Enabled = true;
            }
        }

        private void Assignment3User_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!this.ReferenceToOtherAssignment3User.IsClosing)
            {
                this.ReferenceToOtherAssignment3User.IsClosing = true;
                this.ReferenceToOtherAssignment3User.Close();
            }
        }

        private void encryptButton_Click(object sender, EventArgs e)
        {
            string message = this.plainTextTextBox.Text;

            if (String.IsNullOrWhiteSpace(message))
            {
                MessageBox.Show("A Plain Text is Required", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    if (this.ReferenceToOtherAssignment3User.MyPublicKey == null)
                    {
                        MessageBox.Show("Request the Other Guy's Public Key", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        ElGamal elGamal = new ElGamal(this.PrimalityTestToUse, this.SecurityToken);

                        List<Tuple<BigInteger, BigInteger>> cipherTextChunks = elGamal.EncryptWithChunking(message, this.ReferenceToOtherAssignment3User.MyPublicKey);

                        this.CipherTextChunks = cipherTextChunks;

                        if (cipherTextChunks.Count == 1)
                        {
                            this.gammaLabel.Text = cipherTextChunks[0].Item1.ToString();
                            this.deltaLabel.Text = cipherTextChunks[0].Item2.ToString();

                            this.cipherTextLabel.Text = "(" + cipherTextChunks[0].Item1.ToString() + "/" + cipherTextChunks[0].Item2.ToString() + ")";
                        }
                        else
                        {
                            this.gammaLabel.Text = "Multiple Chunks...";
                            this.deltaLabel.Text = "Multiple Chunks...";

                            this.cipherTextLabel.Text = "Multiple Chunks...";
                        }

                        this.sendCipherTextButton.Enabled = true;
                        this.sendCipherTextButton.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void decryptButton_Click(object sender, EventArgs e)
        {
            string cipherText = this.cipherTextLabel.Text;

            if (String.IsNullOrWhiteSpace(cipherText))
            {
                MessageBox.Show("Cipher Text is Required", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (this.elGamal == null)
                {
                    MessageBox.Show("Nothing to Decrypt", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string plainText = String.Empty;

                    //plainText = this.elGamal.Decrypt(BigInteger.Parse(this.gammaLabel.Text), BigInteger.Parse(this.deltaLabel.Text)).ToString();
                    plainText = this.elGamal.DecryptWithChunking(this.CipherTextChunks);

                    this.plainTextTextBox.Text = plainText;

                    this.decryptButton.Enabled = false;
                }
            }
        }

        private void sendCipherTextButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(this.cipherTextLabel.Text))
            {
                MessageBox.Show("There is Nothing to Send", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Send the encrypted master key to the other Assignment3User
                this.ReferenceToOtherAssignment3User.CipherTextChunks = this.CipherTextChunks;
                this.ReferenceToOtherAssignment3User.cipherTextLabel.Text = this.cipherTextLabel.Text;
                this.ReferenceToOtherAssignment3User.decryptButton.Enabled = true;
                this.ReferenceToOtherAssignment3User.gammaLabel.Text = this.gammaLabel.Text;
                this.ReferenceToOtherAssignment3User.deltaLabel.Text = this.deltaLabel.Text;
            }
        }
    }
}
