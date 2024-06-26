namespace HandshakeProject
{
    partial class handshakeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(handshakeForm));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.uploadHandshakeBrowseBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.networkName = new System.Windows.Forms.TextBox();
            this.uploadWordlistBrowseBtn = new System.Windows.Forms.Button();
            this.browseHandshakeFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.browseWordlistFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.findPassBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.networkPassword = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.openSavedNtwrkBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.createWordlistBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pasteBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(56, 214);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Upload your Handshake";
            this.label2.Click += new System.EventHandler(this.handshakeUpload_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(56, 127);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Upload your Worldlist";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(61, 252);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(241, 26);
            this.textBox2.TabIndex = 3;
            // 
            // uploadHandshakeBrowseBtn
            // 
            this.uploadHandshakeBrowseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadHandshakeBrowseBtn.Location = new System.Drawing.Point(320, 250);
            this.uploadHandshakeBrowseBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uploadHandshakeBrowseBtn.Name = "uploadHandshakeBrowseBtn";
            this.uploadHandshakeBrowseBtn.Size = new System.Drawing.Size(81, 26);
            this.uploadHandshakeBrowseBtn.TabIndex = 4;
            this.uploadHandshakeBrowseBtn.Text = "Browse";
            this.uploadHandshakeBrowseBtn.UseVisualStyleBackColor = true;
            this.uploadHandshakeBrowseBtn.Click += new System.EventHandler(this.uploadBrowseBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(479, 127);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter Network name";
            // 
            // networkName
            // 
            this.networkName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.networkName.Location = new System.Drawing.Point(484, 167);
            this.networkName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.networkName.Name = "networkName";
            this.networkName.Size = new System.Drawing.Size(230, 26);
            this.networkName.TabIndex = 7;
            // 
            // uploadWordlistBrowseBtn
            // 
            this.uploadWordlistBrowseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadWordlistBrowseBtn.Location = new System.Drawing.Point(320, 163);
            this.uploadWordlistBrowseBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uploadWordlistBrowseBtn.Name = "uploadWordlistBrowseBtn";
            this.uploadWordlistBrowseBtn.Size = new System.Drawing.Size(81, 26);
            this.uploadWordlistBrowseBtn.TabIndex = 8;
            this.uploadWordlistBrowseBtn.Text = "Browse";
            this.uploadWordlistBrowseBtn.UseVisualStyleBackColor = true;
            this.uploadWordlistBrowseBtn.Click += new System.EventHandler(this.uploadWordlistBrowseBtn_Click);
            // 
            // browseHandshakeFileDialog
            // 
            this.browseHandshakeFileDialog.FileName = "browseHandshakeFileDialog";
            // 
            // browseWordlistFileDialog
            // 
            this.browseWordlistFileDialog.FileName = "browseWordlistFileDialog";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(61, 165);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(241, 26);
            this.textBox3.TabIndex = 9;
            // 
            // findPassBtn
            // 
            this.findPassBtn.BackColor = System.Drawing.Color.Transparent;
            this.findPassBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findPassBtn.ForeColor = System.Drawing.Color.Black;
            this.findPassBtn.Location = new System.Drawing.Point(61, 306);
            this.findPassBtn.Name = "findPassBtn";
            this.findPassBtn.Size = new System.Drawing.Size(150, 46);
            this.findPassBtn.TabIndex = 10;
            this.findPassBtn.Text = "Find Password";
            this.findPassBtn.UseVisualStyleBackColor = false;
            this.findPassBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(479, 214);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(286, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Enter Password (If Found)";
            // 
            // networkPassword
            // 
            this.networkPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.networkPassword.Location = new System.Drawing.Point(484, 254);
            this.networkPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.networkPassword.Name = "networkPassword";
            this.networkPassword.Size = new System.Drawing.Size(230, 26);
            this.networkPassword.TabIndex = 12;
            this.networkPassword.TextChanged += new System.EventHandler(this.networkPassword_TextChanged);
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(484, 306);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(100, 46);
            this.saveBtn.TabIndex = 13;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // openSavedNtwrkBtn
            // 
            this.openSavedNtwrkBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openSavedNtwrkBtn.Location = new System.Drawing.Point(607, 306);
            this.openSavedNtwrkBtn.Name = "openSavedNtwrkBtn";
            this.openSavedNtwrkBtn.Size = new System.Drawing.Size(106, 46);
            this.openSavedNtwrkBtn.TabIndex = 14;
            this.openSavedNtwrkBtn.Text = "Show Saved Networks";
            this.openSavedNtwrkBtn.UseVisualStyleBackColor = true;
            this.openSavedNtwrkBtn.Click += new System.EventHandler(this.openSavedNtwrkBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(278, 380);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(339, 36);
            this.label5.TabIndex = 15;
            this.label5.Text = "Don\'t have a wordlist ?\r";
            // 
            // createWordlistBtn
            // 
            this.createWordlistBtn.BackColor = System.Drawing.Color.Transparent;
            this.createWordlistBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createWordlistBtn.ForeColor = System.Drawing.Color.Black;
            this.createWordlistBtn.Location = new System.Drawing.Point(380, 428);
            this.createWordlistBtn.Name = "createWordlistBtn";
            this.createWordlistBtn.Size = new System.Drawing.Size(101, 56);
            this.createWordlistBtn.TabIndex = 16;
            this.createWordlistBtn.Text = "Create Wordlist";
            this.createWordlistBtn.UseVisualStyleBackColor = false;
            this.createWordlistBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(466, 76);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(351, 37);
            this.label6.TabIndex = 17;
            this.label6.Text = "Save Your Network(s)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(46, 76);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(370, 37);
            this.label7.TabIndex = 18;
            this.label7.Text = "Crack Your Handshake";
            // 
            // pasteBtn
            // 
            this.pasteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pasteBtn.Location = new System.Drawing.Point(724, 252);
            this.pasteBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pasteBtn.Name = "pasteBtn";
            this.pasteBtn.Size = new System.Drawing.Size(77, 27);
            this.pasteBtn.TabIndex = 19;
            this.pasteBtn.Text = "Paste";
            this.pasteBtn.UseVisualStyleBackColor = true;
            this.pasteBtn.Click += new System.EventHandler(this.pasteBtn_Click);
            // 
            // handshakeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(849, 538);
            this.Controls.Add(this.pasteBtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.createWordlistBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.openSavedNtwrkBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.networkPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.findPassBtn);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.uploadWordlistBrowseBtn);
            this.Controls.Add(this.networkName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uploadHandshakeBrowseBtn);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "handshakeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Handshake";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button uploadHandshakeBrowseBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox networkName;
        private System.Windows.Forms.Button uploadWordlistBrowseBtn;
        private System.Windows.Forms.OpenFileDialog browseHandshakeFileDialog;
        private System.Windows.Forms.OpenFileDialog browseWordlistFileDialog;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button findPassBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox networkPassword;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button openSavedNtwrkBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button createWordlistBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button pasteBtn;
    }
}

