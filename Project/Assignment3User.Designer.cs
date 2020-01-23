namespace Project
{
    partial class Assignment3User
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sendCipherTextButton = new System.Windows.Forms.Button();
            this.decryptButton = new System.Windows.Forms.Button();
            this.encryptButton = new System.Windows.Forms.Button();
            this.cipherTextLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.plainTextTextBox = new System.Windows.Forms.TextBox();
            this.requestOtherUsersPublicKeyButton = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.otherUsersAlphaToALabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.otherUsersAlphaLabel = new System.Windows.Forms.Label();
            this.otherUsersPLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.generateKeysButton = new System.Windows.Forms.Button();
            this.deltaLabel = new System.Windows.Forms.Label();
            this.pLabel = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.gammaLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.alphaLabel = new System.Windows.Forms.Label();
            this.alphaToALabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.aLabel = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.sendCipherTextButton);
            this.groupBox2.Controls.Add(this.decryptButton);
            this.groupBox2.Controls.Add(this.encryptButton);
            this.groupBox2.Controls.Add(this.cipherTextLabel);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.plainTextTextBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 399);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(681, 191);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Encrypt and Send Plain Text";
            // 
            // sendCipherTextButton
            // 
            this.sendCipherTextButton.Location = new System.Drawing.Point(318, 139);
            this.sendCipherTextButton.Name = "sendCipherTextButton";
            this.sendCipherTextButton.Size = new System.Drawing.Size(145, 23);
            this.sendCipherTextButton.TabIndex = 11;
            this.sendCipherTextButton.Text = "Send Cipher Text";
            this.sendCipherTextButton.UseVisualStyleBackColor = true;
            this.sendCipherTextButton.Click += new System.EventHandler(this.sendCipherTextButton_Click);
            // 
            // decryptButton
            // 
            this.decryptButton.Location = new System.Drawing.Point(168, 139);
            this.decryptButton.Name = "decryptButton";
            this.decryptButton.Size = new System.Drawing.Size(145, 23);
            this.decryptButton.TabIndex = 10;
            this.decryptButton.Text = "Decrypt";
            this.decryptButton.UseVisualStyleBackColor = true;
            this.decryptButton.Click += new System.EventHandler(this.decryptButton_Click);
            // 
            // encryptButton
            // 
            this.encryptButton.Location = new System.Drawing.Point(17, 139);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(145, 23);
            this.encryptButton.TabIndex = 9;
            this.encryptButton.Text = "Encrypt";
            this.encryptButton.UseVisualStyleBackColor = true;
            this.encryptButton.Click += new System.EventHandler(this.encryptButton_Click);
            // 
            // cipherTextLabel
            // 
            this.cipherTextLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cipherTextLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cipherTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cipherTextLabel.ForeColor = System.Drawing.Color.Green;
            this.cipherTextLabel.Location = new System.Drawing.Point(18, 102);
            this.cipherTextLabel.Name = "cipherTextLabel";
            this.cipherTextLabel.Size = new System.Drawing.Size(476, 20);
            this.cipherTextLabel.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Cipher Text";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Plain Text";
            // 
            // plainTextTextBox
            // 
            this.plainTextTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.plainTextTextBox.Enabled = false;
            this.plainTextTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plainTextTextBox.ForeColor = System.Drawing.Color.Red;
            this.plainTextTextBox.Location = new System.Drawing.Point(18, 50);
            this.plainTextTextBox.Name = "plainTextTextBox";
            this.plainTextTextBox.Size = new System.Drawing.Size(476, 20);
            this.plainTextTextBox.TabIndex = 0;
            // 
            // requestOtherUsersPublicKeyButton
            // 
            this.requestOtherUsersPublicKeyButton.Location = new System.Drawing.Point(50, 104);
            this.requestOtherUsersPublicKeyButton.Name = "requestOtherUsersPublicKeyButton";
            this.requestOtherUsersPublicKeyButton.Size = new System.Drawing.Size(228, 23);
            this.requestOtherUsersPublicKeyButton.TabIndex = 4;
            this.requestOtherUsersPublicKeyButton.Text = "Request Other Users Public Key";
            this.requestOtherUsersPublicKeyButton.UseVisualStyleBackColor = true;
            this.requestOtherUsersPublicKeyButton.Click += new System.EventHandler(this.requestOtherUsersPublicKeyButton_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.otherUsersAlphaToALabel);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.otherUsersAlphaLabel);
            this.groupBox4.Controls.Add(this.otherUsersPLabel);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.requestOtherUsersPublicKeyButton);
            this.groupBox4.Location = new System.Drawing.Point(12, 243);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(681, 150);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Other Users Public Key";
            // 
            // otherUsersAlphaToALabel
            // 
            this.otherUsersAlphaToALabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.otherUsersAlphaToALabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.otherUsersAlphaToALabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otherUsersAlphaToALabel.ForeColor = System.Drawing.Color.Green;
            this.otherUsersAlphaToALabel.Location = new System.Drawing.Point(50, 72);
            this.otherUsersAlphaToALabel.Name = "otherUsersAlphaToALabel";
            this.otherUsersAlphaToALabel.Size = new System.Drawing.Size(584, 20);
            this.otherUsersAlphaToALabel.TabIndex = 10;
            this.otherUsersAlphaToALabel.Text = "n/a";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Green;
            this.label6.Location = new System.Drawing.Point(19, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "αᵃ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(19, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "α:";
            // 
            // otherUsersAlphaLabel
            // 
            this.otherUsersAlphaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.otherUsersAlphaLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.otherUsersAlphaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otherUsersAlphaLabel.ForeColor = System.Drawing.Color.Green;
            this.otherUsersAlphaLabel.Location = new System.Drawing.Point(50, 47);
            this.otherUsersAlphaLabel.Name = "otherUsersAlphaLabel";
            this.otherUsersAlphaLabel.Size = new System.Drawing.Size(584, 20);
            this.otherUsersAlphaLabel.TabIndex = 8;
            this.otherUsersAlphaLabel.Text = "n/a";
            // 
            // otherUsersPLabel
            // 
            this.otherUsersPLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.otherUsersPLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.otherUsersPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otherUsersPLabel.ForeColor = System.Drawing.Color.Green;
            this.otherUsersPLabel.Location = new System.Drawing.Point(50, 23);
            this.otherUsersPLabel.Name = "otherUsersPLabel";
            this.otherUsersPLabel.Size = new System.Drawing.Size(584, 20);
            this.otherUsersPLabel.TabIndex = 6;
            this.otherUsersPLabel.Text = "n/a";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(19, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "p:";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.generateKeysButton);
            this.groupBox3.Controls.Add(this.deltaLabel);
            this.groupBox3.Controls.Add(this.pLabel);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.gammaLabel);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.alphaLabel);
            this.groupBox3.Controls.Add(this.alphaToALabel);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.aLabel);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(681, 216);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "My Keys";
            // 
            // generateKeysButton
            // 
            this.generateKeysButton.Location = new System.Drawing.Point(50, 177);
            this.generateKeysButton.Name = "generateKeysButton";
            this.generateKeysButton.Size = new System.Drawing.Size(228, 23);
            this.generateKeysButton.TabIndex = 14;
            this.generateKeysButton.Text = "Generate My Keys";
            this.generateKeysButton.UseVisualStyleBackColor = true;
            this.generateKeysButton.Click += new System.EventHandler(this.generateKeysButton_Click);
            // 
            // deltaLabel
            // 
            this.deltaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deltaLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.deltaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deltaLabel.ForeColor = System.Drawing.Color.Green;
            this.deltaLabel.Location = new System.Drawing.Point(50, 145);
            this.deltaLabel.Name = "deltaLabel";
            this.deltaLabel.Size = new System.Drawing.Size(625, 20);
            this.deltaLabel.TabIndex = 13;
            this.deltaLabel.Text = "n/a";
            // 
            // pLabel
            // 
            this.pLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pLabel.ForeColor = System.Drawing.Color.Green;
            this.pLabel.Location = new System.Drawing.Point(50, 25);
            this.pLabel.Name = "pLabel";
            this.pLabel.Size = new System.Drawing.Size(625, 20);
            this.pLabel.TabIndex = 1;
            this.pLabel.Text = "n/a";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Green;
            this.label17.Location = new System.Drawing.Point(19, 145);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(24, 20);
            this.label17.TabIndex = 12;
            this.label17.Text = "δ:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Green;
            this.label9.Location = new System.Drawing.Point(19, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "p:";
            // 
            // gammaLabel
            // 
            this.gammaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gammaLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gammaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gammaLabel.ForeColor = System.Drawing.Color.Green;
            this.gammaLabel.Location = new System.Drawing.Point(50, 121);
            this.gammaLabel.Name = "gammaLabel";
            this.gammaLabel.Size = new System.Drawing.Size(625, 20);
            this.gammaLabel.TabIndex = 11;
            this.gammaLabel.Text = "n/a";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Green;
            this.label10.Location = new System.Drawing.Point(19, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "α:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Green;
            this.label14.Location = new System.Drawing.Point(19, 119);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(22, 20);
            this.label14.TabIndex = 10;
            this.label14.Text = "γ:";
            // 
            // alphaLabel
            // 
            this.alphaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.alphaLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.alphaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alphaLabel.ForeColor = System.Drawing.Color.Green;
            this.alphaLabel.Location = new System.Drawing.Point(50, 49);
            this.alphaLabel.Name = "alphaLabel";
            this.alphaLabel.Size = new System.Drawing.Size(625, 20);
            this.alphaLabel.TabIndex = 3;
            this.alphaLabel.Text = "n/a";
            // 
            // alphaToALabel
            // 
            this.alphaToALabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.alphaToALabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.alphaToALabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alphaToALabel.ForeColor = System.Drawing.Color.Green;
            this.alphaToALabel.Location = new System.Drawing.Point(50, 97);
            this.alphaToALabel.Name = "alphaToALabel";
            this.alphaToALabel.Size = new System.Drawing.Size(625, 20);
            this.alphaToALabel.TabIndex = 7;
            this.alphaToALabel.Text = "n/a";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(19, 71);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(24, 20);
            this.label12.TabIndex = 4;
            this.label12.Text = "a:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Green;
            this.label13.Location = new System.Drawing.Point(19, 95);
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
            this.aLabel.Location = new System.Drawing.Point(50, 73);
            this.aLabel.Name = "aLabel";
            this.aLabel.Size = new System.Drawing.Size(625, 20);
            this.aLabel.TabIndex = 5;
            this.aLabel.Text = "n/a";
            // 
            // Assignment3User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 649);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Location = new System.Drawing.Point(100, 100);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Assignment3User";
            this.Text = "Assignment3User";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Assignment3User_FormClosing);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox plainTextTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label cipherTextLabel;
        private System.Windows.Forms.Button requestOtherUsersPublicKeyButton;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label otherUsersAlphaToALabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label otherUsersAlphaLabel;
        private System.Windows.Forms.Label otherUsersPLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label deltaLabel;
        private System.Windows.Forms.Label pLabel;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label gammaLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label alphaLabel;
        private System.Windows.Forms.Label alphaToALabel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label aLabel;
        private System.Windows.Forms.Button generateKeysButton;
        private System.Windows.Forms.Button decryptButton;
        private System.Windows.Forms.Button encryptButton;
        private System.Windows.Forms.Button sendCipherTextButton;
    }
}