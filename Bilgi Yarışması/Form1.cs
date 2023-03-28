using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilgi_Yarışması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruno = 0, dogru = 0, yanlıs = 0;

       

        private void btnsonraki_Click(object sender, EventArgs e)
        {
            btna.Enabled = true;
            btnb.Enabled = true;
            btnc.Enabled = true;
            btnd.Enabled = true;
            btnsonraki.Enabled = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

            soruno++;
            lblsoru.Text = soruno.ToString();
            if(soruno == 1)
            {
                richTextBox1.Text = "Kürk Mantolu Madona eseri kime aittir?";
                btna.Text = "cemal süreyya";
                btnb.Text = "sabahattin ali";
                btnc.Text = "yaşar kemal";
                btnd.Text = "kemal tahir";
                label4.Text = "sabahattin ali";


            }
            if(soruno == 2)
            {
                richTextBox1.Text = "2022 İnterpol toplantısı hangi ülkede yapılacak?";
                btna.Text = "almanya";
                btnb.Text = "fransa";
                btnc.Text = "ispanya";
                btnd.Text = "türkiye";
                label4.Text = "ispanya";
            }
            if(soruno==3)
            {
                richTextBox1.Text = "2024 Yaz Olimpiyatları hangi şehirde yapılacak?";
                btna.Text = "berlin";
                btnb.Text = "ankara";
                btnc.Text = "tokyo";
                btnd.Text = "paris";
                label4.Text = "paris";
            }
            if(soruno==4)
            {
                richTextBox1.Text = "UNESCO İnsanlığın Somut Olmayan Kültürel Mirası Temsili Listesi'ne alınan Türk stateji ve zeka oyunu aşağıdakilerden hangisidir?";
                btna.Text = "5 taş";
                btnb.Text = "dama";
                btnc.Text = "satranç";
                btnd.Text = "mangala";
                label4.Text = "mangala";
                btnsonraki.Text = "sonuçlar";
              


            }
            if (soruno == 5)
            {
                btna.Enabled = false;
                btnb.Enabled = false;
                btnc.Enabled = false;
                btnd.Enabled = false;
                btnsonraki.Enabled = false;
              
                MessageBox.Show("doğru :" + dogru + "\n" + "yanlış :" + yanlıs);

            }

           



        
        }

       

        private void btna_Click(object sender, EventArgs e)
        {   
        
            btna.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;
            btnsonraki.Enabled = true;

            label5.Text = btna.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                lbldogru.Text =dogru.ToString();
                pictureBox2.Visible = true;

            }
            else
            {
                yanlıs++;
                lblyanlıs.Text =yanlıs.ToString();
                pictureBox1.Visible = true;
            }
        }

       

        private void btnb_Click(object sender, EventArgs e)
        {
            btna.Enabled=false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;
            btnsonraki.Enabled = true;

            label5.Text = btnb.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                lbldogru.Text = dogru.ToString();
                pictureBox2.Visible = true;

            }
            else
            {
                yanlıs++;
                lblyanlıs.Text = yanlıs.ToString();
                pictureBox1.Visible = true;
            }


        }
        private void btnc_Click(object sender, EventArgs e)
        {
            btna.Enabled=false;
            btnb.Enabled=false;
            btnc.Enabled=false;
            btnd.Enabled=false;
            btnsonraki.Enabled = true;

            label5.Text = btnc.Text;
            if (label5.Text == label4.Text)
            {
                dogru++;
                lbldogru.Text = dogru.ToString();
                pictureBox2.Visible=true;

            }
            else
            {
                yanlıs++;
                lblyanlıs.Text = yanlıs.ToString();
                pictureBox1.Visible = true;



            }



        }
        private void btnd_Click(object sender, EventArgs e)
        {
            btna.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;
            btnsonraki.Enabled = true;

            label5.Text = btnd.Text;
            if (label5.Text == label4.Text)
            {
                dogru++;
                lbldogru.Text = dogru.ToString();
                pictureBox2.Visible = true;

            }
            else
            {
                yanlıs++;
                lblyanlıs.Text = yanlıs.ToString();
                pictureBox1.Visible = true;



            }


        }






    }

}
