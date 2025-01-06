using System.Windows.Forms;

namespace PROJE_ÖDEVİ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MakePictureBoxCircular(PictureBox pictureBox)
        {
            // Yuvarlak bir bölge oluştur
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, pictureBox.Width, pictureBox.Height);

            // PictureBox'ın alanını bu bölgeye ayarla
            pictureBox.Region = new Region(path);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            MakePictureBoxCircular(pictureBox2);


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad = textBox1.Text;
            string sifre = textBox2.Text;

            // Form4'ün örneğini oluştur
            Form4 form4 = new Form4();

            if (ad == "Elif" && sifre == "123") // kullanıcı girisi icin,
            {

                Form2 form2 = new Form2();
                form2.Show();
                form2.tabControl2.Visible = false;
                this.Hide();
                return;
            }


            else
            {
                label3.Text = "Yanlış kullanıcı adı veya şifre, yeniden deneyin.";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}


