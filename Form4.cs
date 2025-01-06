using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJE_ÖDEVİ
{
    public partial class Form4 : Form
    {

        private Form2 form2;



        public Form4()
        {
            InitializeComponent();


        }



        private void Timer1_Tick(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            tabControl1.Visible = false;
            tabControl2.Location = new Point(1, 1);

            this.Width = 485;  // Genişlik
            this.Height = 680; // Yükseklik
            tabControl2.Visible = true;
            tabControl2.SelectedTab = tabPage3;
            tabPage3.Text = "";
            tabPage4.Text = "";
            tabControl2.Appearance = TabAppearance.FlatButtons;
            tabControl2.ItemSize = new Size(0, 1);
            tabControl2.SizeMode = TabSizeMode.Fixed;

        }

        private void Form4_Load(object sender, EventArgs e)
        {

            this.Width = 485;  // Genişlik
            this.Height = 680; // Yükseklik
            tabControl1.Visible = true;
            tabPage1.Text = "";
            tabPage2.Text = "";
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;

            textBox5.MaxLength = 16;
            textBox6.MaxLength = 16;

            textBox7.Multiline = true; // Çok satırlı metin
            textBox7.ScrollBars = ScrollBars.Vertical; // Kaydırma çubuğu
            textBox7.ReadOnly = true; // Düzenlemeyi kapat


        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.Visible = true;
            tabControl2.Visible = false;

            this.Width = 485;  // Genişlik
            this.Height = 680; // Yükseklik
            tabControl1.Visible = true;
            tabPage1.Text = "";
            tabPage2.Text = "";
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;

            string girilenAdres = textBox4.Text; // Adres giriş alanından adresi al
            if (!string.IsNullOrWhiteSpace(girilenAdres)) // Eğer adres boş değilse
            {
                textBox1.Text = girilenAdres; // Adresi ana TextBox1'e yaz
                tabControl1.SelectedTab = tabPage1; 
            }
            else
            {
                MessageBox.Show("Lütfen bir adres giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            tabControl1.Visible = false;

            this.Width = 485;  // Genişlik
            this.Height = 680; // Yükseklik
            tabControl2.Visible = true;
            tabControl2.SelectedTab = tabPage4;
            tabPage3.Text = "";
            tabPage4.Text = "";
            tabPage5.Text = "";
            tabControl2.Appearance = TabAppearance.FlatButtons;
            tabControl2.ItemSize = new Size(0, 1);
            tabControl2.SizeMode = TabSizeMode.Fixed;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            string kartNumarasi = textBox5.Text;

            if (kartNumarasi.Length == 16)
            {
                MessageBox.Show("Kart numarası geçerli!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                textBox2.Text = kartNumarasi;
                tabControl1.SelectedTab = tabPage1; 

                tabControl2.Visible = false;


                this.Width = 485;  // Genişlik
                this.Height = 680; // Yükseklik
                tabControl1.Visible = true;
                tabPage1.Text = "";
                tabPage2.Text = "";
                tabControl1.Appearance = TabAppearance.FlatButtons;
                tabControl1.ItemSize = new Size(0, 1);
                tabControl1.SizeMode = TabSizeMode.Fixed;

            }
            else
            {
                MessageBox.Show("Kart numarası 16 haneli olmalıdır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {


            string kartNumarasi = textBox6.Text;

            if (kartNumarasi.Length == 16)
            {
                MessageBox.Show("Kart numarası geçerli!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                textBox3.Text = kartNumarasi;
                tabControl1.SelectedTab = tabPage1; 

                tabControl2.Visible = false;

                this.Width = 485;  
                this.Height = 680; 
                tabControl1.Visible = true;
                tabPage1.Text = "";
                tabPage2.Text = "";
                tabControl1.Appearance = TabAppearance.FlatButtons;
                tabControl1.ItemSize = new Size(0, 1);
                tabControl1.SizeMode = TabSizeMode.Fixed;

            }
            else
            {
                MessageBox.Show("Kart numarası 16 haneli olmalıdır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            // TextBox'un mevcut içeriğini kontrol ediyoruz
            string currentText = textBox5.Text;

            // Sayı olmayan karakterleri kaldırıyoruz
            if (!System.Text.RegularExpressions.Regex.IsMatch(currentText, @"^\d*$"))
            {
                // Sadece sayıları bırak
                textBox5.Text = new string(currentText.Where(char.IsDigit).ToArray());

                
                textBox5.SelectionStart = textBox5.Text.Length;
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            // TextBox'un mevcut içeriğini kontrol ediyoruz
            string currentText = textBox6.Text;

            // Sayı olmayan karakterleri kaldırıyoruz
            if (!System.Text.RegularExpressions.Regex.IsMatch(currentText, @"^\d*$"))
            {
                // Sadece sayıları bırak
                textBox6.Text = new string(currentText.Where(char.IsDigit).ToArray());

              
                textBox6.SelectionStart = textBox6.Text.Length;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            tabControl1.Visible = false;
            tabControl2.Location = new Point(1, 1);

            this.Width = 485;  // Genişlik
            this.Height = 680; // Yükseklik
            tabControl2.Visible = true;
            tabControl2.SelectedTab = tabPage5;
            tabPage3.Text = "";
            tabPage4.Text = "";
            tabPage5.Text = "";
            tabControl2.Appearance = TabAppearance.FlatButtons;
            tabControl2.ItemSize = new Size(0, 1);
            tabControl2.SizeMode = TabSizeMode.Fixed;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tabControl2.Visible = false;


            this.Width = 485;  // Genişlik
            this.Height = 680; // Yükseklik
            tabControl1.Visible = true;
            tabPage1.Text = "";
            tabPage2.Text = "";
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;
        }
        private void pictureBox63_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Sepeti sıfırlamak istiyor musunuz?",
                "Onay",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                
                Form2 form2 = Application.OpenForms["Form2"] as Form2;
                if (form2 != null)
                {
                    form2.ResetAllNumericUpDowns(this); 
                }
            }

       
            this.Hide();
            Form2 form2ToShow = Application.OpenForms["Form2"] as Form2;
            form2ToShow?.Show();
        }


        private void pictureBox8_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show(
         "Sepeti sıfırlamak istiyor musunuz?",
         "Onay",
         MessageBoxButtons.YesNo,
         MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
             
                Form2 form2 = Application.OpenForms["Form2"] as Form2;
                if (form2 != null)
                {
                    form2.ResetAllNumericUpDowns(); 
                }
            }

            // Form2'ye geri dön
            this.Hide();
            Form2 form2ToShow = Application.OpenForms["Form2"] as Form2;
            form2ToShow?.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // RadioButton1 veya RadioButton2 kontrolü yaptım
            if (!radioButton1.Checked && !radioButton2.Checked)
            {
               
                MessageBox.Show("Lütfen adres yöntemlerinden birini seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Durdur
            }

            if (!checkBox1.Checked)
            {
                MessageBox.Show("Lütfen Koşulları Onaylayınız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           
            if (!radioButton3.Checked && !radioButton4.Checked)
            {
                // Uyarı mesajı göster
                MessageBox.Show("Lütfen Kart numaralarından birini seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }


            Form2 form2 = Application.OpenForms["Form2"] as Form2;

            if (form2 != null)
            {
                // Tab8'i aç
                form2.SetActiveTab(7);

                form2.tabPage8_Enter(null, EventArgs.Empty); // Bu satır önemli, tabPage8'e geçildiğinde çalışacak


                
                //burada form2deki timer'i başlatma vardı ama sildim


                // Kart numarasını al
                string cardNumber = textBox2.Text.Trim();


                if (cardNumber.Length == 16)
                {
                    // Maskelenmiş kart numarasını oluşturuyor
                    string maskedCardNumber = new string('*', 12) + cardNumber.Substring(12);

                    // Maskelenmiş kart numarasını Form2'deki label59'a yazdim
                    form2.UpdateLabel(maskedCardNumber);
                }
                else
                {
                    MessageBox.Show("Lütfen 16 haneli bir kart numarası girin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

             
                this.Hide();
                form2.Show();
            }
            else
            {
                MessageBox.Show("Form2 açık değil.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // TextBox doluysa RadioButton'u seç
            if (!string.IsNullOrWhiteSpace(textBox2.Text))
            {
                radioButton3.Checked = true; // RadioButton'unuzun ismi
            }
            else
            {
                radioButton3.Checked = false; // TextBox boşsa RadioButton seçimini kaldır
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
