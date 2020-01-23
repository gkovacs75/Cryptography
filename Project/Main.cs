using System;
using System.Drawing;
using System.Windows.Forms;

namespace Project
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            User Bob = new User();
            User Alice = new User();

            Bob.StartPosition = Alice.StartPosition = FormStartPosition.Manual;

            Bob.Location = new Point(25, 25);
            Bob.Size = new Size(this.Width / 2 - 50, 800);

            Alice.Location = new Point(Bob.Width + 25, 25);
            Alice.Size = new Size(this.Width / 2 - 50, 800);

            Bob.SecurityToken = Alice.SecurityToken = this.securityTokenTrackBar.Value;

            Bob.ReferenceToOtherUser = Alice;
            Alice.ReferenceToOtherUser = Bob;

            if (_256BitRadioButton.Checked)
            {
                Bob.KeySize = Alice.KeySize = 256;
            }
            else if (_512BitRadioButton.Checked)
            {
                Bob.KeySize = Alice.KeySize = 512;
            }
            else if (_1024BitRadioButton.Checked)
            {
                Bob.KeySize = Alice.KeySize = 1024;
            }
            else if (_2048BitRadioButton.Checked)
            {
                Bob.KeySize = Alice.KeySize = 2048;
            }

            if (rsaSymmetricAlgorithmRadioButton.Checked && _3desAsymmetricAlgorithmRadioButton.Checked)
            {
                Bob.AsymmetricSchemeToUse = Alice.AsymmetricSchemeToUse = Ciphers.AsymmetricScheme.RSA;
                Bob.Text = "Bob - RSA/3DES";
                Alice.Text = "Alice - RSA/3DES";

                Bob.elGamalPanel.Visible = Alice.elGamalPanel.Visible = false;
                Bob.rsaPanel.Visible = Alice.rsaPanel.Visible = true;
                Bob.rsaPanel.Dock = Alice.rsaPanel.Dock = DockStyle.Fill;

            }
            else if (elGamalRadioButton.Checked && _3desAsymmetricAlgorithmRadioButton.Checked)
            {
                Bob.AsymmetricSchemeToUse = Alice.AsymmetricSchemeToUse = Ciphers.AsymmetricScheme.ElGamal;
                Bob.Text = "Bob - ElGamal/3DES";
                Alice.Text = "Alice - ElGamal/3DES";

                Bob.rsaPanel.Visible = Alice.rsaPanel.Visible = false;
                Bob.elGamalPanel.Visible = Alice.elGamalPanel.Visible = true;
                Bob.elGamalPanel.Dock = Alice.elGamalPanel.Dock = DockStyle.Fill;
            }

            if (this.fermatPrimalityTestRadioButton.Checked)
            {
                Bob.PrimalityTestToUse = Ciphers.PrimalityTest.Fermat;
                Alice.PrimalityTestToUse = Ciphers.PrimalityTest.Fermat;
            }
            else if (this.rabinMillerPrimalityTestRadioButton.Checked)
            {
                Bob.PrimalityTestToUse = Ciphers.PrimalityTest.RabinMiller;
                Alice.PrimalityTestToUse = Ciphers.PrimalityTest.RabinMiller;
            }

            Bob.Show();
            Alice.Show();
        }

        private void securityTokenTrackBar_Scroll(object sender, EventArgs e)
        {
            this.securityTokenLabel.Text = this.securityTokenTrackBar.Value.ToString();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.securityTokenLabel.Text = this.securityTokenTrackBar.Value.ToString();
        }

        private void assignment3StartButton_Click(object sender, EventArgs e)
        {
            Assignment3User Bob = new Assignment3User();
            Assignment3User Alice = new Assignment3User();

            Bob.StartPosition = Alice.StartPosition = FormStartPosition.Manual;

            Bob.Location = new Point(25, 25);
            Bob.Size = new Size(this.Width / 2 - 50, 800);

            Alice.Location = new Point(Bob.Width + 25, 25);
            Alice.Size = new Size(this.Width / 2 - 50, 800);

            Bob.SecurityToken = Alice.SecurityToken = this.securityTokenTrackBar.Value;

            Bob.ReferenceToOtherAssignment3User = Alice;
            Alice.ReferenceToOtherAssignment3User = Bob;

            if (_256BitRadioButton.Checked)
            {
                Bob.KeySize = Alice.KeySize = 256;
            }
            else if (_512BitRadioButton.Checked)
            {
                Bob.KeySize = Alice.KeySize = 512;
            }

            if (this.fermatPrimalityTestRadioButton.Checked)
            {
                Bob.PrimalityTestToUse = Ciphers.PrimalityTest.Fermat;
                Alice.PrimalityTestToUse = Ciphers.PrimalityTest.Fermat;
            }
            else if (this.rabinMillerPrimalityTestRadioButton.Checked)
            {
                Bob.PrimalityTestToUse = Ciphers.PrimalityTest.RabinMiller;
                Alice.PrimalityTestToUse = Ciphers.PrimalityTest.RabinMiller;
            }

            Bob.Text = "Bob";
            Alice.Text = "Alice";

            Bob.Show();
            Alice.Show();
        }
    }
}
