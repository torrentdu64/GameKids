namespace GameKids
{
    partial class Game
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
            this.operatorId = new System.Windows.Forms.Label();
            this.number2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.response1 = new System.Windows.Forms.Button();
            this.response2 = new System.Windows.Forms.Button();
            this.response3 = new System.Windows.Forms.Button();
            this.response4 = new System.Windows.Forms.Button();
            this.number1 = new System.Windows.Forms.Label();
            this.test = new System.Windows.Forms.RichTextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // operatorId
            // 
            this.operatorId.AutoSize = true;
            this.operatorId.Location = new System.Drawing.Point(229, 94);
            this.operatorId.Name = "operatorId";
            this.operatorId.Size = new System.Drawing.Size(13, 13);
            this.operatorId.TabIndex = 1;
            this.operatorId.Text = "+";
            this.operatorId.Click += new System.EventHandler(this.label2_Click);
            // 
            // number2
            // 
            this.number2.AutoSize = true;
            this.number2.Location = new System.Drawing.Point(311, 94);
            this.number2.Name = "number2";
            this.number2.Size = new System.Drawing.Size(13, 13);
            this.number2.TabIndex = 2;
            this.number2.Text = "3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(453, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "=";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(537, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "?";
            // 
            // response1
            // 
            this.response1.Location = new System.Drawing.Point(162, 223);
            this.response1.Name = "response1";
            this.response1.Size = new System.Drawing.Size(75, 23);
            this.response1.TabIndex = 5;
            this.response1.Text = "3";
            this.response1.UseVisualStyleBackColor = true;
            this.response1.Click += new System.EventHandler(this.response1_Click);
            // 
            // response2
            // 
            this.response2.Location = new System.Drawing.Point(349, 223);
            this.response2.Name = "response2";
            this.response2.Size = new System.Drawing.Size(75, 23);
            this.response2.TabIndex = 6;
            this.response2.Text = "0";
            this.response2.UseVisualStyleBackColor = true;
            this.response2.Click += new System.EventHandler(this.response2_Click);
            // 
            // response3
            // 
            this.response3.Location = new System.Drawing.Point(162, 313);
            this.response3.Name = "response3";
            this.response3.Size = new System.Drawing.Size(75, 23);
            this.response3.TabIndex = 7;
            this.response3.Text = "6";
            this.response3.UseVisualStyleBackColor = true;
            this.response3.Click += new System.EventHandler(this.response3_Click);
            // 
            // response4
            // 
            this.response4.Location = new System.Drawing.Point(349, 313);
            this.response4.Name = "response4";
            this.response4.Size = new System.Drawing.Size(96, 37);
            this.response4.TabIndex = 8;
            this.response4.Text = "Obi-Wan Kenobi";
            this.response4.UseVisualStyleBackColor = true;
            this.response4.Click += new System.EventHandler(this.response4_Click);
            // 
            // number1
            // 
            this.number1.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
            this.number1.AutoSize = true;
            this.number1.Location = new System.Drawing.Point(122, 94);
            this.number1.Name = "number1";
            this.number1.Size = new System.Drawing.Size(13, 13);
            this.number1.TabIndex = 10;
            this.number1.Text = "3";
            // 
            // test
            // 
            this.test.Location = new System.Drawing.Point(580, 150);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(100, 237);
            this.test.TabIndex = 11;
            this.test.Text = "";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(54, 392);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "btnBack";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.test);
            this.Controls.Add(this.number1);
            this.Controls.Add(this.response4);
            this.Controls.Add(this.response3);
            this.Controls.Add(this.response2);
            this.Controls.Add(this.response1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.number2);
            this.Controls.Add(this.operatorId);
            this.Name = "Game";
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Game_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label operatorId;
        private System.Windows.Forms.Label number2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button response1;
        private System.Windows.Forms.Button response2;
        private System.Windows.Forms.Button response3;
        private System.Windows.Forms.Button response4;
        private System.Windows.Forms.Label number1;
        private System.Windows.Forms.RichTextBox test;
        private System.Windows.Forms.Button btnBack;
    }
}