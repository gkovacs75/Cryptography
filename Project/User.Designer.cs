namespace Project
{
    partial class User
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
            this.plainTextTextBox = new System.Windows.Forms.TextBox();
            this.encryptPlainTextButton = new System.Windows.Forms.Button();
            this.requestPublicKeyButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.elapsedTimeLabel = new System.Windows.Forms.Label();
            this.rsaPanel = new System.Windows.Forms.Panel();
            this.pLabel = new System.Windows.Forms.Label();
            this.nLabel = new System.Windows.Forms.Label();
            this.qLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.eLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.phiLabel = new System.Windows.Forms.Label();
            this.dLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.elGamalPanel = new System.Windows.Forms.Panel();
            this.deltaLabel = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.gammaLabel = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.alphaToALabel = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.aLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.alphaLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.p2Label = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.masterKeyLabel = new System.Windows.Forms.Label();
            this.encryptedMasterKeyLabel = new System.Windows.Forms.Label();
            this.decryptMasterKeyButton = new System.Windows.Forms.Button();
            this.sendMasterKeyButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.encryptMasterKeyButton = new System.Windows.Forms.Button();
            this.masterKeyTextBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.clearTextButton = new System.Windows.Forms.Button();
            this.cipherTextLabel = new System.Windows.Forms.Label();
            this.sendCipherTextButton = new System.Windows.Forms.Button();
            this.decryptCipherTextButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.rsaPanel.SuspendLayout();
            this.elGamalPanel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // plainTextTextBox
            // 
            this.plainTextTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.plainTextTextBox.Enabled = false;
            this.plainTextTextBox.ForeColor = System.Drawing.Color.Red;
            this.plainTextTextBox.Location = new System.Drawing.Point(17, 24);
            this.plainTextTextBox.Multiline = true;
            this.plainTextTextBox.Name = "plainTextTextBox";
            this.plainTextTextBox.Size = new System.Drawing.Size(288, 144);
            this.plainTextTextBox.TabIndex = 0;
            // 
            // encryptPlainTextButton
            // 
            this.encryptPlainTextButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.encryptPlainTextButton.Enabled = false;
            this.encryptPlainTextButton.Location = new System.Drawing.Point(17, 174);
            this.encryptPlainTextButton.Name = "encryptPlainTextButton";
            this.encryptPlainTextButton.Size = new System.Drawing.Size(288, 23);
            this.encryptPlainTextButton.TabIndex = 1;
            this.encryptPlainTextButton.Text = "Encrypt Plain Text";
            this.encryptPlainTextButton.UseVisualStyleBackColor = true;
            this.encryptPlainTextButton.Click += new System.EventHandler(this.encryptPlainTextButton_Click);
            // 
            // requestPublicKeyButton
            // 
            this.requestPublicKeyButton.Location = new System.Drawing.Point(14, 12);
            this.requestPublicKeyButton.Name = "requestPublicKeyButton";
            this.requestPublicKeyButton.Size = new System.Drawing.Size(212, 23);
            this.requestPublicKeyButton.TabIndex = 2;
            this.requestPublicKeyButton.Text = "Request Public Key";
            this.requestPublicKeyButton.UseVisualStyleBackColor = true;
            this.requestPublicKeyButton.Click += new System.EventHandler(this.requestPublicKeyButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(13, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "n:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.rsaPanel);
            this.groupBox1.Controls.Add(this.elGamalPanel);
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(681, 273);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Key Exchange";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.requestPublicKeyButton);
            this.panel1.Controls.Add(this.elapsedTimeLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 220);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(675, 50);
            this.panel1.TabIndex = 18;
            // 
            // elapsedTimeLabel
            // 
            this.elapsedTimeLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.elapsedTimeLabel.Location = new System.Drawing.Point(233, 12);
            this.elapsedTimeLabel.Name = "elapsedTimeLabel";
            this.elapsedTimeLabel.Size = new System.Drawing.Size(298, 23);
            this.elapsedTimeLabel.TabIndex = 15;
            this.elapsedTimeLabel.Visible = false;
            // 
            // rsaPanel
            // 
            this.rsaPanel.Controls.Add(this.pLabel);
            this.rsaPanel.Controls.Add(this.label1);
            this.rsaPanel.Controls.Add(this.nLabel);
            this.rsaPanel.Controls.Add(this.qLabel);
            this.rsaPanel.Controls.Add(this.label2);
            this.rsaPanel.Controls.Add(this.label6);
            this.rsaPanel.Controls.Add(this.eLabel);
            this.rsaPanel.Controls.Add(this.label3);
            this.rsaPanel.Controls.Add(this.label5);
            this.rsaPanel.Controls.Add(this.phiLabel);
            this.rsaPanel.Controls.Add(this.dLabel);
            this.rsaPanel.Controls.Add(this.label4);
            this.rsaPanel.Location = new System.Drawing.Point(314, 16);
            this.rsaPanel.Name = "rsaPanel";
            this.rsaPanel.Size = new System.Drawing.Size(344, 181);
            this.rsaPanel.TabIndex = 16;
            this.rsaPanel.Visible = false;
            // 
            // pLabel
            // 
            this.pLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pLabel.ForeColor = System.Drawing.Color.Red;
            this.pLabel.Location = new System.Drawing.Point(41, 17);
            this.pLabel.Name = "pLabel";
            this.pLabel.Size = new System.Drawing.Size(288, 20);
            this.pLabel.TabIndex = 12;
            this.pLabel.Text = "n/a";
            // 
            // nLabel
            // 
            this.nLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.nLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nLabel.ForeColor = System.Drawing.Color.Green;
            this.nLabel.Location = new System.Drawing.Point(41, 68);
            this.nLabel.Name = "nLabel";
            this.nLabel.Size = new System.Drawing.Size(288, 20);
            this.nLabel.TabIndex = 4;
            this.nLabel.Text = "n/a";
            // 
            // qLabel
            // 
            this.qLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.qLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.qLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qLabel.ForeColor = System.Drawing.Color.Red;
            this.qLabel.Location = new System.Drawing.Point(41, 43);
            this.qLabel.Name = "qLabel";
            this.qLabel.Size = new System.Drawing.Size(288, 20);
            this.qLabel.TabIndex = 14;
            this.qLabel.Text = "n/a";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(13, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "e:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(13, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "q:";
            // 
            // eLabel
            // 
            this.eLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.eLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eLabel.ForeColor = System.Drawing.Color.Green;
            this.eLabel.Location = new System.Drawing.Point(41, 116);
            this.eLabel.Name = "eLabel";
            this.eLabel.Size = new System.Drawing.Size(288, 20);
            this.eLabel.TabIndex = 6;
            this.eLabel.Text = "n/a";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(13, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "φ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(13, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "p:";
            // 
            // phiLabel
            // 
            this.phiLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.phiLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.phiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phiLabel.ForeColor = System.Drawing.Color.Red;
            this.phiLabel.Location = new System.Drawing.Point(41, 92);
            this.phiLabel.Name = "phiLabel";
            this.phiLabel.Size = new System.Drawing.Size(288, 20);
            this.phiLabel.TabIndex = 8;
            this.phiLabel.Text = "n/a";
            // 
            // dLabel
            // 
            this.dLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dLabel.ForeColor = System.Drawing.Color.Red;
            this.dLabel.Location = new System.Drawing.Point(41, 142);
            this.dLabel.Name = "dLabel";
            this.dLabel.Size = new System.Drawing.Size(288, 20);
            this.dLabel.TabIndex = 10;
            this.dLabel.Text = "n/a";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(13, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "d:";
            // 
            // elGamalPanel
            // 
            this.elGamalPanel.Controls.Add(this.deltaLabel);
            this.elGamalPanel.Controls.Add(this.label17);
            this.elGamalPanel.Controls.Add(this.gammaLabel);
            this.elGamalPanel.Controls.Add(this.label14);
            this.elGamalPanel.Controls.Add(this.alphaToALabel);
            this.elGamalPanel.Controls.Add(this.label13);
            this.elGamalPanel.Controls.Add(this.aLabel);
            this.elGamalPanel.Controls.Add(this.label12);
            this.elGamalPanel.Controls.Add(this.alphaLabel);
            this.elGamalPanel.Controls.Add(this.label10);
            this.elGamalPanel.Controls.Add(this.p2Label);
            this.elGamalPanel.Controls.Add(this.label9);
            this.elGamalPanel.Location = new System.Drawing.Point(3, 16);
            this.elGamalPanel.Name = "elGamalPanel";
            this.elGamalPanel.Size = new System.Drawing.Size(281, 198);
            this.elGamalPanel.TabIndex = 17;
            this.elGamalPanel.Visible = false;
            // 
            // deltaLabel
            // 
            this.deltaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deltaLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.deltaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deltaLabel.ForeColor = System.Drawing.Color.Green;
            this.deltaLabel.Location = new System.Drawing.Point(44, 137);
            this.deltaLabel.Name = "deltaLabel";
            this.deltaLabel.Size = new System.Drawing.Size(215, 20);
            this.deltaLabel.TabIndex = 13;
            this.deltaLabel.Text = "n/a";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Green;
            this.label17.Location = new System.Drawing.Point(13, 137);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(24, 20);
            this.label17.TabIndex = 12;
            this.label17.Text = "δ:";
            // 
            // gammaLabel
            // 
            this.gammaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gammaLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gammaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gammaLabel.ForeColor = System.Drawing.Color.Green;
            this.gammaLabel.Location = new System.Drawing.Point(44, 113);
            this.gammaLabel.Name = "gammaLabel";
            this.gammaLabel.Size = new System.Drawing.Size(215, 20);
            this.gammaLabel.TabIndex = 11;
            this.gammaLabel.Text = "n/a";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Green;
            this.label14.Location = new System.Drawing.Point(13, 111);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(22, 20);
            this.label14.TabIndex = 10;
            this.label14.Text = "γ:";
            // 
            // alphaToALabel
            // 
            this.alphaToALabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.alphaToALabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.alphaToALabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alphaToALabel.ForeColor = System.Drawing.Color.Green;
            this.alphaToALabel.Location = new System.Drawing.Point(44, 89);
            this.alphaToALabel.Name = "alphaToALabel";
            this.alphaToALabel.Size = new System.Drawing.Size(215, 20);
            this.alphaToALabel.TabIndex = 7;
            this.alphaToALabel.Text = "n/a";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Green;
            this.label13.Location = new System.Drawing.Point(13, 87);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 20);
            this.label13.TabIndex = 6;
            this.label13.Text = "αᵃ:";
            // 
            // aLabel
            // 
            this.aLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.aLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aLabel.ForeColor = System.Drawing.Color.Red;
            this.aLabel.Location = new System.Drawing.Point(44, 65);
            this.aLabel.Name = "aLabel";
            this.aLabel.Size = new System.Drawing.Size(215, 20);
            this.aLabel.TabIndex = 5;
            this.aLabel.Text = "n/a";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(13, 63);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(24, 20);
            this.label12.TabIndex = 4;
            this.label12.Text = "a:";
            // 
            // alphaLabel
            // 
            this.alphaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.alphaLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.alphaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alphaLabel.ForeColor = System.Drawing.Color.Green;
            this.alphaLabel.Location = new System.Drawing.Point(44, 41);
            this.alphaLabel.Name = "alphaLabel";
            this.alphaLabel.Size = new System.Drawing.Size(215, 20);
            this.alphaLabel.TabIndex = 3;
            this.alphaLabel.Text = "n/a";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Green;
            this.label10.Location = new System.Drawing.Point(13, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "α:";
            // 
            // p2Label
            // 
            this.p2Label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.p2Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.p2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2Label.ForeColor = System.Drawing.Color.Green;
            this.p2Label.Location = new System.Drawing.Point(44, 17);
            this.p2Label.Name = "p2Label";
            this.p2Label.Size = new System.Drawing.Size(215, 20);
            this.p2Label.TabIndex = 1;
            this.p2Label.Text = "n/a";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Green;
            this.label9.Location = new System.Drawing.Point(13, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "p:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.masterKeyLabel);
            this.groupBox2.Controls.Add(this.encryptedMasterKeyLabel);
            this.groupBox2.Controls.Add(this.decryptMasterKeyButton);
            this.groupBox2.Controls.Add(this.sendMasterKeyButton);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.encryptMasterKeyButton);
            this.groupBox2.Controls.Add(this.masterKeyTextBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 304);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(681, 191);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Encrypt and Send Symmetric Master Key";
            // 
            // masterKeyLabel
            // 
            this.masterKeyLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.masterKeyLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.masterKeyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.masterKeyLabel.ForeColor = System.Drawing.Color.Red;
            this.masterKeyLabel.Location = new System.Drawing.Point(18, 50);
            this.masterKeyLabel.Name = "masterKeyLabel";
            this.masterKeyLabel.Size = new System.Drawing.Size(476, 20);
            this.masterKeyLabel.TabIndex = 8;
            this.masterKeyLabel.Visible = false;
            // 
            // encryptedMasterKeyLabel
            // 
            this.encryptedMasterKeyLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.encryptedMasterKeyLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.encryptedMasterKeyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encryptedMasterKeyLabel.ForeColor = System.Drawing.Color.Green;
            this.encryptedMasterKeyLabel.Location = new System.Drawing.Point(18, 102);
            this.encryptedMasterKeyLabel.Name = "encryptedMasterKeyLabel";
            this.encryptedMasterKeyLabel.Size = new System.Drawing.Size(476, 20);
            this.encryptedMasterKeyLabel.TabIndex = 7;
            // 
            // decryptMasterKeyButton
            // 
            this.decryptMasterKeyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.decryptMasterKeyButton.Enabled = false;
            this.decryptMasterKeyButton.Location = new System.Drawing.Point(500, 98);
            this.decryptMasterKeyButton.Name = "decryptMasterKeyButton";
            this.decryptMasterKeyButton.Size = new System.Drawing.Size(158, 23);
            this.decryptMasterKeyButton.TabIndex = 6;
            this.decryptMasterKeyButton.Text = "Decrypt Master Key";
            this.decryptMasterKeyButton.UseVisualStyleBackColor = true;
            this.decryptMasterKeyButton.Click += new System.EventHandler(this.decryptMasterKeyButton_Click);
            // 
            // sendMasterKeyButton
            // 
            this.sendMasterKeyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sendMasterKeyButton.Enabled = false;
            this.sendMasterKeyButton.Location = new System.Drawing.Point(500, 149);
            this.sendMasterKeyButton.Name = "sendMasterKeyButton";
            this.sendMasterKeyButton.Size = new System.Drawing.Size(158, 23);
            this.sendMasterKeyButton.TabIndex = 5;
            this.sendMasterKeyButton.Text = "Send Master Key";
            this.sendMasterKeyButton.UseVisualStyleBackColor = true;
            this.sendMasterKeyButton.Click += new System.EventHandler(this.sendMasterKeyButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Encrypted Master Key ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Master Key";
            // 
            // encryptMasterKeyButton
            // 
            this.encryptMasterKeyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.encryptMasterKeyButton.Enabled = false;
            this.encryptMasterKeyButton.Location = new System.Drawing.Point(500, 46);
            this.encryptMasterKeyButton.Name = "encryptMasterKeyButton";
            this.encryptMasterKeyButton.Size = new System.Drawing.Size(158, 23);
            this.encryptMasterKeyButton.TabIndex = 1;
            this.encryptMasterKeyButton.Text = "Encrypt Master Key";
            this.encryptMasterKeyButton.UseVisualStyleBackColor = true;
            this.encryptMasterKeyButton.Click += new System.EventHandler(this.encryptMasterKeyButton_Click);
            // 
            // masterKeyTextBox
            // 
            this.masterKeyTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.masterKeyTextBox.Enabled = false;
            this.masterKeyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.masterKeyTextBox.ForeColor = System.Drawing.Color.Red;
            this.masterKeyTextBox.Location = new System.Drawing.Point(18, 50);
            this.masterKeyTextBox.Name = "masterKeyTextBox";
            this.masterKeyTextBox.Size = new System.Drawing.Size(476, 20);
            this.masterKeyTextBox.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.splitContainer1);
            this.groupBox3.Location = new System.Drawing.Point(12, 502);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(681, 255);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Symmetric Key Communication";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 16);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.clearTextButton);
            this.splitContainer1.Panel1.Controls.Add(this.plainTextTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.encryptPlainTextButton);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.cipherTextLabel);
            this.splitContainer1.Panel2.Controls.Add(this.sendCipherTextButton);
            this.splitContainer1.Panel2.Controls.Add(this.decryptCipherTextButton);
            this.splitContainer1.Size = new System.Drawing.Size(675, 236);
            this.splitContainer1.SplitterDistance = 319;
            this.splitContainer1.TabIndex = 6;
            // 
            // clearTextButton
            // 
            this.clearTextButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clearTextButton.Location = new System.Drawing.Point(18, 201);
            this.clearTextButton.Name = "clearTextButton";
            this.clearTextButton.Size = new System.Drawing.Size(288, 23);
            this.clearTextButton.TabIndex = 2;
            this.clearTextButton.Text = "Clear";
            this.clearTextButton.UseVisualStyleBackColor = true;
            this.clearTextButton.Click += new System.EventHandler(this.clearTextButton_Click);
            // 
            // cipherTextLabel
            // 
            this.cipherTextLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cipherTextLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cipherTextLabel.ForeColor = System.Drawing.Color.Green;
            this.cipherTextLabel.Location = new System.Drawing.Point(18, 24);
            this.cipherTextLabel.Name = "cipherTextLabel";
            this.cipherTextLabel.Size = new System.Drawing.Size(314, 144);
            this.cipherTextLabel.TabIndex = 5;
            // 
            // sendCipherTextButton
            // 
            this.sendCipherTextButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sendCipherTextButton.Enabled = false;
            this.sendCipherTextButton.Location = new System.Drawing.Point(18, 203);
            this.sendCipherTextButton.Name = "sendCipherTextButton";
            this.sendCipherTextButton.Size = new System.Drawing.Size(314, 23);
            this.sendCipherTextButton.TabIndex = 4;
            this.sendCipherTextButton.Text = "Send Cipher Text";
            this.sendCipherTextButton.UseVisualStyleBackColor = true;
            this.sendCipherTextButton.Click += new System.EventHandler(this.sendCipherTextButton_Click);
            // 
            // decryptCipherTextButton
            // 
            this.decryptCipherTextButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.decryptCipherTextButton.Enabled = false;
            this.decryptCipherTextButton.Location = new System.Drawing.Point(18, 174);
            this.decryptCipherTextButton.Name = "decryptCipherTextButton";
            this.decryptCipherTextButton.Size = new System.Drawing.Size(314, 23);
            this.decryptCipherTextButton.TabIndex = 3;
            this.decryptCipherTextButton.Text = "Decrypt Cipher Text";
            this.decryptCipherTextButton.UseVisualStyleBackColor = true;
            this.decryptCipherTextButton.Click += new System.EventHandler(this.decryptCipherTextButton_Click);
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 761);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Location = new System.Drawing.Point(100, 100);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "User";
            this.Text = "User";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.User_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.rsaPanel.ResumeLayout(false);
            this.rsaPanel.PerformLayout();
            this.elGamalPanel.ResumeLayout(false);
            this.elGamalPanel.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox plainTextTextBox;
        private System.Windows.Forms.Button encryptPlainTextButton;
        private System.Windows.Forms.Button requestPublicKeyButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label eLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label nLabel;
        private System.Windows.Forms.Label qLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label pLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label dLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label phiLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button encryptMasterKeyButton;
        private System.Windows.Forms.TextBox masterKeyTextBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button sendMasterKeyButton;
        private System.Windows.Forms.Button decryptMasterKeyButton;
        private System.Windows.Forms.Label encryptedMasterKeyLabel;
        private System.Windows.Forms.Label masterKeyLabel;
        private System.Windows.Forms.Button decryptCipherTextButton;
        private System.Windows.Forms.Button sendCipherTextButton;
        private System.Windows.Forms.Label cipherTextLabel;
        private System.Windows.Forms.Label elapsedTimeLabel;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button clearTextButton;
        private System.Windows.Forms.Label p2Label;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label alphaLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label aLabel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label alphaToALabel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label deltaLabel;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label gammaLabel;
        private System.Windows.Forms.Label label14;
        internal System.Windows.Forms.Panel elGamalPanel;
        internal System.Windows.Forms.Panel rsaPanel;
        private System.Windows.Forms.Panel panel1;
    }
}