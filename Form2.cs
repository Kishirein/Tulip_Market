using System;
using System.Collections.Generic;
using System.Drawing;
using System.Security.Policy;
using System.Windows.Forms;
using Microsoft.Win32.SafeHandles;
using PROJE_ÖDEVİ;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PROJE_ÖDEVİ
{
    
    public partial class Form2 : Form
    {

        


        public Form2()
        {
            InitializeComponent();



            //indirimli ürünlerin fiyatlarını üstü çizili yapmak icin kullandık

            label10.Font = new Font(label1.Font, FontStyle.Strikeout);
            label11.Font = new Font(label1.Font, FontStyle.Strikeout);
            label12.Font = new Font(label1.Font, FontStyle.Strikeout);


        }




        public void tabPage8_Enter(object sender, EventArgs e)
        {

            timer1.Start();


        }


        private int saniye = 120;


         


        public void SetActiveTab(int tabIndex)
        {

            if (tabControl1 != null && tabIndex >= 0 && tabIndex < tabControl1.TabCount) // gecisler icin kullandık
            {
                tabControl1.SelectedIndex = tabIndex;
            }

        }

     


        public void UpdateLabel(string maskedText)
        {
            label59.Text = maskedText; //kart numarasının son 4 hanesi dısındakileri gizledik
        }



        public void ResetAllNumericUpDowns(Control parentControl)
        {  // bu kısmı alışveriş seçimleri iptal edildiğinde numericupdownları sıfırlamak icin yazdık
            foreach (Control ctrl in parentControl.Controls)
            {
                if (ctrl is NumericUpDown numericUpDown)
                {
                    numericUpDown4.Value = 0;
                    numericUpDown5.Value = 0;
                    numericUpDown6.Value = 0;
                    numericUpDown7.Value = 0;
                    numericUpDown8.Value = 0;
                    numericUpDown9.Value = 0;
                    numericUpDown10.Value = 0;
                    numericUpDown11.Value = 0;
                    numericUpDown12.Value = 0;
                    numericUpDown13.Value = 0;
                    numericUpDown14.Value = 0;
                    numericUpDown15.Value = 0;
                    numericUpDown16.Value = 0;
                    numericUpDown17.Value = 0;
                    numericUpDown18.Value = 0;
                    numericUpDown19.Value = 0;
                    numericUpDown20.Value = 0;
                    numericUpDown21.Value = 0;
                    numericUpDown22.Value = 0;
                    numericUpDown23.Value = 0;
                    numericUpDown24.Value = 0;
                    numericUpDown25.Value = 0;
                    numericUpDown26.Value = 0;
                    numericUpDown27.Value = 0;

                }
                else if (ctrl.Controls.Count > 0)
                {
                    ResetAllNumericUpDowns(ctrl);
                    numericUpDown4.Value = 0;
                    numericUpDown5.Value = 0;
                    numericUpDown6.Value = 0;
                    numericUpDown7.Value = 0;
                    numericUpDown8.Value = 0;
                    numericUpDown9.Value = 0;
                    numericUpDown10.Value = 0;
                    numericUpDown11.Value = 0;
                    numericUpDown12.Value = 0;
                    numericUpDown13.Value = 0;
                    numericUpDown14.Value = 0;
                    numericUpDown15.Value = 0;
                    numericUpDown16.Value = 0;
                    numericUpDown17.Value = 0;
                    numericUpDown18.Value = 0;
                    numericUpDown19.Value = 0;
                    numericUpDown20.Value = 0;
                    numericUpDown21.Value = 0;
                    numericUpDown22.Value = 0;
                    numericUpDown23.Value = 0;
                    numericUpDown24.Value = 0;
                    numericUpDown25.Value = 0;
                    numericUpDown26.Value = 0;
                    numericUpDown27.Value = 0;
                }
            }

            listBox1.Items.Clear(); //ürünler silindiği icin listboxu temizliyor

            textBox1.Text = "";  //toplam fiyat textbox'u sıfırlanıyor


        }


        public void ResetNumericUpDowns()
        {
            foreach (Control ctrl in Controls)
            {
                if (ctrl is NumericUpDown numericUpDown)
                {
                    numericUpDown4.Value = 0;
                    numericUpDown5.Value = 0;
                    numericUpDown6.Value = 0;
                    numericUpDown7.Value = 0;
                    numericUpDown8.Value = 0;
                    numericUpDown9.Value = 0;
                    numericUpDown10.Value = 0;
                    numericUpDown11.Value = 0;
                    numericUpDown12.Value = 0;
                    numericUpDown13.Value = 0;
                    numericUpDown14.Value = 0;
                    numericUpDown15.Value = 0;
                    numericUpDown16.Value = 0;
                    numericUpDown17.Value = 0;
                    numericUpDown18.Value = 0;
                    numericUpDown19.Value = 0;
                    numericUpDown20.Value = 0;
                    numericUpDown21.Value = 0;
                    numericUpDown22.Value = 0;
                    numericUpDown23.Value = 0;
                    numericUpDown24.Value = 0;
                    numericUpDown25.Value = 0;
                    numericUpDown26.Value = 0;
                    numericUpDown27.Value = 0;

                }
                else if (ctrl.Controls.Count > 0)
                {
                    ResetAllNumericUpDowns(ctrl);
                    numericUpDown4.Value = 0;
                    numericUpDown5.Value = 0;
                    numericUpDown6.Value = 0;
                    numericUpDown7.Value = 0;
                    numericUpDown8.Value = 0;
                    numericUpDown9.Value = 0;
                    numericUpDown10.Value = 0;
                    numericUpDown11.Value = 0;
                    numericUpDown12.Value = 0;
                    numericUpDown13.Value = 0;
                    numericUpDown14.Value = 0;
                    numericUpDown15.Value = 0;
                    numericUpDown16.Value = 0;
                    numericUpDown17.Value = 0;
                    numericUpDown18.Value = 0;
                    numericUpDown19.Value = 0;
                    numericUpDown20.Value = 0;
                    numericUpDown21.Value = 0;
                    numericUpDown22.Value = 0;
                    numericUpDown23.Value = 0;
                    numericUpDown24.Value = 0;
                    numericUpDown25.Value = 0;
                    numericUpDown26.Value = 0;
                    numericUpDown27.Value = 0;
                }
            }

            listBox1.Items.Clear();
            textBox1.Text = "";
        }







        public void ResetAllNumericUpDowns()
        {
            foreach (Control ctrl in Controls)
            {
                if (ctrl is NumericUpDown numericUpDown)
                {
                    numericUpDown4.Value = 0;
                    numericUpDown5.Value = 0;
                    numericUpDown6.Value = 0;
                    numericUpDown7.Value = 0;
                    numericUpDown8.Value = 0;
                    numericUpDown9.Value = 0;
                    numericUpDown10.Value = 0;
                    numericUpDown11.Value = 0;
                    numericUpDown12.Value = 0;
                    numericUpDown13.Value = 0;
                    numericUpDown14.Value = 0;
                    numericUpDown15.Value = 0;
                    numericUpDown16.Value = 0;
                    numericUpDown17.Value = 0;
                    numericUpDown18.Value = 0;
                    numericUpDown19.Value = 0;
                    numericUpDown20.Value = 0;
                    numericUpDown21.Value = 0;
                    numericUpDown22.Value = 0;
                    numericUpDown23.Value = 0;
                    numericUpDown24.Value = 0;
                    numericUpDown25.Value = 0;
                    numericUpDown26.Value = 0;
                    numericUpDown27.Value = 0;

                }
                else if (ctrl.Controls.Count > 0)
                {
                    ResetAllNumericUpDowns(ctrl);
                    numericUpDown4.Value = 0;
                    numericUpDown5.Value = 0;
                    numericUpDown6.Value = 0;
                    numericUpDown7.Value = 0;
                    numericUpDown8.Value = 0;
                    numericUpDown9.Value = 0;
                    numericUpDown10.Value = 0;
                    numericUpDown11.Value = 0;
                    numericUpDown12.Value = 0;
                    numericUpDown13.Value = 0;
                    numericUpDown14.Value = 0;
                    numericUpDown15.Value = 0;
                    numericUpDown16.Value = 0;
                    numericUpDown17.Value = 0;
                    numericUpDown18.Value = 0;
                    numericUpDown19.Value = 0;
                    numericUpDown20.Value = 0;
                    numericUpDown21.Value = 0;
                    numericUpDown22.Value = 0;
                    numericUpDown23.Value = 0;
                    numericUpDown24.Value = 0;
                    numericUpDown25.Value = 0;
                    numericUpDown26.Value = 0;
                    numericUpDown27.Value = 0;
                }
            }

            listBox1.Items.Clear();
            textBox1.Text = "";
        }






        private void MakePictureBoxCircular(PictureBox pictureBox)  // bazı pictureboxları kare yerine yuvarlak yapmak icin kullandık
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, pictureBox.Width, pictureBox.Height);
            pictureBox.Region = new Region(path);
        }




        private void Form2_Load(object sender, EventArgs e)
        {
            tabPage10.Visible = false;
            numericUpDown4.ValueChanged += new EventHandler(numericUpDown4_ValueChanged);

            progressBar1.Value = 0;    //form yüklenirken progressbar'ın sabit özelliklerini yazdık
            progressBar1.Maximum = 100;



            // TabPage8 için Timer kontrolü
            if (tabControl1.SelectedTab == tabPage8)
            {
                timer1.Start();
            }
            else
            {
                timer1.Stop();
            }

            // TabPage9 için Timer kontrolü
            if (tabControl1.SelectedTab == tabPage9)
            {
                timer2.Start();
            }
            else
            {
                timer2.Stop();
            }





            button5.Visible = false;
            int saniye = 120;  //3d security kısmı icin geri sayım yaptıgımız label'in saniye tanımlaması

            // PictureBox'ları yuvarlak yapmak icin 

            MakePictureBoxCircular(pictureBox3);
            MakePictureBoxCircular(pictureBox4);
            MakePictureBoxCircular(pictureBox5);
            MakePictureBoxCircular(pictureBox6);
            MakePictureBoxCircular(pictureBox7);
            MakePictureBoxCircular(pictureBox11);
            MakePictureBoxCircular(pictureBox12);
            MakePictureBoxCircular(pictureBox13);


            this.Width = 485;
            this.Height = 730;

            tabControl1.Visible = false;
            tabPage1.Text = "";
            tabPage2.Text = "";
            tabPage3.Text = "";        //tabpage'lerin üstte yazan "tabpage1, tabpage2 vb." yazılarını saklamak icin icini bos bıraktık
            tabPage4.Text = "";
            tabPage5.Text = "";
            tabPage11.Text = "";
            tabPage12.Text = "";
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);     //tabcontrolun ilk boyu ve yerini belirlemek icin yazdık
            tabControl1.SizeMode = TabSizeMode.Fixed;

            dataGridView1.Columns.Add("ProductName", "Ürünler");        //datagriwe ürün ve stok sayısını tanımlamak icin yazdık 
            dataGridView1.Columns.Add("Quantity", "Stok Sayısı");

            // Ürün listesi ve stok sayıları
            var products = new Dictionary<string, int>
              {
                { "Muz", 2 },
                { "Kivi", 5 },
                { "Nar", 3 },
                { "Çilek", 4 },
                { "Havuç", 6 },
                { "Patates", 10 },
                { "Turp", 7 },
                { "Maydanoz", 8 },
                { "Lays Cips", 12 },
                { "Tadım Çekirdek", 15 },
                { "Biscolata Pia", 5 },
                { "Nero Biskuvi", 8 },
                { "Saka Su", 20 },
                { "İçim Ayran", 10 },
                { "Fanta Portakal", 14 },
                { "Uludağ Limonata", 18 },
                { "Hatay Dürüm", 9 },
                { "Pizza", 10 },
                { "Hamburger", 5 },
                { "Sosisli", 7 },
                { "Albeni Çikolata", 6 },
                { "Kiraz", 4 },
                { "Salatalık", 3 },
                { "Muzlu Popkek", 2 }
                };


            foreach (var product in products)
            {
                dataGridView1.Rows.Add(product.Key, product.Value);  // ilk kısmı isim olarak, ikinci kısmı sayı-stok değeri olarak ekliyor 
            }


        }


        private void label9_Click(object sender, EventArgs e)
        {
            tabControl2.Visible = false;
            tabControl1.Visible = true;
            tabControl1.SelectedTab = tabPage6;
            tabPage6.Visible = true;


            tabControl1.Location = new Point(0, 0);
            tabControl1.Size = new Size(this.ClientSize.Width, this.ClientSize.Height);
        }


        private void pictureBox9_Click(object sender, EventArgs e)
        {
            tabControl2.Visible = false;
            tabControl1.Visible = true;
            tabControl1.SelectedTab = tabPage7;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Size = new Size(this.ClientSize.Width, this.ClientSize.Height);

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();

        }

        private void pictureBox63_Click(object sender, EventArgs e)
        {
            tabControl2.Visible = false;
            tabControl1.Visible = false;
        }

        private void groupBox15_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            tabControl2.Visible = false;
            tabControl1.Visible = true;
            tabControl1.SelectedTab = tabPage1;
            tabPage1.Visible = true;


            tabControl1.Location = new Point(0, 0);
            tabControl1.Size = new Size(this.ClientSize.Width, this.ClientSize.Height);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            tabControl2.Visible = false;
            tabControl1.Visible = true;
            tabControl1.SelectedTab = tabPage2;
            tabPage2.Visible = true;


            tabControl1.Location = new Point(0, 0);
            tabControl1.Size = new Size(this.ClientSize.Width, this.ClientSize.Height);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            tabControl2.Visible = false;
            tabControl1.Visible = true;
            tabControl1.SelectedTab = tabPage3;
            tabPage3.Visible = true;


            tabControl1.Location = new Point(0, 0);
            tabControl1.Size = new Size(this.ClientSize.Width, this.ClientSize.Height);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            tabControl2.Visible = false;
            tabControl1.Visible = true;
            tabControl1.SelectedTab = tabPage4;
            tabPage4.Visible = true;


            tabControl1.Location = new Point(0, 0);
            tabControl1.Size = new Size(this.ClientSize.Width, this.ClientSize.Height);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            tabControl2.Visible = false;
            tabControl1.Visible = true;
            tabControl1.SelectedTab = tabPage5;
            tabPage5.Visible = true;


            tabControl1.Location = new Point(0, 0);
            tabControl1.Size = new Size(this.ClientSize.Width, this.ClientSize.Height);
        }









        private void pictureBox23_Click(object sender, EventArgs e)
        {

            tabControl2.Visible = false;
            tabControl1.Visible = false;

        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {

            tabControl2.Visible = false;
            tabControl1.Visible = false;
        }

        private void pictureBox61_Click(object sender, EventArgs e)
        {

            tabControl2.Visible = false;
            tabControl1.Visible = false;
        }

        private void pictureBox62_Click(object sender, EventArgs e)
        {

            tabControl2.Visible = false;
            tabControl1.Visible = false;
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            tabControl2.Visible = false;
            tabControl1.Visible = false;
        }

        private void pictureBox51_Click(object sender, EventArgs e)
        {
            tabControl2.Visible = false;
            tabControl1.Visible = false;
        }

        private void pictureBox54_Click(object sender, EventArgs e)
        {
            tabControl2.Visible = false;
            tabControl1.Visible = false;
        }

        private void pictureBox57_Click(object sender, EventArgs e)
        {
            tabControl2.Visible = false;
            tabControl1.Visible = false;
        }

        private void pictureBox60_Click(object sender, EventArgs e)
        {
            tabControl2.Visible = false;
            tabControl1.Visible = false;
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            tabControl2.Visible = false;
            tabControl1.Visible = true;
            tabControl1.SelectedTab = tabPage7;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Size = new Size(this.ClientSize.Width, this.ClientSize.Height);
        }

        private void pictureBox64_Click(object sender, EventArgs e)
        {
            tabControl2.Visible = false;
            tabControl1.Visible = false;
        }

        private void pictureBox59_Click(object sender, EventArgs e)
        {
            tabControl2.Visible = false;
            tabControl1.Visible = true;
            tabControl1.SelectedTab = tabPage7;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Size = new Size(this.ClientSize.Width, this.ClientSize.Height);
        }

        private void pictureBox67_Click(object sender, EventArgs e)
        {
            tabControl2.Visible = false;
            tabControl1.Visible = false;
        }

        private void pictureBox76_Click(object sender, EventArgs e)
        {
            tabControl2.Visible = false;
            tabControl1.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //sil butonuna basınca listbox temizleniyor

            listBox1.Items.Clear();
            numericUpDown4.Value = 0;
            numericUpDown5.Value = 0;
            numericUpDown6.Value = 0;
            numericUpDown7.Value = 0;
            numericUpDown8.Value = 0;
            numericUpDown9.Value = 0;
            numericUpDown10.Value = 0;
            numericUpDown11.Value = 0;
            numericUpDown12.Value = 0;
            numericUpDown13.Value = 0;
            numericUpDown14.Value = 0;
            numericUpDown15.Value = 0;
            numericUpDown16.Value = 0;
            numericUpDown17.Value = 0;
            numericUpDown18.Value = 0;
            numericUpDown19.Value = 0;
            numericUpDown20.Value = 0;
            numericUpDown21.Value = 0;
            numericUpDown22.Value = 0;
            numericUpDown23.Value = 0;
            numericUpDown24.Value = 0;
            numericUpDown25.Value = 0;
            numericUpDown26.Value = 0;
            numericUpDown27.Value = 0;
        }





        private void button3_Click(object sender, EventArgs e)
        {
            //secili ürünü siliyor sadece ve son toplam fiyatı güncelliyor

            string selectedItem = listBox1.SelectedItem.ToString();


            listBox1.Items.Remove(selectedItem);


            UpdateTotalPrice();


        }



        private void UpdateTotalPrice()
        {
            decimal total = 0;  //ilk toplam fiyat 0

            foreach (string item in listBox1.Items)
            {

                string[] parts = item.Split('=');
                if (parts.Length > 1)
                {
                    string pricePart = parts[1].Trim()
                                              .Replace("TL", "")
                                              .Replace("₺", "")
                                              .Trim();
                    // listboxtaki ürünün yanındaki tl değerini siliyor, 120tl toplam fiyat kısmına sadece 120 diye yazılıyor
                    if (decimal.TryParse(pricePart, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.CurrentCulture, out decimal price))
                    {
                        total += price;
                    }
                }
            }


            textBox1.Text = total.ToString("F2"); //sayı virgülden sonra 3 basamaksa 2 yapıyor veya sayının virgül sonrası kısmını yuvarlıyor
        }


        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {

            int selectedValue = (int)numericUpDown4.Value;

            


            if (selectedValue > 2) //datagriwde belirlediğimiz ürüne özel stok sayısı
            {

                MessageBox.Show("Stok sayısını aşamazsınız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                numericUpDown4.Value = 0;
            }
           


            // NumericUpDown'dan seçilen değer
            int value = (int)((NumericUpDown)sender).Value;
            string productName = "Muz"; // Ürün adı  
            decimal productPrice = 25; // Fiyat

            // Toplam fiyatı hesaplar
            decimal totalPrice = value * productPrice;

            // Ürün sayısını ve toplam fiyatı tek satırda birleştirir
            string itemToAdd = $"{value} kg {productName} = {totalPrice:F2} TL"; // Para birimi sembolü olmadan

            // Mevcut ListBox içeriğini kontrol eder
            bool itemUpdated = false;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                string existingItem = listBox1.Items[i].ToString();
                if (existingItem.Contains(productName)) // Eğer ürün ListBox'ta varsa
                {
                    if (value > 0)
                    {
                        listBox1.Items[i] = itemToAdd; // Mevcut öğeyi günceller
                    }
                    else
                    {
                        listBox1.Items.RemoveAt(i); // Ürün miktarı sıfırsa kaldır
                        UpdateTotalPrice(); // Toplam fiyatı güncelle
                    }
                    itemUpdated = true;
                    break;
                }
            }

            // Ürün ListBox'ta yoksa ve miktar > 0 ise ekle
            if (!itemUpdated && value > 0)
            {
                listBox1.Items.Add(itemToAdd);
            }

            UpdateTotalPrice(); // Her durumda toplam fiyatı güncelle
        }


        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {



            int selectedValue = (int)numericUpDown5.Value;

            

            // Stok sayısını 5'ten fazla olup olmadığını kontrol et
            if (selectedValue > 5)
            {
                // Kullanıcıya uyarı ver
                MessageBox.Show("Stok sayısını aşamazsınız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Değeri geri al

                numericUpDown5.Value = 0;
            }
          






            // NumericUpDown'dan seçilen değer
            int value = (int)((NumericUpDown)sender).Value;
            string productName = "Kivi"; // Ürün adı
            decimal productPrice = 55; // Fiyat

            // Toplam fiyatı hesapla
            decimal totalPrice = value * productPrice;

            // Ürün sayısını ve toplam fiyatı tek satırda birleştir
            string itemToAdd = $"{value} kg {productName} = {totalPrice:F2} TL"; // Para birimi sembolü olmadan

            // Mevcut ListBox içeriğini kontrol et
            bool itemUpdated = false;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                string existingItem = listBox1.Items[i].ToString();
                if (existingItem.Contains(productName)) // Eğer ürün ListBox'ta varsa
                {
                    if (value > 0)
                    {
                        listBox1.Items[i] = itemToAdd; // Mevcut öğeyi güncelle
                    }
                    else
                    {
                        listBox1.Items.RemoveAt(i); // Ürün miktarı sıfırsa kaldır
                        UpdateTotalPrice(); // Toplam fiyatı güncelle
                    }
                    itemUpdated = true;
                    break;
                }
            }

            // Ürün ListBox'ta yoksa ve miktar > 0 ise ekle
            if (!itemUpdated && value > 0)
            {
                listBox1.Items.Add(itemToAdd);
            }

            UpdateTotalPrice(); // Her durumda toplam fiyatı güncelle

        }



        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {

            // NumericUpDown6'nın değeri
            int selectedValue = (int)numericUpDown6.Value;

            

            // Stok sayısını 3'ten fazla olup olmadığını kontrol et
            if (selectedValue > 3)
            {
                // Kullanıcıya uyarı ver
                MessageBox.Show("Stok sayısını aşamazsınız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Değeri geri al

                numericUpDown6.Value = 0;
            }
            








            // NumericUpDown'dan seçilen değer
            int value = (int)((NumericUpDown)sender).Value;
            string productName = "Nar"; // Ürün adı
            decimal productPrice = 20; // Fiyat

            // Toplam fiyatı hesapla
            decimal totalPrice = value * productPrice;

            // Ürün sayısını ve toplam fiyatı tek satırda birleştir
            string itemToAdd = $"{value} kg {productName} = {totalPrice:F2} TL"; // Para birimi sembolü olmadan

            // Mevcut ListBox içeriğini kontrol et
            bool itemUpdated = false;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                string existingItem = listBox1.Items[i].ToString();
                if (existingItem.Contains(productName)) // Eğer ürün ListBox'ta varsa
                {
                    if (value > 0)
                    {
                        listBox1.Items[i] = itemToAdd; // Mevcut öğeyi güncelle
                    }
                    else
                    {
                        listBox1.Items.RemoveAt(i); // Ürün miktarı sıfırsa kaldır
                        UpdateTotalPrice(); // Toplam fiyatı güncelle
                    }
                    itemUpdated = true;
                    break;
                }
            }

            // Ürün ListBox'ta yoksa ve miktar > 0 ise ekle
            if (!itemUpdated && value > 0)
            {
                listBox1.Items.Add(itemToAdd);
            }

            UpdateTotalPrice(); // Her durumda toplam fiyatı güncelle
        }

        private void numericUpDown7_ValueChanged(object sender, EventArgs e)
        {

            // NumericUpDown7'nin değeri
            int selectedValue = (int)numericUpDown7.Value;

            

            // Stok sayısını 4'ten fazla olup olmadığını kontrol et
            if (selectedValue > 4)
            {
                // Kullanıcıya uyarı ver
                MessageBox.Show("Stok sayısını aşamazsınız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Değeri geri al

                numericUpDown7.Value = 0;
            }
          










            // NumericUpDown'dan seçilen değer
            int value = (int)((NumericUpDown)sender).Value;
            string productName = "Çilek"; // Ürün adı
            decimal productPrice = 35; // Fiyat

            // Toplam fiyatı hesapla
            decimal totalPrice = value * productPrice;

            // Ürün sayısını ve toplam fiyatı tek satırda birleştir
            string itemToAdd = $"{value} kg {productName} = {totalPrice:F2} TL"; // Para birimi sembolü olmadan

            // Mevcut ListBox içeriğini kontrol et
            bool itemUpdated = false;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                string existingItem = listBox1.Items[i].ToString();
                if (existingItem.Contains(productName)) // Eğer ürün ListBox'ta varsa
                {
                    if (value > 0)
                    {
                        listBox1.Items[i] = itemToAdd; // Mevcut öğeyi güncelle
                    }
                    else
                    {
                        listBox1.Items.RemoveAt(i); // Ürün miktarı sıfırsa kaldır
                        UpdateTotalPrice(); // Toplam fiyatı güncelle
                    }
                    itemUpdated = true;
                    break;
                }
            }

            // Ürün ListBox'ta yoksa ve miktar > 0 ise ekle
            if (!itemUpdated && value > 0)
            {
                listBox1.Items.Add(itemToAdd);
            }

            UpdateTotalPrice(); // Her durumda toplam fiyatı güncelle
        }

        private void numericUpDown8_ValueChanged(object sender, EventArgs e)
        {

            // NumericUpDown8'nin değeri
            int selectedValue = (int)numericUpDown8.Value;

            

            // Stok sayısını 6'dan fazla olup olmadığını kontrol et
            if (selectedValue > 6)
            {
                // Kullanıcıya uyarı ver
                MessageBox.Show("Stok sayısını aşamazsınız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Değeri geri al

                numericUpDown8.Value = 0;
            }
          








            // NumericUpDown'dan seçilen değer
            int value = (int)((NumericUpDown)sender).Value;
            string productName = "Havuç"; // Ürün adı
            decimal productPrice = 30; // Fiyat

            // Toplam fiyatı hesapla
            decimal totalPrice = value * productPrice;

            // Ürün sayısını ve toplam fiyatı tek satırda birleştir
            string itemToAdd = $"{value} kg {productName} = {totalPrice:F2} TL"; // Para birimi sembolü olmadan

            // Mevcut ListBox içeriğini kontrol et
            bool itemUpdated = false;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                string existingItem = listBox1.Items[i].ToString();
                if (existingItem.Contains(productName)) // Eğer ürün ListBox'ta varsa
                {
                    if (value > 0)
                    {
                        listBox1.Items[i] = itemToAdd; // Mevcut öğeyi güncelle
                    }
                    else
                    {
                        listBox1.Items.RemoveAt(i); // Ürün miktarı sıfırsa kaldır
                        UpdateTotalPrice(); // Toplam fiyatı güncelle
                    }
                    itemUpdated = true;
                    break;
                }
            }

            // Ürün ListBox'ta yoksa ve miktar > 0 ise ekle
            if (!itemUpdated && value > 0)
            {
                listBox1.Items.Add(itemToAdd);
            }

            UpdateTotalPrice(); // Her durumda toplam fiyatı güncelle
        }

        private void numericUpDown9_ValueChanged(object sender, EventArgs e)
        {



            // NumericUpDown9'un değeri
            int selectedValue = (int)numericUpDown9.Value;

            

            // Stok sayısını 10'dan fazla olup olmadığını kontrol et
            if (selectedValue > 10)
            {
                // Kullanıcıya uyarı ver
                MessageBox.Show("Stok sayısını aşamazsınız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Değeri geri al

                numericUpDown9.Value = 0;
            }
            






            // NumericUpDown'dan seçilen değer
            int value = (int)((NumericUpDown)sender).Value;
            string productName = "Patates"; // Ürün adı
            decimal productPrice = 25; // Fiyat

            // Toplam fiyatı hesapla
            decimal totalPrice = value * productPrice;

            // Ürün sayısını ve toplam fiyatı tek satırda birleştir
            string itemToAdd = $"{value} kg {productName} = {totalPrice:F2} TL"; // Para birimi sembolü olmadan

            // Mevcut ListBox içeriğini kontrol et
            bool itemUpdated = false;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                string existingItem = listBox1.Items[i].ToString();
                if (existingItem.Contains(productName)) // Eğer ürün ListBox'ta varsa
                {
                    if (value > 0)
                    {
                        listBox1.Items[i] = itemToAdd; // Mevcut öğeyi güncelle
                    }
                    else
                    {
                        listBox1.Items.RemoveAt(i); // Ürün miktarı sıfırsa kaldır
                        UpdateTotalPrice(); // Toplam fiyatı güncelle
                    }
                    itemUpdated = true;
                    break;
                }
            }

            // Ürün ListBox'ta yoksa ve miktar > 0 ise ekle
            if (!itemUpdated && value > 0)
            {
                listBox1.Items.Add(itemToAdd);
            }

            UpdateTotalPrice(); // Her durumda toplam fiyatı güncelle
        }

        private void numericUpDown10_ValueChanged(object sender, EventArgs e)
        {


            // NumericUpDown10'un değeri
            int selectedValue = (int)numericUpDown10.Value;

            

            // Stok sayısını 7'den fazla olup olmadığını kontrol et
            if (selectedValue > 7)
            {
                // Kullanıcıya uyarı ver
                MessageBox.Show("Stok sayısını aşamazsınız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Değeri geri al

                numericUpDown4.Value = 0;
            }
            







            // NumericUpDown'dan seçilen değer
            int value = (int)((NumericUpDown)sender).Value;
            string productName = "Turp"; // Ürün adı
            decimal productPrice = 35; // Fiyat

            // Toplam fiyatı hesapla
            decimal totalPrice = value * productPrice;

            // Ürün sayısını ve toplam fiyatı tek satırda birleştir
            string itemToAdd = $"{value} kg {productName} = {totalPrice:F2} TL"; // Para birimi sembolü olmadan

            // Mevcut ListBox içeriğini kontrol et
            bool itemUpdated = false;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                string existingItem = listBox1.Items[i].ToString();
                if (existingItem.Contains(productName)) // Eğer ürün ListBox'ta varsa
                {
                    if (value > 0)
                    {
                        listBox1.Items[i] = itemToAdd; // Mevcut öğeyi güncelle
                    }
                    else
                    {
                        listBox1.Items.RemoveAt(i); // Ürün miktarı sıfırsa kaldır
                        UpdateTotalPrice(); // Toplam fiyatı güncelle
                    }
                    itemUpdated = true;
                    break;
                }
            }

            // Ürün ListBox'ta yoksa ve miktar > 0 ise ekle
            if (!itemUpdated && value > 0)
            {
                listBox1.Items.Add(itemToAdd);
            }

            UpdateTotalPrice(); // Her durumda toplam fiyatı güncelle
        }

        private void numericUpDown11_ValueChanged(object sender, EventArgs e)
        {


            int selectedValue = (int)numericUpDown11.Value;

           


            if (selectedValue > 8)
            {
                // Kullanıcıya uyarı ver
                MessageBox.Show("Stok sayısını aşamazsınız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                numericUpDown11.Value = 0;
            }
           









            // NumericUpDown'dan seçilen değer
            int value = (int)((NumericUpDown)sender).Value;
            string productName = "Maydanoz"; // Ürün adı
            decimal productPrice = 10; // Fiyat

            // Toplam fiyatı hesapla
            decimal totalPrice = value * productPrice;

            // Ürün sayısını ve toplam fiyatı tek satırda birleştir
            string itemToAdd = $"{value} kg {productName} = {totalPrice:F2} TL"; // Para birimi sembolü olmadan

            // Mevcut ListBox içeriğini kontrol et
            bool itemUpdated = false;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                string existingItem = listBox1.Items[i].ToString();
                if (existingItem.Contains(productName)) // Eğer ürün ListBox'ta varsa
                {
                    if (value > 0)
                    {
                        listBox1.Items[i] = itemToAdd; // Mevcut öğeyi güncelle
                    }
                    else
                    {
                        listBox1.Items.RemoveAt(i); // Ürün miktarı sıfırsa kaldır
                        UpdateTotalPrice(); // Toplam fiyatı güncelle
                    }
                    itemUpdated = true;
                    break;
                }
            }

            // Ürün ListBox'ta yoksa ve miktar > 0 ise ekle
            if (!itemUpdated && value > 0)
            {
                listBox1.Items.Add(itemToAdd);
            }

            UpdateTotalPrice(); // Her durumda toplam fiyatı güncelle
        }

        private void numericUpDown12_ValueChanged(object sender, EventArgs e)
        {
            // NumericUpDown12'un değeri
            int selectedValue = (int)numericUpDown12.Value;

           

            // Stok sayısını 12'den fazla olup olmadığını kontrol et
            if (selectedValue > 12)
            {
                // Kullanıcıya uyarı ver
                MessageBox.Show("Stok sayısını aşamazsınız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Değeri geri al
                numericUpDown12.Value = 0;
            }
          





            // NumericUpDown'dan seçilen değer
            int value = (int)((NumericUpDown)sender).Value;
            string productName = "Lays Cips"; // Ürün adı
            decimal productPrice = 28; // Fiyat

            // Toplam fiyatı hesapla
            decimal totalPrice = value * productPrice;

            // Ürün sayısını ve toplam fiyatı tek satırda birleştir
            string itemToAdd = $"{value} adet {productName} = {totalPrice:F2} TL"; // Para birimi sembolü olmadan

            // Mevcut ListBox içeriğini kontrol et
            bool itemUpdated = false;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                string existingItem = listBox1.Items[i].ToString();
                if (existingItem.Contains(productName)) // Eğer ürün ListBox'ta varsa
                {
                    if (value > 0)
                    {
                        listBox1.Items[i] = itemToAdd; // Mevcut öğeyi güncelle
                    }
                    else
                    {
                        listBox1.Items.RemoveAt(i); // Ürün miktarı sıfırsa kaldır
                        UpdateTotalPrice(); // Toplam fiyatı güncelle
                    }
                    itemUpdated = true;
                    break;
                }
            }

            // Ürün ListBox'ta yoksa ve miktar > 0 ise ekle
            if (!itemUpdated && value > 0)
            {
                listBox1.Items.Add(itemToAdd);
            }

            UpdateTotalPrice(); // Her durumda toplam fiyatı güncelle
        }

        private void numericUpDown13_ValueChanged(object sender, EventArgs e)
        {


            // NumericUpDown13'un değeri
            int selectedValue = (int)numericUpDown13.Value;

            

            // Stok sayısını 15'den fazla olup olmadığını kontrol et
            if (selectedValue > 15)
            {
                // Kullanıcıya uyarı ver
                MessageBox.Show("Stok sayısını aşamazsınız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Değeri geri al
                numericUpDown13.Value = 0;
            }
            





            // NumericUpDown'dan seçilen değer
            int value = (int)((NumericUpDown)sender).Value;
            string productName = "Tadım Çekirdek"; // Ürün adı
            decimal productPrice = 50; // Fiyat

            // Toplam fiyatı hesapla
            decimal totalPrice = value * productPrice;

            // Ürün sayısını ve toplam fiyatı tek satırda birleştir
            string itemToAdd = $"{value} adet {productName} = {totalPrice:F2} TL"; // Para birimi sembolü olmadan

            // Mevcut ListBox içeriğini kontrol et
            bool itemUpdated = false;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                string existingItem = listBox1.Items[i].ToString();
                if (existingItem.Contains(productName)) // Eğer ürün ListBox'ta varsa
                {
                    if (value > 0)
                    {
                        listBox1.Items[i] = itemToAdd; // Mevcut öğeyi güncelle
                    }
                    else
                    {
                        listBox1.Items.RemoveAt(i); // Ürün miktarı sıfırsa kaldır
                        UpdateTotalPrice(); // Toplam fiyatı güncelle
                    }
                    itemUpdated = true;
                    break;
                }
            }

            // Ürün ListBox'ta yoksa ve miktar > 0 ise ekle
            if (!itemUpdated && value > 0)
            {
                listBox1.Items.Add(itemToAdd);
            }

            UpdateTotalPrice(); // Her durumda toplam fiyatı güncelle
        }

        private void numericUpDown14_ValueChanged(object sender, EventArgs e)
        {



            // NumericUpDown14'un değeri
            int selectedValue = (int)numericUpDown14.Value;

            

            // Stok sayısını 5'den fazla olup olmadığını kontrol et
            if (selectedValue > 5)
            {
                // Kullanıcıya uyarı ver
                MessageBox.Show("Stok sayısını aşamazsınız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Değeri geri al
                numericUpDown14.Value = 0;
            }
           





            // NumericUpDown'dan seçilen değer
            int value = (int)((NumericUpDown)sender).Value;
            string productName = "Biskolata Pia"; // Ürün adı
            decimal productPrice = 23; // Fiyat

            // Toplam fiyatı hesapla
            decimal totalPrice = value * productPrice;

            // Ürün sayısını ve toplam fiyatı tek satırda birleştir
            string itemToAdd = $"{value} adet {productName} = {totalPrice:F2} TL"; // Para birimi sembolü olmadan

            // Mevcut ListBox içeriğini kontrol et
            bool itemUpdated = false;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                string existingItem = listBox1.Items[i].ToString();
                if (existingItem.Contains(productName)) // Eğer ürün ListBox'ta varsa
                {
                    if (value > 0)
                    {
                        listBox1.Items[i] = itemToAdd; // Mevcut öğeyi güncelle
                    }
                    else
                    {
                        listBox1.Items.RemoveAt(i); // Ürün miktarı sıfırsa kaldır
                        UpdateTotalPrice(); // Toplam fiyatı güncelle
                    }
                    itemUpdated = true;
                    break;
                }
            }

            // Ürün ListBox'ta yoksa ve miktar > 0 ise ekle
            if (!itemUpdated && value > 0)
            {
                listBox1.Items.Add(itemToAdd);
            }

            UpdateTotalPrice(); // Her durumda toplam fiyatı güncelle
        }

        private void numericUpDown15_ValueChanged(object sender, EventArgs e)
        {

            // NumericUpDown15'un değeri
            int selectedValue = (int)numericUpDown15.Value;

          

            // Stok sayısını 8'den fazla olup olmadığını kontrol et
            if (selectedValue > 8)
            {
                // Kullanıcıya uyarı ver
                MessageBox.Show("Stok sayısını aşamazsınız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Değeri geri al
                numericUpDown15.Value = 0;
            }
           



            // NumericUpDown'dan seçilen değer
            int value = (int)((NumericUpDown)sender).Value;
            string productName = "Nero Bisküvi"; // Ürün adı
            decimal productPrice = 15; // Fiyat

            // Toplam fiyatı hesapla
            decimal totalPrice = value * productPrice;

            // Ürün sayısını ve toplam fiyatı tek satırda birleştir
            string itemToAdd = $"{value} adet {productName} = {totalPrice:F2} TL"; // Para birimi sembolü olmadan

            // Mevcut ListBox içeriğini kontrol et
            bool itemUpdated = false;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                string existingItem = listBox1.Items[i].ToString();
                if (existingItem.Contains(productName)) // Eğer ürün ListBox'ta varsa
                {
                    if (value > 0)
                    {
                        listBox1.Items[i] = itemToAdd; // Mevcut öğeyi güncelle
                    }
                    else
                    {
                        listBox1.Items.RemoveAt(i); // Ürün miktarı sıfırsa kaldır
                        UpdateTotalPrice(); // Toplam fiyatı güncelle
                    }
                    itemUpdated = true;
                    break;
                }
            }

            // Ürün ListBox'ta yoksa ve miktar > 0 ise ekle
            if (!itemUpdated && value > 0)
            {
                listBox1.Items.Add(itemToAdd);
            }

            UpdateTotalPrice(); // Her durumda toplam fiyatı güncelle
        }

        private void numericUpDown16_ValueChanged(object sender, EventArgs e)
        {
            // NumericUpDown16'un değeri
            int selectedValue = (int)numericUpDown16.Value;

          

            // Stok sayısını 20'den fazla olup olmadığını kontrol et
            if (selectedValue > 20)
            {
                // Kullanıcıya uyarı ver
                MessageBox.Show("Stok sayısını aşamazsınız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Değeri geri al
                numericUpDown16.Value = 0;
            }
           




            // NumericUpDown'dan seçilen değer
            int value = (int)((NumericUpDown)sender).Value;
            string productName = "Saka Su"; // Ürün adı
            decimal productPrice = 60; // Fiyat

            // Toplam fiyatı hesapla
            decimal totalPrice = value * productPrice;

            // Ürün sayısını ve toplam fiyatı tek satırda birleştir
            string itemToAdd = $"{value} adet {productName} = {totalPrice:F2} TL"; // Para birimi sembolü olmadan

            // Mevcut ListBox içeriğini kontrol et
            bool itemUpdated = false;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                string existingItem = listBox1.Items[i].ToString();
                if (existingItem.Contains(productName)) // Eğer ürün ListBox'ta varsa
                {
                    if (value > 0)
                    {
                        listBox1.Items[i] = itemToAdd; // Mevcut öğeyi güncelle
                    }
                    else
                    {
                        listBox1.Items.RemoveAt(i); // Ürün miktarı sıfırsa kaldır
                        UpdateTotalPrice(); // Toplam fiyatı güncelle
                    }
                    itemUpdated = true;
                    break;
                }
            }

            // Ürün ListBox'ta yoksa ve miktar > 0 ise ekle
            if (!itemUpdated && value > 0)
            {
                listBox1.Items.Add(itemToAdd);
            }

            UpdateTotalPrice(); // Her durumda toplam fiyatı güncelle
        }

        private void numericUpDown17_ValueChanged(object sender, EventArgs e)
        {


            // NumericUpDown17'un değeri
            int selectedValue = (int)numericUpDown17.Value;

            

            // Stok sayısını 10'dan fazla olup olmadığını kontrol et
            if (selectedValue > 10)
            {
                // Kullanıcıya uyarı ver
                MessageBox.Show("Stok sayısını aşamazsınız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Değeri geri al
                numericUpDown17.Value = 0;
            }
           





            // NumericUpDown'dan seçilen değer
            int value = (int)((NumericUpDown)sender).Value;
            string productName = "İçim Ayran"; // Ürün adı
            decimal productPrice = 44; // Fiyat

            // Toplam fiyatı hesapla
            decimal totalPrice = value * productPrice;

            // Ürün sayısını ve toplam fiyatı tek satırda birleştir
            string itemToAdd = $"{value} adet {productName} = {totalPrice:F2} TL"; // Para birimi sembolü olmadan

            // Mevcut ListBox içeriğini kontrol et
            bool itemUpdated = false;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                string existingItem = listBox1.Items[i].ToString();
                if (existingItem.Contains(productName)) // Eğer ürün ListBox'ta varsa
                {
                    if (value > 0)
                    {
                        listBox1.Items[i] = itemToAdd; // Mevcut öğeyi güncelle
                    }
                    else
                    {
                        listBox1.Items.RemoveAt(i); // Ürün miktarı sıfırsa kaldır
                        UpdateTotalPrice(); // Toplam fiyatı güncelle
                    }
                    itemUpdated = true;
                    break;
                }
            }

            // Ürün ListBox'ta yoksa ve miktar > 0 ise ekle
            if (!itemUpdated && value > 0)
            {
                listBox1.Items.Add(itemToAdd);
            }

            UpdateTotalPrice(); // Her durumda toplam fiyatı güncelle
        }

        private void numericUpDown18_ValueChanged(object sender, EventArgs e)
        {


            // NumericUpDown18'un değeri
            int selectedValue = (int)numericUpDown18.Value;

            

            // Stok sayısını 14'ten fazla olup olmadığını kontrol et
            if (selectedValue > 14)
            {
                // Kullanıcıya uyarı ver
                MessageBox.Show("Stok sayısını aşamazsınız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Değeri geri al
                numericUpDown18.Value = 0;
            }
          




            // NumericUpDown'dan seçilen değer
            int value = (int)((NumericUpDown)sender).Value;
            string productName = "Fanta Portakal"; // Ürün adı
            decimal productPrice = 15; // Fiyat

            // Toplam fiyatı hesapla
            decimal totalPrice = value * productPrice;

            // Ürün sayısını ve toplam fiyatı tek satırda birleştir
            string itemToAdd = $"{value} adet {productName} = {totalPrice:F2} TL"; // Para birimi sembolü olmadan

            // Mevcut ListBox içeriğini kontrol et
            bool itemUpdated = false;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                string existingItem = listBox1.Items[i].ToString();
                if (existingItem.Contains(productName)) // Eğer ürün ListBox'ta varsa
                {
                    if (value > 0)
                    {
                        listBox1.Items[i] = itemToAdd; // Mevcut öğeyi güncelle
                    }
                    else
                    {
                        listBox1.Items.RemoveAt(i); // Ürün miktarı sıfırsa kaldır
                        UpdateTotalPrice(); // Toplam fiyatı güncelle
                    }
                    itemUpdated = true;
                    break;
                }
            }

            // Ürün ListBox'ta yoksa ve miktar > 0 ise ekle
            if (!itemUpdated && value > 0)
            {
                listBox1.Items.Add(itemToAdd);
            }

            UpdateTotalPrice(); // Her durumda toplam fiyatı güncelle
        }

        private void numericUpDown19_ValueChanged(object sender, EventArgs e)
        {

            // NumericUpDown19'un değeri
            int selectedValue = (int)numericUpDown19.Value;

           

            // Stok sayısını 18'den fazla olup olmadığını kontrol et
            if (selectedValue > 18)
            {
                // Kullanıcıya uyarı ver
                MessageBox.Show("Stok sayısını aşamazsınız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Değeri geri al
                numericUpDown19.Value = 0;
            }
            





            // NumericUpDown'dan seçilen değer
            int value = (int)((NumericUpDown)sender).Value;
            string productName = "Uludağ Limonata"; // Ürün adı
            decimal productPrice = 20; // Fiyat

            // Toplam fiyatı hesapla
            decimal totalPrice = value * productPrice;

            // Ürün sayısını ve toplam fiyatı tek satırda birleştir
            string itemToAdd = $"{value} adet {productName} = {totalPrice:F2} TL"; // Para birimi sembolü olmadan

            // Mevcut ListBox içeriğini kontrol et
            bool itemUpdated = false;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                string existingItem = listBox1.Items[i].ToString();
                if (existingItem.Contains(productName)) // Eğer ürün ListBox'ta varsa
                {
                    if (value > 0)
                    {
                        listBox1.Items[i] = itemToAdd; // Mevcut öğeyi güncelle
                    }
                    else
                    {
                        listBox1.Items.RemoveAt(i); // Ürün miktarı sıfırsa kaldır
                        UpdateTotalPrice(); // Toplam fiyatı güncelle
                    }
                    itemUpdated = true;
                    break;
                }
            }

            // Ürün ListBox'ta yoksa ve miktar > 0 ise ekle
            if (!itemUpdated && value > 0)
            {
                listBox1.Items.Add(itemToAdd);
            }

            UpdateTotalPrice(); // Her durumda toplam fiyatı güncelle
        }

        private void numericUpDown20_ValueChanged(object sender, EventArgs e)
        {

            // NumericUpDown20'un değeri
            int selectedValue = (int)numericUpDown20.Value;

           
            // Stok sayısını 9'dan fazla olup olmadığını kontrol et
            if (selectedValue > 9)
            {
                // Kullanıcıya uyarı ver
                MessageBox.Show("Stok sayısını aşamazsınız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Değeri geri al
                numericUpDown20.Value = 0;
            }
          




            // NumericUpDown'dan seçilen değer
            int value = (int)((NumericUpDown)sender).Value;
            string productName = "Hatay Dürüm"; // Ürün adı
            decimal productPrice = 90; // Fiyat

            // Toplam fiyatı hesapla
            decimal totalPrice = value * productPrice;

            // Ürün sayısını ve toplam fiyatı tek satırda birleştir
            string itemToAdd = $"{value} adet {productName} = {totalPrice:F2} TL"; // Para birimi sembolü olmadan

            // Mevcut ListBox içeriğini kontrol et
            bool itemUpdated = false;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                string existingItem = listBox1.Items[i].ToString();
                if (existingItem.Contains(productName)) // Eğer ürün ListBox'ta varsa
                {
                    if (value > 0)
                    {
                        listBox1.Items[i] = itemToAdd; // Mevcut öğeyi güncelle
                    }
                    else
                    {
                        listBox1.Items.RemoveAt(i); // Ürün miktarı sıfırsa kaldır
                        UpdateTotalPrice(); // Toplam fiyatı güncelle
                    }
                    itemUpdated = true;
                    break;
                }
            }

            // Ürün ListBox'ta yoksa ve miktar > 0 ise ekle
            if (!itemUpdated && value > 0)
            {
                listBox1.Items.Add(itemToAdd);
            }

            UpdateTotalPrice(); // Her durumda toplam fiyatı güncelle
        }

        private void numericUpDown21_ValueChanged(object sender, EventArgs e)
        {
            // NumericUpDown21'in değeri
            int selectedValue = (int)numericUpDown21.Value;

            

            // Stok sayısını 10'dan fazla olup olmadığını kontrol et
            if (selectedValue > 10)
            {
                // Kullanıcıya uyarı ver
                MessageBox.Show("Stok sayısını aşamazsınız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Değeri geri al
                numericUpDown21.Value = 0;
            }
           





            /// NumericUpDown'dan seçilen değer
            int value = (int)((NumericUpDown)sender).Value;
            string productName = "Pizza"; // Ürün adı
            decimal productPrice = 120; // Fiyat

            // Toplam fiyatı hesapla
            decimal totalPrice = value * productPrice;

            // Ürün sayısını ve toplam fiyatı tek satırda birleştir
            string itemToAdd = $"{value} adet {productName} = {totalPrice:F2} TL"; // Para birimi sembolü olmadan

            // Mevcut ListBox içeriğini kontrol et
            bool itemUpdated = false;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                string existingItem = listBox1.Items[i].ToString();
                if (existingItem.Contains(productName)) // Eğer ürün ListBox'ta varsa
                {
                    if (value > 0)
                    {
                        listBox1.Items[i] = itemToAdd; // Mevcut öğeyi güncelle
                    }
                    else
                    {
                        listBox1.Items.RemoveAt(i); // Ürün miktarı sıfırsa kaldır
                        UpdateTotalPrice(); // Toplam fiyatı güncelle
                    }
                    itemUpdated = true;
                    break;
                }
            }

            // Ürün ListBox'ta yoksa ve miktar > 0 ise ekle
            if (!itemUpdated && value > 0)
            {
                listBox1.Items.Add(itemToAdd);
            }

            UpdateTotalPrice(); // Her durumda toplam fiyatı güncelle
        }

        private void numericUpDown22_ValueChanged(object sender, EventArgs e)
        {


            // NumericUpDown22'nin değeri
            int selectedValue = (int)numericUpDown22.Value;

          

            // Stok sayısını 5'ten fazla olup olmadığını kontrol et
            if (selectedValue > 5)
            {
                // Kullanıcıya uyarı ver
                MessageBox.Show("Stok sayısını aşamazsınız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Değeri geri al
                numericUpDown22.Value = 0;
            }
            






            // NumericUpDown'dan seçilen değer
            int value = (int)((NumericUpDown)sender).Value;
            string productName = "Hamburger"; // Ürün adı
            decimal productPrice = 100; // Fiyat

            // Toplam fiyatı hesapla
            decimal totalPrice = value * productPrice;

            // Ürün sayısını ve toplam fiyatı tek satırda birleştir
            string itemToAdd = $"{value} adet {productName} = {totalPrice:F2} TL"; // Para birimi sembolü olmadan

            // Mevcut ListBox içeriğini kontrol et
            bool itemUpdated = false;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                string existingItem = listBox1.Items[i].ToString();
                if (existingItem.Contains(productName)) // Eğer ürün ListBox'ta varsa
                {
                    if (value > 0)
                    {
                        listBox1.Items[i] = itemToAdd; // Mevcut öğeyi güncelle
                    }
                    else
                    {
                        listBox1.Items.RemoveAt(i); // Ürün miktarı sıfırsa kaldır
                        UpdateTotalPrice(); // Toplam fiyatı güncelle
                    }
                    itemUpdated = true;
                    break;
                }
            }

            // Ürün ListBox'ta yoksa ve miktar > 0 ise ekle
            if (!itemUpdated && value > 0)
            {
                listBox1.Items.Add(itemToAdd);
            }

            UpdateTotalPrice(); // Her durumda toplam fiyatı güncelle
        }

        private void numericUpDown23_ValueChanged(object sender, EventArgs e)
        {

            // NumericUpDown23'ün değeri
            int selectedValue = (int)numericUpDown23.Value;


            // Stok sayısını 7'den fazla olup olmadığını kontrol et
            if (selectedValue > 7)
            {
                // Kullanıcıya uyarı ver
                MessageBox.Show("Stok sayısını aşamazsınız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Değeri geri al
                numericUpDown23.Value = 0;
            }
           





            // NumericUpDown'dan seçilen değer
            int value = (int)((NumericUpDown)sender).Value;
            string productName = "Sosisli"; // Ürün adı
            decimal productPrice = 90; // Fiyat

            // Toplam fiyatı hesapla
            decimal totalPrice = value * productPrice;

            // Ürün sayısını ve toplam fiyatı tek satırda birleştir
            string itemToAdd = $"{value} adet {productName} = {totalPrice:F2} TL"; // Para birimi sembolü olmadan

            // Mevcut ListBox içeriğini kontrol et
            bool itemUpdated = false;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                string existingItem = listBox1.Items[i].ToString();
                if (existingItem.Contains(productName)) // Eğer ürün ListBox'ta varsa
                {
                    if (value > 0)
                    {
                        listBox1.Items[i] = itemToAdd; // Mevcut öğeyi güncelle
                    }
                    else
                    {
                        listBox1.Items.RemoveAt(i); // Ürün miktarı sıfırsa kaldır
                        UpdateTotalPrice(); // Toplam fiyatı güncelle
                    }
                    itemUpdated = true;
                    break;
                }
            }

            // Ürün ListBox'ta yoksa ve miktar > 0 ise ekle
            if (!itemUpdated && value > 0)
            {
                listBox1.Items.Add(itemToAdd);
            }

            UpdateTotalPrice(); // Her durumda toplam fiyatı güncelle
        }

        private void numericUpDown24_ValueChanged(object sender, EventArgs e)
        {
            // NumericUpDown24'ün değeri
            int selectedValue = (int)numericUpDown24.Value;

            

            // Stok sayısını 6'dan fazla olup olmadığını kontrol et
            if (selectedValue > 6)
            {
                // Kullanıcıya uyarı ver
                MessageBox.Show("Stok sayısını aşamazsınız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Değeri geri al
                numericUpDown24.Value = 0;
            }
           





            // NumericUpDown'dan seçilen değer
            int value = (int)((NumericUpDown)sender).Value;
            string productName = "Albeni Çikolata"; // Ürün adı
            decimal productPrice = 17; // Fiyat

            // Toplam fiyatı hesapla
            decimal totalPrice = value * productPrice;

            // Ürün sayısını ve toplam fiyatı tek satırda birleştir
            string itemToAdd = $"{value} adet {productName} = {totalPrice:F2} TL"; // Para birimi sembolü olmadan

            // Mevcut ListBox içeriğini kontrol et
            bool itemUpdated = false;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                string existingItem = listBox1.Items[i].ToString();
                if (existingItem.Contains(productName)) // Eğer ürün ListBox'ta varsa
                {
                    if (value > 0)
                    {
                        listBox1.Items[i] = itemToAdd; // Mevcut öğeyi güncelle
                    }
                    else
                    {
                        listBox1.Items.RemoveAt(i); // Ürün miktarı sıfırsa kaldır
                        UpdateTotalPrice(); // Toplam fiyatı güncelle
                    }
                    itemUpdated = true;
                    break;
                }
            }

            // Ürün ListBox'ta yoksa ve miktar > 0 ise ekle
            if (!itemUpdated && value > 0)
            {
                listBox1.Items.Add(itemToAdd);
            }

            UpdateTotalPrice(); // Her durumda toplam fiyatı güncelle
        }

        private void numericUpDown25_ValueChanged(object sender, EventArgs e)
        {// NumericUpDown25'ün değeri
            int selectedValue = (int)numericUpDown25.Value;

          

            // Stok sayısını 4'ten fazla olup olmadığını kontrol et
            if (selectedValue > 4)
            {
                // Kullanıcıya uyarı ver
                MessageBox.Show("Stok sayısını aşamazsınız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Değeri geri al
                numericUpDown25.Value = 0;
            }
         




            // NumericUpDown'dan seçilen değer
            int value = (int)((NumericUpDown)sender).Value;
            string productName = "Kiraz"; // Ürün adı
            decimal productPrice = 85; // Fiyat

            // Toplam fiyatı hesapla
            decimal totalPrice = value * productPrice;

            // Ürün sayısını ve toplam fiyatı tek satırda birleştir
            string itemToAdd = $"{value} kg {productName} = {totalPrice:F2} TL"; // Para birimi sembolü olmadan

            // Mevcut ListBox içeriğini kontrol et
            bool itemUpdated = false;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                string existingItem = listBox1.Items[i].ToString();
                if (existingItem.Contains(productName)) // Eğer ürün ListBox'ta varsa
                {
                    if (value > 0)
                    {
                        listBox1.Items[i] = itemToAdd; // Mevcut öğeyi güncelle
                    }
                    else
                    {
                        listBox1.Items.RemoveAt(i); // Ürün miktarı sıfırsa kaldır
                        UpdateTotalPrice(); // Toplam fiyatı güncelle
                    }
                    itemUpdated = true;
                    break;
                }
            }

            // Ürün ListBox'ta yoksa ve miktar > 0 ise ekle
            if (!itemUpdated && value > 0)
            {
                listBox1.Items.Add(itemToAdd);
            }

            UpdateTotalPrice(); // Her durumda toplam fiyatı güncelle
        }

        private void numericUpDown26_ValueChanged(object sender, EventArgs e)
        {


            // NumericUpDown26'ün değeri
            int selectedValue = (int)numericUpDown26.Value;

       

            // Stok sayısını 3'ten fazla olup olmadığını kontrol et
            if (selectedValue > 3)
            {
                // Kullanıcıya uyarı ver
                MessageBox.Show("Stok sayısını aşamazsınız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Değeri geri al
                numericUpDown26.Value = 0;
            }
           

            // NumericUpDown'dan seçilen değer
            int value = (int)((NumericUpDown)sender).Value;
            string productName = "Salatalık"; // Ürün adı
            decimal productPrice = 60; // Fiyat

            // Toplam fiyatı hesapla
            decimal totalPrice = value * productPrice;

            // Ürün sayısını ve toplam fiyatı tek satırda birleştir
            string itemToAdd = $"{value} kg {productName} = {totalPrice:F2} TL"; // Para birimi sembolü olmadan

            // Mevcut ListBox içeriğini kontrol et
            bool itemUpdated = false;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                string existingItem = listBox1.Items[i].ToString();
                if (existingItem.Contains(productName)) // Eğer ürün ListBox'ta varsa
                {
                    if (value > 0)
                    {
                        listBox1.Items[i] = itemToAdd; // Mevcut öğeyi güncelle
                    }
                    else
                    {
                        listBox1.Items.RemoveAt(i); // Ürün miktarı sıfırsa kaldır
                        UpdateTotalPrice(); // Toplam fiyatı güncelle
                    }
                    itemUpdated = true;
                    break;
                }
            }

            // Ürün ListBox'ta yoksa ve miktar > 0 ise ekle
            if (!itemUpdated && value > 0)
            {
                listBox1.Items.Add(itemToAdd);
            }

            UpdateTotalPrice(); // Her durumda toplam fiyatı güncelle
        }

        private void numericUpDown27_ValueChanged(object sender, EventArgs e)
        {



            // NumericUpDown27'nin değeri
            int selectedValue = (int)numericUpDown27.Value;

            

            // Stok sayısını 2'den fazla olup olmadığını kontrol et
            if (selectedValue > 2)
            {
                // Kullanıcıya uyarı ver
                MessageBox.Show("Stok sayısını aşamazsınız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Değeri geri al
                numericUpDown27.Value = 0;
            }
          




            // NumericUpDown'dan seçilen değer
            int value = (int)((NumericUpDown)sender).Value;
            string productName = "Muzlu Popkek"; // Ürün adı
            decimal productPrice = 15; // Fiyat

            // Toplam fiyatı hesapla
            decimal totalPrice = value * productPrice;

            // Ürün sayısını ve toplam fiyatı tek satırda birleştir
            string itemToAdd = $"{value} adet {productName} = {totalPrice:F2} TL"; // Para birimi sembolü olmadan

            // Mevcut ListBox içeriğini kontrol et
            bool itemUpdated = false;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                string existingItem = listBox1.Items[i].ToString();
                if (existingItem.Contains(productName)) // Eğer ürün ListBox'ta varsa
                {
                    if (value > 0)
                    {
                        listBox1.Items[i] = itemToAdd; // Mevcut öğeyi güncelle
                    }
                    else
                    {
                        listBox1.Items.RemoveAt(i); // Ürün miktarı sıfırsa kaldır
                        UpdateTotalPrice(); // Toplam fiyatı güncelle
                    }
                    itemUpdated = true;
                    break;
                }
            }

            // Ürün ListBox'ta yoksa ve miktar > 0 ise ekle
            if (!itemUpdated && value > 0)
            {
                listBox1.Items.Add(itemToAdd);
            }

            UpdateTotalPrice(); // Her durumda toplam fiyatı güncelle
        }

        private void pictureBox50_Click(object sender, EventArgs e)
        {
            tabControl2.Visible = false;
            tabControl1.Visible = true;
            tabControl1.SelectedTab = tabPage7;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Size = new Size(this.ClientSize.Width, this.ClientSize.Height);
        }

        private void pictureBox53_Click(object sender, EventArgs e)
        {
            tabControl2.Visible = false;
            tabControl1.Visible = true;
            tabControl1.SelectedTab = tabPage7;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Size = new Size(this.ClientSize.Width, this.ClientSize.Height);
        }

        private void pictureBox56_Click(object sender, EventArgs e)
        {
            tabControl2.Visible = false;
            tabControl1.Visible = true;
            tabControl1.SelectedTab = tabPage7;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Size = new Size(this.ClientSize.Width, this.ClientSize.Height);
        }

        private void pictureBox66_Click(object sender, EventArgs e)
        {
            tabControl2.Visible = false;
            tabControl1.Visible = true;
            tabControl1.SelectedTab = tabPage7;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Size = new Size(this.ClientSize.Width, this.ClientSize.Height);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            label65.Text = textBox1.Text;

            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
            return;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


   

        private void button4_Click(object sender, EventArgs e)
        {
            timer2.Start();

            string sifre = textBox2.Text;
            if (sifre == "123")
            {
                
                tabControl1.SelectedTab = tabPage9; // TabPage'yi seç
               
           
            }
            else
            {
                
                MessageBox.Show("Şifreyi yanlış girdiniz");
                textBox2.Clear();
                return;
            }
        }
        

        



        private void timer1_Tick_1(object sender, EventArgs e)
        {
            label71.Text = saniye--.ToString() + " sn"; // Geri sayımın her tıklamada 1 saniye azalması

            if (saniye == -1)
            {
                timer1.Stop();
                MessageBox.Show("Süreniz doldu");
                label71.Enabled = false;
                button5.Visible = true;
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            saniye = 120;
            label71.Enabled = true;
            label71.Text = saniye.ToString() + " sn";
            button5.Visible = false;
            timer1.Start();

        }



        private void progressBar1_Click(object sender, EventArgs e)
        {

        }




       



        private void timer2_Tick(object sender, EventArgs e)
        {
            // Timer2 intervalini burada her defasında değiştirmeye gerek yok
            if (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.Value++;
            }
            else if (progressBar1.Value >= progressBar1.Maximum)
            {
                timer2.Stop();
                tabPage10.Visible = true;
                tabControl1.SelectedTab = tabPage10;
                label82.Text = label65.Text;
            }

        }

        private void label65_Click(object sender, EventArgs e)
        {

        }

        private void label82_Click(object sender, EventArgs e)
        {

        }


        public void ResetFormControls(Control parent)
        {




        }





        private void button6_Click(object sender, EventArgs e)
        {
            tabControl2.Visible = false;
            tabControl1.Visible = false;
            ResetFormControls(this);
            listBox1.Items.Clear();
            textBox1.Clear();
            textBox2.Clear();

            numericUpDown4.Value = 0;
            numericUpDown5.Value = 0;
            numericUpDown6.Value = 0;
            numericUpDown7.Value = 0;
            numericUpDown8.Value = 0;
            numericUpDown9.Value = 0;
            numericUpDown10.Value = 0;
            numericUpDown11.Value = 0;
            numericUpDown12.Value = 0;
            numericUpDown13.Value = 0;
            numericUpDown14.Value = 0;
            numericUpDown15.Value = 0;
            numericUpDown16.Value = 0;
            numericUpDown17.Value = 0;
            numericUpDown18.Value = 0;
            numericUpDown19.Value = 0;
            numericUpDown20.Value = 0;
            numericUpDown21.Value = 0;
            numericUpDown22.Value = 0;
            numericUpDown23.Value = 0;
            numericUpDown24.Value = 0;
            numericUpDown25.Value = 0;
            numericUpDown26.Value = 0;
            numericUpDown27.Value = 0;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {

            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void pictureBox49_Click(object sender, EventArgs e)
        {

            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void pictureBox52_Click(object sender, EventArgs e)
        {

            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void pictureBox55_Click(object sender, EventArgs e)
        {

            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void pictureBox58_Click(object sender, EventArgs e)
        {

            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void pictureBox65_Click(object sender, EventArgs e)
        {

            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void pictureBox74_Click(object sender, EventArgs e)
        {

            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void tabPage9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();

        }


      



        private void tabPage10_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage11_Click(object sender, EventArgs e)
        {

        }
    }
}
