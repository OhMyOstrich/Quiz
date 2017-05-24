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
            this.CreateQuizButton.Location = new System.Drawing.Point(236, 217);
            this.CreateQuizButton.Name = "CreateQuizButton";
            this.CreateQuizButton.Size = new System.Drawing.Size(75, 23);
            this.CreateQuizButton.TabIndex = 2;
            this.CreateQuizButton.Text = "Create";
            this.CreateQuizButton.UseVisualStyleBackColor = true;
            this.CreateQuizButton.Click += new System.EventHandler(this.CreateQuizButton_Click);
            // 
            // CreateQuizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 452);
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
    }
}