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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.QuestionListBox = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // QuizNameTB
            // 
            this.QuizNameTB.Location = new System.Drawing.Point(103, 33);
            this.QuizNameTB.Name = "QuizNameTB";
            this.QuizNameTB.Size = new System.Drawing.Size(100, 20);
            this.QuizNameTB.TabIndex = 1;
            // 
            // CreateQuizButton
            // 
            this.CreateQuizButton.Location = new System.Drawing.Point(233, 334);
            this.CreateQuizButton.Name = "CreateQuizButton";
            this.CreateQuizButton.Size = new System.Drawing.Size(75, 23);
            this.CreateQuizButton.TabIndex = 2;
            this.CreateQuizButton.Text = "Finish";
            this.CreateQuizButton.UseVisualStyleBackColor = true;
            this.CreateQuizButton.Click += new System.EventHandler(this.CreateQuizButton_Click);
            // 
            // QuizSubjectTB
            // 
            this.QuizSubjectTB.Location = new System.Drawing.Point(103, 70);
            this.QuizSubjectTB.Name = "QuizSubjectTB";
            this.QuizSubjectTB.Size = new System.Drawing.Size(100, 20);
            this.QuizSubjectTB.TabIndex = 3;
            this.QuizSubjectTB.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.QuizSubjectTB_MaskInputRejected);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Quiz Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Quiz Subject:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(233, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(233, 238);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(233, 267);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Count";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // QuestionListBox
            // 
            this.QuestionListBox.FormattingEnabled = true;
            this.QuestionListBox.Location = new System.Drawing.Point(341, 33);
            this.QuestionListBox.Name = "QuestionListBox";
            this.QuestionListBox.Size = new System.Drawing.Size(227, 303);
            this.QuestionListBox.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(121, 211);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 12;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(121, 237);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 13;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(121, 263);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 14;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(121, 289);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 15;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(29, 149);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(192, 56);
            this.richTextBox1.TabIndex = 16;
            this.richTextBox1.Text = "";
            // 
            // CreateQuizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 452);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.QuestionListBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox QuestionListBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}