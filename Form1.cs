using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private SoundPlayer ses;
        public Form1()
        {
            InitializeComponent();
            ses = new SoundPlayer("tokyo.wav");
        }
        int birinciarabauzaklık, ikinciarabauzaklık, üçüncüarabauzaklık;
        Random rastgale = new Random();


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            birinciarabauzaklık = pictureBox1.Left;
            ikinciarabauzaklık = pictureBox2.Left;
            üçüncüarabauzaklık = pictureBox3.Left;

        }

        private void timer1_Tick(object sender, EventArgs e)

        {
            int birinciarabanıngenişliği = pictureBox1.Width;
            int kinciarabanıngenişliği = pictureBox2.Width;
            int üçüncüarabanıngenişliği = pictureBox3.Width;
            int bitişuzaklığı =label5.Left;
            int derece = Convert.ToInt32(label7.Text);
            derece++;
            label7.Text = derece.ToString();


            pictureBox1.Left = pictureBox1.Left + rastgale.Next(5, 15);
            pictureBox2.Left = pictureBox2.Left + rastgale.Next(5, 15);
            pictureBox3.Left = pictureBox3.Left + rastgale.Next(5, 15);
            
            if(pictureBox1.Left>pictureBox2.Left+5 && pictureBox1.Left>pictureBox3.Left + 5)
            {
                label6.Text = "1 numaralı araba yarışı önde götürüyor";
            }
            if(pictureBox2.Left>pictureBox1.Left+5&&pictureBox2.Left>pictureBox3.Left+5)
            {
                label6.Text = "2 numaralı araba bi anda öne geçti";

            }
            if(pictureBox3.Left>pictureBox2.Left+5&&pictureBox3.Left>pictureBox1.Left+5)
            {
                label6.Text = "3 numaralı araba çok hızlı şekilde öne gecti";
            }


            if(birinciarabanıngenişliği+pictureBox1.Left>=bitişuzaklığı)
            {
                timer1.Enabled = false;
               label6.Text=("1 numaralı araba yarışı kazandı!!!");
               ses.Stop();
               

            }
            if (kinciarabanıngenişliği + pictureBox2.Left >= bitişuzaklığı) 
            {
            timer1.Enabled = false;
            label6.Text = ("2 numaralı araba yarışı kazandı!!!");
            ses.Stop();
        }

            if (üçüncüarabanıngenişliği + pictureBox3.Left >= bitişuzaklığı) 
            {
                timer1.Enabled = false;
                label6.Text = ("3 numaralı araba yarışı kazandı!!!");
                ses.Stop();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
           
            timer1.Enabled=true;
            ses.Play();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
