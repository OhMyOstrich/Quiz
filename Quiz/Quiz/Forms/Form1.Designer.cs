namespace Quiz
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.TakeQuiz = new System.Windows.Forms.Button();
            this.TempQuestionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Azure;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(0, 367);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(426, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Create Quiz";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TakeQuiz
            // 
            this.TakeQuiz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TakeQuiz.Dock = System.Windows.Forms.DockStyle.Top;
            this.TakeQuiz.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TakeQuiz.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.TakeQuiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TakeQuiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.TakeQuiz.Location = new System.Drawing.Point(0, 0);
            this.TakeQuiz.Name = "TakeQuiz";
            this.TakeQuiz.Size = new System.Drawing.Size(426, 78);
            this.TakeQuiz.TabIndex = 1;
            this.TakeQuiz.Text = "Take Quiz";
            this.TakeQuiz.UseVisualStyleBackColor = true;
            this.TakeQuiz.Click += new System.EventHandler(this.TakeQuiz_Click);
            // 
            // TempQuestionButton
            // 
            this.TempQuestionButton.Location = new System.Drawing.Point(0, 288);
            this.TempQuestionButton.Name = "TempQuestionButton";
            this.TempQuestionButton.Size = new System.Drawing.Size(426, 71);
            this.TempQuestionButton.TabIndex = 2;
            this.TempQuestionButton.Text = "Question?";
            this.TempQuestionButton.UseVisualStyleBackColor = true;
            this.TempQuestionButton.Click += new System.EventHandler(this.TempQuestionButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(426, 402);
            this.Controls.Add(this.TempQuestionButton);
            this.Controls.Add(this.TakeQuiz);
            this.Controls.Add(this.button1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cheney Public Schools Testing";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button TakeQuiz;
        private System.Windows.Forms.Button TempQuestionButton;
    }
}

