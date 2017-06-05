﻿namespace Quiz
{
    partial class Quiz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Quiz));
            this.ExitButton = new System.Windows.Forms.Button();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.QuizQuestionAndGroupBox = new System.Windows.Forms.GroupBox();
            this.Option4 = new System.Windows.Forms.RadioButton();
            this.Option3 = new System.Windows.Forms.RadioButton();
            this.Option2 = new System.Windows.Forms.RadioButton();
            this.Option1 = new System.Windows.Forms.RadioButton();
            this.BackButton = new System.Windows.Forms.Button();
            this.QuizQuestionAndGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(196, 226);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(104, 226);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 23);
            this.SubmitButton.TabIndex = 1;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // QuizQuestionAndGroupBox
            // 
            this.QuizQuestionAndGroupBox.Controls.Add(this.Option4);
            this.QuizQuestionAndGroupBox.Controls.Add(this.Option3);
            this.QuizQuestionAndGroupBox.Controls.Add(this.Option2);
            this.QuizQuestionAndGroupBox.Controls.Add(this.Option1);
            this.QuizQuestionAndGroupBox.Location = new System.Drawing.Point(12, 12);
            this.QuizQuestionAndGroupBox.Name = "QuizQuestionAndGroupBox";
            this.QuizQuestionAndGroupBox.Size = new System.Drawing.Size(260, 208);
            this.QuizQuestionAndGroupBox.TabIndex = 2;
            this.QuizQuestionAndGroupBox.TabStop = false;
            this.QuizQuestionAndGroupBox.Text = "What is another name for trash?";
            // 
            // Option4
            // 
            this.Option4.AutoSize = true;
            this.Option4.Location = new System.Drawing.Point(7, 92);
            this.Option4.Name = "Option4";
            this.Option4.Size = new System.Drawing.Size(76, 17);
            this.Option4.TabIndex = 3;
            this.Option4.TabStop = true;
            this.Option4.Text = "Jacob Tart";
            this.Option4.UseVisualStyleBackColor = true;
            this.Option4.CheckedChanged += new System.EventHandler(this.Option4_CheckedChanged);
            // 
            // Option3
            // 
            this.Option3.AutoSize = true;
            this.Option3.Location = new System.Drawing.Point(7, 68);
            this.Option3.Name = "Option3";
            this.Option3.Size = new System.Drawing.Size(64, 17);
            this.Option3.TabIndex = 2;
            this.Option3.TabStop = true;
            this.Option3.Text = "Rubbish";
            this.Option3.UseVisualStyleBackColor = true;
            // 
            // Option2
            // 
            this.Option2.AutoSize = true;
            this.Option2.Location = new System.Drawing.Point(7, 44);
            this.Option2.Name = "Option2";
            this.Option2.Size = new System.Drawing.Size(61, 17);
            this.Option2.TabIndex = 1;
            this.Option2.TabStop = true;
            this.Option2.Text = "Detritus";
            this.Option2.UseVisualStyleBackColor = true;
            // 
            // Option1
            // 
            this.Option1.AutoSize = true;
            this.Option1.Location = new System.Drawing.Point(7, 20);
            this.Option1.Name = "Option1";
            this.Option1.Size = new System.Drawing.Size(66, 17);
            this.Option1.TabIndex = 0;
            this.Option1.TabStop = true;
            this.Option1.Text = "Garbage";
            this.Option1.UseVisualStyleBackColor = true;
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(12, 226);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 3;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            // 
            // Quiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.QuizQuestionAndGroupBox);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.ExitButton);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Quiz";
            this.Text = "Cheney Public Schools Testing";
            this.Load += new System.EventHandler(this.Quiz_Load);
            this.QuizQuestionAndGroupBox.ResumeLayout(false);
            this.QuizQuestionAndGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.GroupBox QuizQuestionAndGroupBox;
        private System.Windows.Forms.RadioButton Option4;
        private System.Windows.Forms.RadioButton Option3;
        private System.Windows.Forms.RadioButton Option2;
        private System.Windows.Forms.RadioButton Option1;
        private System.Windows.Forms.Button BackButton;
    }
}