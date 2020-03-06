namespace GameKids
{
    partial class HomePage
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
            this.button1 = new System.Windows.Forms.Button();
            this.inputUserName = new System.Windows.Forms.TextBox();
            this.inputPassword = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(178, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 57);
            this.button1.TabIndex = 0;
            this.button1.Text = "Sign In";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // inputUserName
            // 
            this.inputUserName.Location = new System.Drawing.Point(187, 121);
            this.inputUserName.Name = "inputUserName";
            this.inputUserName.Size = new System.Drawing.Size(100, 20);
            this.inputUserName.TabIndex = 1;
            this.inputUserName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // inputPassword
            // 
            this.inputPassword.Location = new System.Drawing.Point(187, 196);
            this.inputPassword.Name = "inputPassword";
            this.inputPassword.Size = new System.Drawing.Size(100, 20);
            this.inputPassword.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(520, 174);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 62);
            this.button2.TabIndex = 3;
            this.button2.Text = "Sign Up";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Passworld";
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.inputPassword);
            this.Controls.Add(this.inputUserName);
            this.Controls.Add(this.button1);
            this.Name = "HomePage";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox inputUserName;
        private System.Windows.Forms.TextBox inputPassword;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

