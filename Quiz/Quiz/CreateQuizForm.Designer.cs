namespace Quiz {
    partial class CreateQuizForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.QuizNameTB = new System.Windows.Forms.MaskedTextBox();
            this.CreateQuizButton = new System.Windows.Forms.Button();
            this.QuizSubjectTB = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // QuizNameTB
            // 
            this.QuizNameTB.Location = new System.Drawing.Point(222, 149);
            this.QuizNameTB.Name = "QuizNameTB";
            this.QuizNameTB.Size = new System.Drawing.Size(100, 20);
            this.QuizNameTB.TabIndex = 1;
            // 
            // CreateQuizButton
            // 
            this.CreateQuizButton.Location = new System.Drawing.Point(222, 269);
            this.CreateQuizButton.Name = "CreateQuizButton";
            this.CreateQuizButton.Size = new System.Drawing.Size(75, 23);
            this.CreateQuizButton.TabIndex = 2;
            this.CreateQuizButton.Text = "Create";
            this.CreateQuizButton.UseVisualStyleBackColor = true;
            this.CreateQuizButton.Click += new System.EventHandler(this.CreateQuizButton_Click);
            // 
            // QuizSubjectTB
            // 
            this.QuizSubjectTB.Location = new System.Drawing.Point(222, 228);
            this.QuizSubjectTB.Name = "QuizSubjectTB";
            this.QuizSubjectTB.Size = new System.Drawing.Size(100, 20);
            this.QuizSubjectTB.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(158, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Subject:";
            // 
            // CreateQuizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 452);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.QuizSubjectTB);
            this.Controls.Add(this.CreateQuizButton);
            this.Controls.Add(this.QuizNameTB);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateQuizForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Create Quiz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox QuizNameTB;
        private System.Windows.Forms.Button CreateQuizButton;
        private System.Windows.Forms.MaskedTextBox QuizSubjectTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}