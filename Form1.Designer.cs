namespace Composition
{
    partial class FormHeli
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHeli));
            button1 = new Button();
            pictureBox1 = new PictureBox();
            richTextBox1 = new RichTextBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 174);
            button1.Name = "button1";
            button1.Size = new Size(240, 51);
            button1.TabIndex = 0;
            button1.Text = "MOTOR ÇALIŞSIN";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(670, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(243, 165);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 255);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(936, 165);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // button2
            // 
            button2.Location = new Point(310, 174);
            button2.Name = "button2";
            button2.Size = new Size(251, 51);
            button2.TabIndex = 3;
            button2.Text = "MOTOR DURDURULSUN";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 432);
            Controls.Add(button2);
            Controls.Add(richTextBox1);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Font = new Font("Siemens AD Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Helicopter Control Tab";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private PictureBox pictureBox1;
        private RichTextBox richTextBox1;
        private Button button2;
    }
}
