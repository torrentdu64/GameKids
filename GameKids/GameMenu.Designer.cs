﻿namespace GameKids
{
    partial class GameMenu
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
            this.addition = new System.Windows.Forms.Button();
            this.subtraction = new System.Windows.Forms.Button();
            this.multiplication = new System.Windows.Forms.Button();
            this.divition = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.labelUserName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addition
            // 
            this.addition.Location = new System.Drawing.Point(278, 154);
            this.addition.Name = "addition";
            this.addition.Size = new System.Drawing.Size(75, 23);
            this.addition.TabIndex = 0;
            this.addition.Text = "+";
            this.addition.UseVisualStyleBackColor = true;
            this.addition.Click += new System.EventHandler(this.button1_Click);
            // 
            // subtraction
            // 
            this.subtraction.Location = new System.Drawing.Point(419, 154);
            this.subtraction.Name = "subtraction";
            this.subtraction.Size = new System.Drawing.Size(75, 23);
            this.subtraction.TabIndex = 1;
            this.subtraction.Text = "-";
            this.subtraction.UseVisualStyleBackColor = true;
            this.subtraction.Click += new System.EventHandler(this.button2_Click);
            // 
            // multiplication
            // 
            this.multiplication.Location = new System.Drawing.Point(278, 299);
            this.multiplication.Name = "multiplication";
            this.multiplication.Size = new System.Drawing.Size(75, 23);
            this.multiplication.TabIndex = 2;
            this.multiplication.Text = "*";
            this.multiplication.UseVisualStyleBackColor = true;
            this.multiplication.Click += new System.EventHandler(this.multiplication_Click);
            // 
            // divition
            // 
            this.divition.Location = new System.Drawing.Point(419, 299);
            this.divition.Name = "divition";
            this.divition.Size = new System.Drawing.Size(75, 23);
            this.divition.TabIndex = 3;
            this.divition.Text = "/";
            this.divition.UseVisualStyleBackColor = true;
            this.divition.Click += new System.EventHandler(this.divition_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(605, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "exit";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // labelUserName
            // 
            this.labelUserName.AccessibleName = "username";
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(278, 72);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(53, 13);
            this.labelUserName.TabIndex = 5;
            this.labelUserName.Text = "username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(241, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Hello";
            // 
            // GameMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.divition);
            this.Controls.Add(this.multiplication);
            this.Controls.Add(this.subtraction);
            this.Controls.Add(this.addition);
            this.Name = "GameMenu";
            this.Text = "GameMenu";
            this.Load += new System.EventHandler(this.GameMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addition;
        private System.Windows.Forms.Button subtraction;
        private System.Windows.Forms.Button multiplication;
        private System.Windows.Forms.Button divition;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label label1;
    }
}