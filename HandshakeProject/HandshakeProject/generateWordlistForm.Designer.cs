namespace HandshakeProject
{
    partial class generateWordlistForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(generateWordlistForm));
            this.label1 = new System.Windows.Forms.Label();
            this.passwordLength = new System.Windows.Forms.NumericUpDown();
            this.numbersCheckbox = new System.Windows.Forms.CheckBox();
            this.lowercaseCheckbox = new System.Windows.Forms.CheckBox();
            this.uppercaseCheckbox = new System.Windows.Forms.CheckBox();
            this.ponctuationCheckbox = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.wordlistLength = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.passwordLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wordlistLength)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(60, 121);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose Password Length";
            // 
            // passwordLength
            // 
            this.passwordLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLength.Location = new System.Drawing.Point(65, 174);
            this.passwordLength.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.passwordLength.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.passwordLength.Name = "passwordLength";
            this.passwordLength.Size = new System.Drawing.Size(93, 32);
            this.passwordLength.TabIndex = 5;
            this.passwordLength.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.passwordLength.ValueChanged += new System.EventHandler(this.passwordLength_ValueChanged);
            // 
            // numbersCheckbox
            // 
            this.numbersCheckbox.AutoSize = true;
            this.numbersCheckbox.BackColor = System.Drawing.Color.Transparent;
            this.numbersCheckbox.Checked = true;
            this.numbersCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.numbersCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numbersCheckbox.ForeColor = System.Drawing.Color.White;
            this.numbersCheckbox.Location = new System.Drawing.Point(460, 115);
            this.numbersCheckbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numbersCheckbox.Name = "numbersCheckbox";
            this.numbersCheckbox.Size = new System.Drawing.Size(238, 35);
            this.numbersCheckbox.TabIndex = 6;
            this.numbersCheckbox.Text = "Include Numbers";
            this.numbersCheckbox.UseVisualStyleBackColor = false;
            // 
            // lowercaseCheckbox
            // 
            this.lowercaseCheckbox.AutoSize = true;
            this.lowercaseCheckbox.BackColor = System.Drawing.Color.Transparent;
            this.lowercaseCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lowercaseCheckbox.ForeColor = System.Drawing.Color.White;
            this.lowercaseCheckbox.Location = new System.Drawing.Point(460, 172);
            this.lowercaseCheckbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lowercaseCheckbox.Name = "lowercaseCheckbox";
            this.lowercaseCheckbox.Size = new System.Drawing.Size(351, 35);
            this.lowercaseCheckbox.TabIndex = 7;
            this.lowercaseCheckbox.Text = "Include Lowercase Letters";
            this.lowercaseCheckbox.UseVisualStyleBackColor = false;
            // 
            // uppercaseCheckbox
            // 
            this.uppercaseCheckbox.AutoSize = true;
            this.uppercaseCheckbox.BackColor = System.Drawing.Color.Transparent;
            this.uppercaseCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uppercaseCheckbox.ForeColor = System.Drawing.Color.White;
            this.uppercaseCheckbox.Location = new System.Drawing.Point(460, 228);
            this.uppercaseCheckbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uppercaseCheckbox.Name = "uppercaseCheckbox";
            this.uppercaseCheckbox.Size = new System.Drawing.Size(351, 35);
            this.uppercaseCheckbox.TabIndex = 8;
            this.uppercaseCheckbox.Text = "Include Uppercase Letters";
            this.uppercaseCheckbox.UseVisualStyleBackColor = false;
            // 
            // ponctuationCheckbox
            // 
            this.ponctuationCheckbox.AutoSize = true;
            this.ponctuationCheckbox.BackColor = System.Drawing.Color.Transparent;
            this.ponctuationCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ponctuationCheckbox.ForeColor = System.Drawing.Color.White;
            this.ponctuationCheckbox.Location = new System.Drawing.Point(460, 284);
            this.ponctuationCheckbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ponctuationCheckbox.Name = "ponctuationCheckbox";
            this.ponctuationCheckbox.Size = new System.Drawing.Size(286, 35);
            this.ponctuationCheckbox.TabIndex = 9;
            this.ponctuationCheckbox.Text = "Include Ponctuations";
            this.ponctuationCheckbox.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(302, 375);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 47);
            this.button1.TabIndex = 10;
            this.button1.Text = "Generate Wordlist";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(61, 223);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(348, 31);
            this.label2.TabIndex = 11;
            this.label2.Text = "Choose Number of Words";
            // 
            // wordlistLength
            // 
            this.wordlistLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordlistLength.Location = new System.Drawing.Point(65, 278);
            this.wordlistLength.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.wordlistLength.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.wordlistLength.Name = "wordlistLength";
            this.wordlistLength.Size = new System.Drawing.Size(156, 32);
            this.wordlistLength.TabIndex = 12;
            this.wordlistLength.Value = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            // 
            // generateWordlistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(849, 538);
            this.Controls.Add(this.wordlistLength);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ponctuationCheckbox);
            this.Controls.Add(this.uppercaseCheckbox);
            this.Controls.Add(this.lowercaseCheckbox);
            this.Controls.Add(this.numbersCheckbox);
            this.Controls.Add(this.passwordLength);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "generateWordlistForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wordlist Generator";
            this.Load += new System.EventHandler(this.generateWordlist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.passwordLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wordlistLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown passwordLength;
        private System.Windows.Forms.CheckBox numbersCheckbox;
        private System.Windows.Forms.CheckBox lowercaseCheckbox;
        private System.Windows.Forms.CheckBox uppercaseCheckbox;
        private System.Windows.Forms.CheckBox ponctuationCheckbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown wordlistLength;
    }
}