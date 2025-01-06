using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PROJE_ÖDEVİ
{
    public partial class Form3 : Form
    {


        public Form3()
        {
            InitializeComponent();

        }







        private void Form3_Load(object sender, EventArgs e)
        {
            tabPage1.Text = "";
            tabPage2.Text = "";


        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            form2.tabControl2.Visible = false;
            this.Hide();
            return;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();

        }

        private void label5_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
         
            string currentText = textBox3.Text;

            // Sayı olmayan karakterleri kaldır
            if (!System.Text.RegularExpressions.Regex.IsMatch(currentText, @"^\d*$"))
            {
                // Sadece sayıları bırak
                textBox3.Text = new string(currentText.Where(char.IsDigit).ToArray());

                // İmleci sona taşımak için yazdım
                textBox3.SelectionStart = textBox3.Text.Length;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            // TextBox'un mevcut içeriğini kontrol et
            string currentText = textBox4.Text;

            // Sadece harfler, @ ve . işaretlerini bırak
            if (!System.Text.RegularExpressions.Regex.IsMatch(currentText, @"^[a-zA-Z@.]*$"))
            {
                // Sadece geçerli karakterleri bırak
                textBox4.Text = new string(currentText.Where(c => "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ@.".Contains(c)).ToArray());

              
                textBox4.SelectionStart = textBox4.Text.Length;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            {
               
                DialogResult result = MessageBox.Show( "Kaydetmediniz. Gerçekten çıkmak istiyor musunuz?","Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    tabControl1.SelectedTab = tabPage1;
                 
                    textBox1.Clear();
                    textBox2.Clear();

                    textBox3.Clear();
                    textBox4.Clear();
                 

                }
                else if (result == DialogResult.No)
                {
                    tabControl1.SelectedTab = tabPage1;
                }

            }
            
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string telefonno = textBox3.Text;

            if (telefonno.Length == 11)
            {
                MessageBox.Show("Telefon numarası geçerli!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                textBox2.Text = telefonno;
                tabControl1.SelectedTab = tabPage1;


            }
            else
            {
                MessageBox.Show("Telefon numarası 0 dahil olmak üzere 11 rakamdan oluşmalı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            string eposta = textBox4.Text;

            textBox1.Text = eposta;
            tabControl1.SelectedTab = tabPage1;




        }


    }
}
