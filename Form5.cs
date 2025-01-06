using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJE_ÖDEVİ
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            string ad = textBox1.Text;
            string sifre = textBox2.Text;



            if (ad == "Esma" && sifre == "123") // kullanıcı girisi icin,
            {
                Form2 form2 = new Form2();
                form2.Show();
                form2.tabControl2.SelectedTab = form2.tabPage11;

                this.Hide();


            }


            else
            {
                label5.Text = "Yanlış kullanıcı adı veya şifre, yeniden deneyin.";
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void MakePictureBoxCircular(PictureBox pictureBox)  // bazı pictureboxları kare yerine yuvarlak yapmak icin kullandık
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, pictureBox.Width, pictureBox.Height);
            pictureBox.Region = new Region(path);
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            MakePictureBoxCircular(pictureBox2);
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
