namespace LibraryManagementSystem
{
    partial class FormLogIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogIN));
            buttonGiris = new Button();
            textBoxKullanici = new TextBox();
            label1 = new Label();
            textBoxSifre = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // buttonGiris
            // 
            buttonGiris.BackColor = SystemColors.ButtonFace;
            buttonGiris.Location = new Point(272, 245);
            buttonGiris.Name = "buttonGiris";
            buttonGiris.Size = new Size(116, 39);
            buttonGiris.TabIndex = 0;
            buttonGiris.Text = "GİRİŞ";
            buttonGiris.UseVisualStyleBackColor = false;
            buttonGiris.Click += buttonGiris_Click;
            // 
            // textBoxKullanici
            // 
            textBoxKullanici.Location = new Point(207, 63);
            textBoxKullanici.Name = "textBoxKullanici";
            textBoxKullanici.Size = new Size(239, 35);
            textBoxKullanici.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(207, 23);
            label1.Name = "label1";
            label1.Size = new Size(155, 28);
            label1.TabIndex = 2;
            label1.Text = "Kullanıcı Adı:";
            // 
            // textBoxSifre
            // 
            textBoxSifre.Location = new Point(207, 179);
            textBoxSifre.Name = "textBoxSifre";
            textBoxSifre.Size = new Size(239, 35);
            textBoxSifre.TabIndex = 3;
            textBoxSifre.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(207, 139);
            label2.Name = "label2";
            label2.Size = new Size(69, 28);
            label2.TabIndex = 4;
            label2.Text = "Şifre:";
            // 
            // FormLogIN
            // 
            AutoScaleDimensions = new SizeF(14F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(637, 423);
            Controls.Add(label2);
            Controls.Add(textBoxSifre);
            Controls.Add(label1);
            Controls.Add(textBoxKullanici);
            Controls.Add(buttonGiris);
            Font = new Font("Siemens AD Sans", 14F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormLogIN";
            Text = "User Screen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonGiris;
        private TextBox textBoxKullanici;
        private Label label1;
        private TextBox textBoxSifre;
        private Label label2;
    }
}
