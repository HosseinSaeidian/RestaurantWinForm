
namespace customer_club.UserControlSubscription
{
    partial class PageOneSubscriptionUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PageOneSubscriptionUserControl));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CopyTheCodeButton = new System.Windows.Forms.Button();
            this.CodeSubTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.LastNameSubTextBox = new System.Windows.Forms.TextBox();
            this.FirstNameSubTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PhoneNumberTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CreateAccountButton = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.CopiedCheckBox = new System.Windows.Forms.CheckBox();
            this.CopiedLable = new System.Windows.Forms.Label();
            this.ErrorForTextBox = new System.Windows.Forms.ErrorProvider(this.components);
            this.GetCodeButton = new System.Windows.Forms.Button();
            this.DataGrideSubscription = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorForTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrideSubscription)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(285, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(648, 535);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 118;
            this.pictureBox1.TabStop = false;
            // 
            // CopyTheCodeButton
            // 
            this.CopyTheCodeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(45)))), ((int)(((byte)(212)))));
            this.CopyTheCodeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CopyTheCodeButton.Font = new System.Drawing.Font("Failed Attempt", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CopyTheCodeButton.ForeColor = System.Drawing.Color.White;
            this.CopyTheCodeButton.Location = new System.Drawing.Point(635, 525);
            this.CopyTheCodeButton.Name = "CopyTheCodeButton";
            this.CopyTheCodeButton.Size = new System.Drawing.Size(219, 44);
            this.CopyTheCodeButton.TabIndex = 6;
            this.CopyTheCodeButton.Text = "Copy the code";
            this.CopyTheCodeButton.UseVisualStyleBackColor = false;
            this.CopyTheCodeButton.Click += new System.EventHandler(this.CopyTheCodeButton_Click);
            // 
            // CodeSubTextBox
            // 
            this.CodeSubTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.CodeSubTextBox.Font = new System.Drawing.Font("hooge 05_54", 18F);
            this.CodeSubTextBox.Location = new System.Drawing.Point(307, 526);
            this.CodeSubTextBox.Multiline = true;
            this.CodeSubTextBox.Name = "CodeSubTextBox";
            this.CodeSubTextBox.Size = new System.Drawing.Size(322, 44);
            this.CodeSubTextBox.TabIndex = 119;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(248)))), ((int)(((byte)(254)))));
            this.label6.Font = new System.Drawing.Font("Dima Shekasteh Free", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(361, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(330, 77);
            this.label6.TabIndex = 122;
            this.label6.Text = "Enter your LastName :\r\n";
            // 
            // LastNameSubTextBox
            // 
            this.LastNameSubTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.LastNameSubTextBox.Font = new System.Drawing.Font("Droid Serif", 18F);
            this.LastNameSubTextBox.Location = new System.Drawing.Point(374, 99);
            this.LastNameSubTextBox.Multiline = true;
            this.LastNameSubTextBox.Name = "LastNameSubTextBox";
            this.LastNameSubTextBox.Size = new System.Drawing.Size(307, 44);
            this.LastNameSubTextBox.TabIndex = 1;
            // 
            // FirstNameSubTextBox
            // 
            this.FirstNameSubTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.FirstNameSubTextBox.Font = new System.Drawing.Font("Droid Serif", 18F);
            this.FirstNameSubTextBox.Location = new System.Drawing.Point(19, 99);
            this.FirstNameSubTextBox.Multiline = true;
            this.FirstNameSubTextBox.Name = "FirstNameSubTextBox";
            this.FirstNameSubTextBox.Size = new System.Drawing.Size(307, 44);
            this.FirstNameSubTextBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(248)))), ((int)(((byte)(254)))));
            this.label2.Font = new System.Drawing.Font("Dima Shekasteh Free", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(341, 77);
            this.label2.TabIndex = 124;
            this.label2.Text = "Enter your FirstName :";
            // 
            // PhoneNumberTextbox
            // 
            this.PhoneNumberTextbox.BackColor = System.Drawing.SystemColors.Window;
            this.PhoneNumberTextbox.Font = new System.Drawing.Font("Droid Serif", 18F);
            this.PhoneNumberTextbox.Location = new System.Drawing.Point(743, 99);
            this.PhoneNumberTextbox.Multiline = true;
            this.PhoneNumberTextbox.Name = "PhoneNumberTextbox";
            this.PhoneNumberTextbox.Size = new System.Drawing.Size(307, 44);
            this.PhoneNumberTextbox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(248)))), ((int)(((byte)(254)))));
            this.label1.Font = new System.Drawing.Font("Dima Shekasteh Free", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(697, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 77);
            this.label1.TabIndex = 126;
            this.label1.Text = "Enter your PhoneNumber:\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(248)))), ((int)(((byte)(254)))));
            this.label3.Font = new System.Drawing.Font("Dima Shekasteh Free", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(6, 513);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(286, 66);
            this.label3.TabIndex = 128;
            this.label3.Text = "Your subscription code :";
            // 
            // CreateAccountButton
            // 
            this.CreateAccountButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(45)))), ((int)(((byte)(212)))));
            this.CreateAccountButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateAccountButton.Font = new System.Drawing.Font("Failed Attempt", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateAccountButton.ForeColor = System.Drawing.Color.White;
            this.CreateAccountButton.Location = new System.Drawing.Point(17, 172);
            this.CreateAccountButton.Name = "CreateAccountButton";
            this.CreateAccountButton.Size = new System.Drawing.Size(248, 86);
            this.CreateAccountButton.TabIndex = 3;
            this.CreateAccountButton.Text = "Create Account";
            this.CreateAccountButton.UseVisualStyleBackColor = false;
            this.CreateAccountButton.Click += new System.EventHandler(this.CreateAccountButton_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(45)))), ((int)(((byte)(212)))));
            this.RefreshButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RefreshButton.Font = new System.Drawing.Font("Failed Attempt", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshButton.ForeColor = System.Drawing.Color.White;
            this.RefreshButton.Location = new System.Drawing.Point(19, 396);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(248, 75);
            this.RefreshButton.TabIndex = 5;
            this.RefreshButton.Text = "Restart";
            this.RefreshButton.UseVisualStyleBackColor = false;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // CopiedCheckBox
            // 
            this.CopiedCheckBox.AutoSize = true;
            this.CopiedCheckBox.BackColor = System.Drawing.Color.White;
            this.CopiedCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.CopiedCheckBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CopiedCheckBox.Location = new System.Drawing.Point(508, 576);
            this.CopiedCheckBox.Name = "CopiedCheckBox";
            this.CopiedCheckBox.Size = new System.Drawing.Size(18, 17);
            this.CopiedCheckBox.TabIndex = 131;
            this.CopiedCheckBox.UseVisualStyleBackColor = false;
            // 
            // CopiedLable
            // 
            this.CopiedLable.AutoSize = true;
            this.CopiedLable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(248)))), ((int)(((byte)(254)))));
            this.CopiedLable.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.CopiedLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.CopiedLable.Location = new System.Drawing.Point(528, 571);
            this.CopiedLable.Name = "CopiedLable";
            this.CopiedLable.Size = new System.Drawing.Size(92, 29);
            this.CopiedLable.TabIndex = 132;
            this.CopiedLable.Text = "Copied";
            // 
            // ErrorForTextBox
            // 
            this.ErrorForTextBox.ContainerControl = this;
            // 
            // GetCodeButton
            // 
            this.GetCodeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(45)))), ((int)(((byte)(212)))));
            this.GetCodeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GetCodeButton.Font = new System.Drawing.Font("Failed Attempt", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetCodeButton.ForeColor = System.Drawing.Color.White;
            this.GetCodeButton.Location = new System.Drawing.Point(17, 287);
            this.GetCodeButton.Name = "GetCodeButton";
            this.GetCodeButton.Size = new System.Drawing.Size(248, 79);
            this.GetCodeButton.TabIndex = 4;
            this.GetCodeButton.Text = "Get Code";
            this.GetCodeButton.UseVisualStyleBackColor = false;
            this.GetCodeButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // DataGrideSubscription
            // 
            this.DataGrideSubscription.AllowUserToAddRows = false;
            this.DataGrideSubscription.AllowUserToDeleteRows = false;
            this.DataGrideSubscription.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrideSubscription.Location = new System.Drawing.Point(860, 524);
            this.DataGrideSubscription.Name = "DataGrideSubscription";
            this.DataGrideSubscription.ReadOnly = true;
            this.DataGrideSubscription.RowHeadersWidth = 51;
            this.DataGrideSubscription.RowTemplate.Height = 24;
            this.DataGrideSubscription.Size = new System.Drawing.Size(47, 44);
            this.DataGrideSubscription.TabIndex = 133;
            // 
            // PageOneSubscriptionUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DataGrideSubscription);
            this.Controls.Add(this.GetCodeButton);
            this.Controls.Add(this.CopiedLable);
            this.Controls.Add(this.CopiedCheckBox);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.CreateAccountButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PhoneNumberTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FirstNameSubTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LastNameSubTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CopyTheCodeButton);
            this.Controls.Add(this.CodeSubTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Name = "PageOneSubscriptionUserControl";
            this.Size = new System.Drawing.Size(1077, 616);
            this.Load += new System.EventHandler(this.UserControlSubscription_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorForTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrideSubscription)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button CopyTheCodeButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CreateAccountButton;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Label CopiedLable;
        private System.Windows.Forms.ErrorProvider ErrorForTextBox;
        private System.Windows.Forms.Button GetCodeButton;
        public System.Windows.Forms.TextBox FirstNameSubTextBox;
        public System.Windows.Forms.TextBox LastNameSubTextBox;
        public System.Windows.Forms.TextBox PhoneNumberTextbox;
        public System.Windows.Forms.DataGridView DataGrideSubscription;
        public System.Windows.Forms.TextBox CodeSubTextBox;
        public System.Windows.Forms.CheckBox CopiedCheckBox;
    }
}
