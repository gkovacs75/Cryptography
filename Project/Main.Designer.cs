namespace Project
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.startButton = new System.Windows.Forms.Button();
            this._256BitRadioButton = new System.Windows.Forms.RadioButton();
            this._512BitRadioButton = new System.Windows.Forms.RadioButton();
            this.keySizeGroupBox = new System.Windows.Forms.GroupBox();
            this._2048BitRadioButton = new System.Windows.Forms.RadioButton();
            this._1024BitRadioButton = new System.Windows.Forms.RadioButton();
            this.asymmetricAlgorithmGroupBox = new System.Windows.Forms.GroupBox();
            this.elGamalRadioButton = new System.Windows.Forms.RadioButton();
            this.rsaSymmetricAlgorithmRadioButton = new System.Windows.Forms.RadioButton();
            this.symmetricAlgorithmGroupBox = new System.Windows.Forms.GroupBox();
            this._3desAsymmetricAlgorithmRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rabinMillerPrimalityTestRadioButton = new System.Windows.Forms.RadioButton();
            this.fermatPrimalityTestRadioButton = new System.Windows.Forms.RadioButton();
            this.securityTokenLabel = new System.Windows.Forms.Label();
            this.securityTokenTrackBar = new System.Windows.Forms.TrackBar();
            this.assignment3StartButton = new System.Windows.Forms.Button();
            this.keySizeGroupBox.SuspendLayout();
            this.asymmetricAlgorithmGroupBox.SuspendLayout();
            this.symmetricAlgorithmGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.securityTokenTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(30, 208);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(427, 62);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Project - Start Test";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // _256BitRadioButton
            // 
            this._256BitRadioButton.AutoSize = true;
            this._256BitRadioButton.Checked = true;
            this._256BitRadioButton.Location = new System.Drawing.Point(22, 28);
            this._256BitRadioButton.Name = "_256BitRadioButton";
            this._256BitRadioButton.Size = new System.Drawing.Size(58, 17);
            this._256BitRadioButton.TabIndex = 1;
            this._256BitRadioButton.TabStop = true;
            this._256BitRadioButton.Text = "256 Bit";
            this._256BitRadioButton.UseVisualStyleBackColor = true;
            // 
            // _512BitRadioButton
            // 
            this._512BitRadioButton.AutoSize = true;
            this._512BitRadioButton.Location = new System.Drawing.Point(22, 51);
            this._512BitRadioButton.Name = "_512BitRadioButton";
            this._512BitRadioButton.Size = new System.Drawing.Size(58, 17);
            this._512BitRadioButton.TabIndex = 2;
            this._512BitRadioButton.Text = "512 Bit";
            this._512BitRadioButton.UseVisualStyleBackColor = true;
            // 
            // keySizeGroupBox
            // 
            this.keySizeGroupBox.Controls.Add(this._2048BitRadioButton);
            this.keySizeGroupBox.Controls.Add(this._1024BitRadioButton);
            this.keySizeGroupBox.Controls.Add(this._256BitRadioButton);
            this.keySizeGroupBox.Controls.Add(this._512BitRadioButton);
            this.keySizeGroupBox.Location = new System.Drawing.Point(30, 33);
            this.keySizeGroupBox.Name = "keySizeGroupBox";
            this.keySizeGroupBox.Size = new System.Drawing.Size(114, 149);
            this.keySizeGroupBox.TabIndex = 4;
            this.keySizeGroupBox.TabStop = false;
            this.keySizeGroupBox.Text = "Key Size";
            // 
            // _2048BitRadioButton
            // 
            this._2048BitRadioButton.AutoSize = true;
            this._2048BitRadioButton.Location = new System.Drawing.Point(22, 97);
            this._2048BitRadioButton.Name = "_2048BitRadioButton";
            this._2048BitRadioButton.Size = new System.Drawing.Size(64, 17);
            this._2048BitRadioButton.TabIndex = 7;
            this._2048BitRadioButton.Text = "2048 Bit";
            this._2048BitRadioButton.UseVisualStyleBackColor = true;
            // 
            // _1024BitRadioButton
            // 
            this._1024BitRadioButton.AutoSize = true;
            this._1024BitRadioButton.Location = new System.Drawing.Point(22, 74);
            this._1024BitRadioButton.Name = "_1024BitRadioButton";
            this._1024BitRadioButton.Size = new System.Drawing.Size(64, 17);
            this._1024BitRadioButton.TabIndex = 6;
            this._1024BitRadioButton.Text = "1024 Bit";
            this._1024BitRadioButton.UseVisualStyleBackColor = true;
            // 
            // asymmetricAlgorithmGroupBox
            // 
            this.asymmetricAlgorithmGroupBox.Controls.Add(this.elGamalRadioButton);
            this.asymmetricAlgorithmGroupBox.Controls.Add(this.rsaSymmetricAlgorithmRadioButton);
            this.asymmetricAlgorithmGroupBox.Location = new System.Drawing.Point(165, 33);
            this.asymmetricAlgorithmGroupBox.Name = "asymmetricAlgorithmGroupBox";
            this.asymmetricAlgorithmGroupBox.Size = new System.Drawing.Size(150, 149);
            this.asymmetricAlgorithmGroupBox.TabIndex = 5;
            this.asymmetricAlgorithmGroupBox.TabStop = false;
            this.asymmetricAlgorithmGroupBox.Text = "Asymmetric Algorithm";
            // 
            // elGamalRadioButton
            // 
            this.elGamalRadioButton.AutoSize = true;
            this.elGamalRadioButton.Location = new System.Drawing.Point(16, 51);
            this.elGamalRadioButton.Name = "elGamalRadioButton";
            this.elGamalRadioButton.Size = new System.Drawing.Size(64, 17);
            this.elGamalRadioButton.TabIndex = 1;
            this.elGamalRadioButton.Text = "ElGamal";
            this.elGamalRadioButton.UseVisualStyleBackColor = true;
            // 
            // rsaSymmetricAlgorithmRadioButton
            // 
            this.rsaSymmetricAlgorithmRadioButton.AutoSize = true;
            this.rsaSymmetricAlgorithmRadioButton.Checked = true;
            this.rsaSymmetricAlgorithmRadioButton.Location = new System.Drawing.Point(16, 28);
            this.rsaSymmetricAlgorithmRadioButton.Name = "rsaSymmetricAlgorithmRadioButton";
            this.rsaSymmetricAlgorithmRadioButton.Size = new System.Drawing.Size(47, 17);
            this.rsaSymmetricAlgorithmRadioButton.TabIndex = 0;
            this.rsaSymmetricAlgorithmRadioButton.TabStop = true;
            this.rsaSymmetricAlgorithmRadioButton.Text = "RSA";
            this.rsaSymmetricAlgorithmRadioButton.UseVisualStyleBackColor = true;
            // 
            // symmetricAlgorithmGroupBox
            // 
            this.symmetricAlgorithmGroupBox.Controls.Add(this._3desAsymmetricAlgorithmRadioButton);
            this.symmetricAlgorithmGroupBox.Location = new System.Drawing.Point(334, 33);
            this.symmetricAlgorithmGroupBox.Name = "symmetricAlgorithmGroupBox";
            this.symmetricAlgorithmGroupBox.Size = new System.Drawing.Size(150, 149);
            this.symmetricAlgorithmGroupBox.TabIndex = 6;
            this.symmetricAlgorithmGroupBox.TabStop = false;
            this.symmetricAlgorithmGroupBox.Text = "Symmetric Algorithm";
            // 
            // _3desAsymmetricAlgorithmRadioButton
            // 
            this._3desAsymmetricAlgorithmRadioButton.AutoSize = true;
            this._3desAsymmetricAlgorithmRadioButton.Checked = true;
            this._3desAsymmetricAlgorithmRadioButton.Location = new System.Drawing.Point(23, 28);
            this._3desAsymmetricAlgorithmRadioButton.Name = "_3desAsymmetricAlgorithmRadioButton";
            this._3desAsymmetricAlgorithmRadioButton.Size = new System.Drawing.Size(53, 17);
            this._3desAsymmetricAlgorithmRadioButton.TabIndex = 0;
            this._3desAsymmetricAlgorithmRadioButton.TabStop = true;
            this._3desAsymmetricAlgorithmRadioButton.Text = "3DES";
            this._3desAsymmetricAlgorithmRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rabinMillerPrimalityTestRadioButton);
            this.groupBox1.Controls.Add(this.fermatPrimalityTestRadioButton);
            this.groupBox1.Controls.Add(this.securityTokenLabel);
            this.groupBox1.Controls.Add(this.securityTokenTrackBar);
            this.groupBox1.Location = new System.Drawing.Point(506, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(447, 237);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Primality Test && Security Parameter";
            // 
            // rabinMillerPrimalityTestRadioButton
            // 
            this.rabinMillerPrimalityTestRadioButton.AutoSize = true;
            this.rabinMillerPrimalityTestRadioButton.Location = new System.Drawing.Point(22, 51);
            this.rabinMillerPrimalityTestRadioButton.Name = "rabinMillerPrimalityTestRadioButton";
            this.rabinMillerPrimalityTestRadioButton.Size = new System.Drawing.Size(83, 17);
            this.rabinMillerPrimalityTestRadioButton.TabIndex = 3;
            this.rabinMillerPrimalityTestRadioButton.Text = "Rabin Miller ";
            this.rabinMillerPrimalityTestRadioButton.UseVisualStyleBackColor = true;
            // 
            // fermatPrimalityTestRadioButton
            // 
            this.fermatPrimalityTestRadioButton.AutoSize = true;
            this.fermatPrimalityTestRadioButton.Checked = true;
            this.fermatPrimalityTestRadioButton.Location = new System.Drawing.Point(22, 28);
            this.fermatPrimalityTestRadioButton.Name = "fermatPrimalityTestRadioButton";
            this.fermatPrimalityTestRadioButton.Size = new System.Drawing.Size(57, 17);
            this.fermatPrimalityTestRadioButton.TabIndex = 2;
            this.fermatPrimalityTestRadioButton.TabStop = true;
            this.fermatPrimalityTestRadioButton.Text = "Fermat";
            this.fermatPrimalityTestRadioButton.UseVisualStyleBackColor = true;
            // 
            // securityTokenLabel
            // 
            this.securityTokenLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.securityTokenLabel.Location = new System.Drawing.Point(22, 149);
            this.securityTokenLabel.Name = "securityTokenLabel";
            this.securityTokenLabel.Size = new System.Drawing.Size(100, 23);
            this.securityTokenLabel.TabIndex = 1;
            // 
            // securityTokenTrackBar
            // 
            this.securityTokenTrackBar.LargeChange = 100;
            this.securityTokenTrackBar.Location = new System.Drawing.Point(22, 92);
            this.securityTokenTrackBar.Maximum = 5000;
            this.securityTokenTrackBar.Minimum = 2;
            this.securityTokenTrackBar.Name = "securityTokenTrackBar";
            this.securityTokenTrackBar.Size = new System.Drawing.Size(389, 45);
            this.securityTokenTrackBar.SmallChange = 10;
            this.securityTokenTrackBar.TabIndex = 0;
            this.securityTokenTrackBar.Value = 1000;
            this.securityTokenTrackBar.Scroll += new System.EventHandler(this.securityTokenTrackBar_Scroll);
            // 
            // assignment3StartButton
            // 
            this.assignment3StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assignment3StartButton.Location = new System.Drawing.Point(30, 287);
            this.assignment3StartButton.Name = "assignment3StartButton";
            this.assignment3StartButton.Size = new System.Drawing.Size(427, 64);
            this.assignment3StartButton.TabIndex = 8;
            this.assignment3StartButton.Text = "Assignment 3 - Start Test";
            this.assignment3StartButton.UseVisualStyleBackColor = true;
            this.assignment3StartButton.Visible = false;
            this.assignment3StartButton.Click += new System.EventHandler(this.assignment3StartButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 701);
            this.Controls.Add(this.assignment3StartButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.symmetricAlgorithmGroupBox);
            this.Controls.Add(this.asymmetricAlgorithmGroupBox);
            this.Controls.Add(this.keySizeGroupBox);
            this.Controls.Add(this.startButton);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cryptography ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.keySizeGroupBox.ResumeLayout(false);
            this.keySizeGroupBox.PerformLayout();
            this.asymmetricAlgorithmGroupBox.ResumeLayout(false);
            this.asymmetricAlgorithmGroupBox.PerformLayout();
            this.symmetricAlgorithmGroupBox.ResumeLayout(false);
            this.symmetricAlgorithmGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.securityTokenTrackBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.RadioButton _256BitRadioButton;
        private System.Windows.Forms.RadioButton _512BitRadioButton;
        private System.Windows.Forms.GroupBox keySizeGroupBox;
        private System.Windows.Forms.GroupBox asymmetricAlgorithmGroupBox;
        private System.Windows.Forms.GroupBox symmetricAlgorithmGroupBox;
        private System.Windows.Forms.RadioButton rsaSymmetricAlgorithmRadioButton;
        private System.Windows.Forms.RadioButton _3desAsymmetricAlgorithmRadioButton;
        private System.Windows.Forms.RadioButton elGamalRadioButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar securityTokenTrackBar;
        private System.Windows.Forms.Label securityTokenLabel;
        private System.Windows.Forms.Button assignment3StartButton;
        private System.Windows.Forms.RadioButton _2048BitRadioButton;
        private System.Windows.Forms.RadioButton _1024BitRadioButton;
        private System.Windows.Forms.RadioButton rabinMillerPrimalityTestRadioButton;
        private System.Windows.Forms.RadioButton fermatPrimalityTestRadioButton;
    }
}