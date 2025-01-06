namespace PROJE_ÖDEVİ
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            button2 = new Button();
            label3 = new Label();
            button1 = new Button();
            textBox2 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(474, 663);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(51, 191);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(359, 438);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Khaki;
            button2.FlatAppearance.BorderColor = Color.Snow;
            button2.FlatAppearance.BorderSize = 3;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 0, 3);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 0, 3);
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            button2.Location = new Point(13, 371);
            button2.Name = "button2";
            button2.Size = new Size(324, 45);
            button2.TabIndex = 6;
            button2.Text = "Yönetici Girişi";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = Color.Red;
            label3.Location = new Point(21, 348);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = Color.Gold;
            button1.FlatAppearance.BorderColor = Color.Snow;
            button1.FlatAppearance.BorderSize = 3;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 0, 3);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 0, 3);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            button1.Location = new Point(13, 294);
            button1.Name = "button1";
            button1.Size = new Size(324, 45);
            button1.TabIndex = 4;
            button1.Text = "Giriş Yap";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(112, 220);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(219, 31);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label2.Location = new Point(48, 228);
            label2.Name = "label2";
            label2.Size = new Size(58, 23);
            label2.TabIndex = 2;
            label2.Text = "Şifre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label1.Location = new Point(6, 115);
            label1.Name = "label1";
            label1.Size = new Size(115, 21);
            label1.TabIndex = 1;
            label1.Text = "Kullanıcı Adı:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(113, 102);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(218, 34);
            textBox1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(181, 156);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(95, 98);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Khaki;
            label4.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(28, 118);
            label4.Name = "label4";
            label4.Size = new Size(412, 25);
            label4.TabIndex = 7;
            label4.Text = "TULİP MARKET KULLANICI GİRİŞİ";
            label4.Click += label4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(474, 663);
            Controls.Add(label4);
            Controls.Add(pictureBox2);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private PictureBox pictureBox2;
        private TextBox textBox2;
        private Label label2;
        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Label label3;
        private Button button2;
        private Label label4;
    }
}
