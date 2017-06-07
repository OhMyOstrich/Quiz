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
            this.FinishButton = new System.Windows.Forms.Button();
            this.QuizSubjectTB = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.CountButton = new System.Windows.Forms.Button();
            this.QuestionsListBox = new System.Windows.Forms.ListBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Answer1Box = new System.Windows.Forms.RichTextBox();
            this.Answer2Box = new System.Windows.Forms.RichTextBox();
            this.Answer3Box = new System.Windows.Forms.RichTextBox();
            this.Answer4Box = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Answer1Check = new System.Windows.Forms.CheckBox();
            this.Answer2Check = new System.Windows.Forms.CheckBox();
            this.Answer3Check = new System.Windows.Forms.CheckBox();
            this.Answer4Check = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // QuizNameTB
            // 
            this.QuizNameTB.Location = new System.Drawing.Point(103, 23);
            this.QuizNameTB.Name = "QuizNameTB";
            this.QuizNameTB.Size = new System.Drawing.Size(237, 20);
            this.QuizNameTB.TabIndex = 0;
            // 
            // FinishButton
            // 
            this.FinishButton.Location = new System.Drawing.Point(380, 646);
            this.FinishButton.Name = "FinishButton";
            this.FinishButton.Size = new System.Drawing.Size(75, 23);
            this.FinishButton.TabIndex = 15;
            this.FinishButton.Text = "Finish";
            this.FinishButton.UseVisualStyleBackColor = true;
            this.FinishButton.Click += new System.EventHandler(this.FinishButton_Click);
            // 
            // QuizSubjectTB
            // 
            this.QuizSubjectTB.Location = new System.Drawing.Point(103, 51);
            this.QuizSubjectTB.Name = "QuizSubjectTB";
            this.QuizSubjectTB.Size = new System.Drawing.Size(237, 20);
            this.QuizSubjectTB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Quiz Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Quiz Subject:";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(20, 646);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 12;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(127, 646);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 13;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // CountButton
            // 
            this.CountButton.Location = new System.Drawing.Point(234, 646);
            this.CountButton.Name = "CountButton";
            this.CountButton.Size = new System.Drawing.Size(75, 23);
            this.CountButton.TabIndex = 14;
            this.CountButton.Text = "Count";
            this.CountButton.UseVisualStyleBackColor = true;
            this.CountButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // QuestionsListBox
            // 
            this.QuestionsListBox.FormattingEnabled = true;
            this.QuestionsListBox.Location = new System.Drawing.Point(380, 10);
            this.QuestionsListBox.Name = "QuestionsListBox";
            this.QuestionsListBox.Size = new System.Drawing.Size(416, 602);
            this.QuestionsListBox.TabIndex = 11;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Location = new System.Drawing.Point(29, 102);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(311, 102);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // Answer1Box
            // 
            this.Answer1Box.Location = new System.Drawing.Point(93, 214);
            this.Answer1Box.Name = "Answer1Box";
            this.Answer1Box.Size = new System.Drawing.Size(247, 90);
            this.Answer1Box.TabIndex = 4;
            this.Answer1Box.Text = "";
            // 
            // Answer2Box
            // 
            this.Answer2Box.Location = new System.Drawing.Point(93, 320);
            this.Answer2Box.Name = "Answer2Box";
            this.Answer2Box.Size = new System.Drawing.Size(247, 90);
            this.Answer2Box.TabIndex = 6;
            this.Answer2Box.Text = "";
            // 
            // Answer3Box
            // 
            this.Answer3Box.Location = new System.Drawing.Point(93, 426);
            this.Answer3Box.Name = "Answer3Box";
            this.Answer3Box.Size = new System.Drawing.Size(247, 84);
            this.Answer3Box.TabIndex = 8;
            this.Answer3Box.Text = "";
            // 
            // Answer4Box
            // 
            this.Answer4Box.Location = new System.Drawing.Point(93, 526);
            this.Answer4Box.Name = "Answer4Box";
            this.Answer4Box.Size = new System.Drawing.Size(247, 90);
            this.Answer4Box.TabIndex = 10;
            this.Answer4Box.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 15);
            this.label7.TabIndex = 25;
            this.label7.Text = "Question Text:";
            // 
            // Answer1Check
            // 
            this.Answer1Check.AutoSize = true;
            this.Answer1Check.Location = new System.Drawing.Point(20, 218);
            this.Answer1Check.Name = "Answer1Check";
            this.Answer1Check.Size = new System.Drawing.Size(73, 17);
            this.Answer1Check.TabIndex = 3;
            this.Answer1Check.Text = "Answer 1:";
            this.Answer1Check.UseVisualStyleBackColor = true;
            // 
            // Answer2Check
            // 
            this.Answer2Check.AutoSize = true;
            this.Answer2Check.Location = new System.Drawing.Point(20, 323);
            this.Answer2Check.Name = "Answer2Check";
            this.Answer2Check.Size = new System.Drawing.Size(73, 17);
            this.Answer2Check.TabIndex = 5;
            this.Answer2Check.Text = "Answer 2:";
            this.Answer2Check.UseVisualStyleBackColor = true;
            // 
            // Answer3Check
            // 
            this.Answer3Check.AutoSize = true;
            this.Answer3Check.Location = new System.Drawing.Point(20, 428);
            this.Answer3Check.Name = "Answer3Check";
            this.Answer3Check.Size = new System.Drawing.Size(73, 17);
            this.Answer3Check.TabIndex = 7;
            this.Answer3Check.Text = "Answer 3:";
            this.Answer3Check.UseVisualStyleBackColor = true;
            // 
            // Answer4Check
            // 
            this.Answer4Check.AutoSize = true;
            this.Answer4Check.Location = new System.Drawing.Point(20, 533);
            this.Answer4Check.Name = "Answer4Check";
            this.Answer4Check.Size = new System.Drawing.Size(73, 17);
            this.Answer4Check.TabIndex = 9;
            this.Answer4Check.Text = "Answer 4:";
            this.Answer4Check.UseVisualStyleBackColor = true;
            // 
            // CreateQuizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 687);
            this.Controls.Add(this.Answer4Check);
            this.Controls.Add(this.Answer3Check);
            this.Controls.Add(this.Answer2Check);
            this.Controls.Add(this.Answer1Check);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Answer4Box);
            this.Controls.Add(this.Answer3Box);
            this.Controls.Add(this.Answer2Box);
            this.Controls.Add(this.Answer1Box);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.QuestionsListBox);
            this.Controls.Add(this.CountButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.QuizSubjectTB);
            this.Controls.Add(this.FinishButton);
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
        private System.Windows.Forms.Button FinishButton;
        private System.Windows.Forms.MaskedTextBox QuizSubjectTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button CountButton;
        private System.Windows.Forms.ListBox QuestionsListBox;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox Answer1Box;
        private System.Windows.Forms.RichTextBox Answer2Box;
        private System.Windows.Forms.RichTextBox Answer3Box;
        private System.Windows.Forms.RichTextBox Answer4Box;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox Answer1Check;
        private System.Windows.Forms.CheckBox Answer2Check;
        private System.Windows.Forms.CheckBox Answer3Check;
        private System.Windows.Forms.CheckBox Answer4Check;
    }
}