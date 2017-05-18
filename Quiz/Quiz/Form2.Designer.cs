namespace Quiz
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.questionBox1 = new System.Windows.Forms.CheckBox();
            this.questionBox2 = new System.Windows.Forms.CheckBox();
            this.questionBox3 = new System.Windows.Forms.CheckBox();
            this.questionBox4 = new System.Windows.Forms.CheckBox();
            this.questionLabel = new System.Windows.Forms.Label();
            this.imageLabel = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // questionBox1
            // 
            this.questionBox1.AutoSize = true;
            this.questionBox1.Location = new System.Drawing.Point(12, 168);
            this.questionBox1.Name = "questionBox1";
            this.questionBox1.Size = new System.Drawing.Size(70, 17);
            this.questionBox1.TabIndex = 0;
            this.questionBox1.Text = "Answer 1";
            this.questionBox1.UseVisualStyleBackColor = true;
            // 
            // questionBox2
            // 
            this.questionBox2.AutoSize = true;
            this.questionBox2.Location = new System.Drawing.Point(12, 191);
            this.questionBox2.Name = "questionBox2";
            this.questionBox2.Size = new System.Drawing.Size(70, 17);
            this.questionBox2.TabIndex = 0;
            this.questionBox2.Text = "Answer 2";
            this.questionBox2.UseVisualStyleBackColor = true;
            // 
            // questionBox3
            // 
            this.questionBox3.AutoSize = true;
            this.questionBox3.Location = new System.Drawing.Point(12, 214);
            this.questionBox3.Name = "questionBox3";
            this.questionBox3.Size = new System.Drawing.Size(70, 17);
            this.questionBox3.TabIndex = 0;
            this.questionBox3.Text = "Answer 3";
            this.questionBox3.UseVisualStyleBackColor = true;
            // 
            // questionBox4
            // 
            this.questionBox4.AutoSize = true;
            this.questionBox4.Location = new System.Drawing.Point(12, 237);
            this.questionBox4.Name = "questionBox4";
            this.questionBox4.Size = new System.Drawing.Size(70, 17);
            this.questionBox4.TabIndex = 0;
            this.questionBox4.Text = "Answer 4";
            this.questionBox4.UseVisualStyleBackColor = true;
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Location = new System.Drawing.Point(9, 9);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(49, 13);
            this.questionLabel.TabIndex = 1;
            this.questionLabel.Text = "Question";
            // 
            // imageLabel
            // 
            this.imageLabel.AutoSize = true;
            this.imageLabel.Image = ((System.Drawing.Image)(resources.GetObject("imageLabel.Image")));
            this.imageLabel.Location = new System.Drawing.Point(12, 69);
            this.imageLabel.Name = "imageLabel";
            this.imageLabel.Size = new System.Drawing.Size(0, 13);
            this.imageLabel.TabIndex = 2;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(204, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 196);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 266);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.imageLabel);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.questionBox4);
            this.Controls.Add(this.questionBox3);
            this.Controls.Add(this.questionBox2);
            this.Controls.Add(this.questionBox1);
            this.Name = "Form2";
            this.Text = "Cancer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox questionBox1;
        private System.Windows.Forms.CheckBox questionBox2;
        private System.Windows.Forms.CheckBox questionBox3;
        private System.Windows.Forms.CheckBox questionBox4;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Label imageLabel;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}