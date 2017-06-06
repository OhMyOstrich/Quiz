namespace Quiz
{
    partial class QuestionForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuestionForm));
            this.questionBox1 = new System.Windows.Forms.CheckBox();
            this.questionBox2 = new System.Windows.Forms.CheckBox();
            this.questionBox3 = new System.Windows.Forms.CheckBox();
            this.questionBox4 = new System.Windows.Forms.CheckBox();
            this.questionLabel = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.answerButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // questionBox1
            // 
            this.questionBox1.AutoSize = true;
            this.questionBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionBox1.Location = new System.Drawing.Point(12, 68);
            this.questionBox1.Name = "questionBox1";
            this.questionBox1.Size = new System.Drawing.Size(88, 22);
            this.questionBox1.TabIndex = 0;
            this.questionBox1.Text = "Answer 1";
            this.questionBox1.UseVisualStyleBackColor = true;
            this.questionBox1.CheckedChanged += new System.EventHandler(this.questionBox1_CheckedChanged);
            // 
            // questionBox2
            // 
            this.questionBox2.AutoSize = true;
            this.questionBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionBox2.Location = new System.Drawing.Point(12, 96);
            this.questionBox2.Name = "questionBox2";
            this.questionBox2.Size = new System.Drawing.Size(88, 22);
            this.questionBox2.TabIndex = 0;
            this.questionBox2.Text = "Answer 2";
            this.questionBox2.UseVisualStyleBackColor = true;
            this.questionBox2.CheckedChanged += new System.EventHandler(this.questionBox2_CheckedChanged);
            // 
            // questionBox3
            // 
            this.questionBox3.AutoSize = true;
            this.questionBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionBox3.Location = new System.Drawing.Point(12, 124);
            this.questionBox3.Name = "questionBox3";
            this.questionBox3.Size = new System.Drawing.Size(88, 22);
            this.questionBox3.TabIndex = 0;
            this.questionBox3.Text = "Answer 3";
            this.questionBox3.UseVisualStyleBackColor = true;
            this.questionBox3.CheckedChanged += new System.EventHandler(this.questionBox3_CheckedChanged);
            // 
            // questionBox4
            // 
            this.questionBox4.AutoSize = true;
            this.questionBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionBox4.Location = new System.Drawing.Point(12, 152);
            this.questionBox4.Name = "questionBox4";
            this.questionBox4.Size = new System.Drawing.Size(88, 22);
            this.questionBox4.TabIndex = 0;
            this.questionBox4.Text = "Answer 4";
            this.questionBox4.UseVisualStyleBackColor = true;
            this.questionBox4.CheckedChanged += new System.EventHandler(this.questionBox4_CheckedChanged);
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLabel.Location = new System.Drawing.Point(9, 9);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(73, 20);
            this.questionLabel.TabIndex = 1;
            this.questionLabel.Text = "Question";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // answerButton
            // 
            this.answerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerButton.Location = new System.Drawing.Point(12, 180);
            this.answerButton.Name = "answerButton";
            this.answerButton.Size = new System.Drawing.Size(698, 37);
            this.answerButton.TabIndex = 2;
            this.answerButton.Text = "Submit";
            this.answerButton.UseVisualStyleBackColor = true;
            this.answerButton.Click += new System.EventHandler(this.answerButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(675, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // QuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 229);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.answerButton);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.questionBox4);
            this.Controls.Add(this.questionBox3);
            this.Controls.Add(this.questionBox2);
            this.Controls.Add(this.questionBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "QuestionForm";
            this.Text = "Question #";
            this.Load += new System.EventHandler(this.QuestionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox questionBox1;
        private System.Windows.Forms.CheckBox questionBox2;
        private System.Windows.Forms.CheckBox questionBox3;
        private System.Windows.Forms.CheckBox questionBox4;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button answerButton;
        private System.Windows.Forms.Label label1;
    }
}