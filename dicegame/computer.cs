using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dicegame
{
    public partial class computer : Form
    {
        public computer()
        {
            InitializeComponent();
        }

        int delay;
        private void button1_Click(object sender, EventArgs e)
        {
            dice1pc1.Visible = false;
            dice1pc2.Visible = false;
            dice1pc3.Visible = false;
            dice1pc4.Visible = false;
            dice1pc5.Visible = false;
            dice1pc6.Visible = false;
            dice2pc1.Visible = false;
            dice2pc2.Visible = false;
            dice2pc3.Visible = false;
            dice2pc4.Visible = false;
            dice2pc5.Visible = false;
            dice2pc6.Visible = false;

            dice1player1.Visible = false;
            dice1player2.Visible = false;
            dice1player3.Visible = false;
            dice1player4.Visible = false;
            dice1player5.Visible = false;
            dice1player6.Visible = false;

            dice2player1.Visible = false;
            dice2player2.Visible = false;
            dice2player3.Visible = false;
            dice2player4.Visible = false;
            dice2player5.Visible = false;
            dice2player6.Visible = false;


            Random rnd1 = new Random();


            delay = 0;
            int oyuncuzar1 = rnd1.Next(1, 7);
            int oyuncuzar2 = rnd1.Next(1, 7);
            int toplamOyuncu = oyuncuzar1 + oyuncuzar2;

            zar1OyuncuTxt.Text = oyuncuzar1.ToString();
            zar2OyuncuTxt.Text = oyuncuzar2.ToString();
            toplamoynTxt.Text = toplamOyuncu.ToString();

            //first dice png
            if (oyuncuzar1 == 1)
                dice1player1.Visible = true;
            else if (oyuncuzar1 == 2)
                dice1player2.Visible = true;
            else if (oyuncuzar1 == 3)
                dice1player3.Visible = true;
            else if (oyuncuzar1 == 4)
                dice1player4.Visible = true;
            else if (oyuncuzar1 == 5)
                dice1player5.Visible = true;
            else if (oyuncuzar1 == 6)
                dice1player6.Visible = true;
            // second dice png
            if (oyuncuzar2 == 1)
                dice2player1.Visible = true;
            else if (oyuncuzar2 == 2)
                dice2player2.Visible = true;
            else if (oyuncuzar2 == 3)
                dice2player3.Visible = true;
            else if (oyuncuzar2 == 4)
                dice2player4.Visible = true;
            else if (oyuncuzar2 == 5)
                dice2player5.Visible = true;
            else if (oyuncuzar2 == 6)
                dice2player6.Visible = true;


            MessageBox.Show("Bilgisayar Bekleniyor...");


            int bilgisayarzar1 = rnd1.Next(1, 7);
            int bilgisayarzar2 = rnd1.Next(1, 7);
            int toplamBilgisayar = bilgisayarzar1 + bilgisayarzar2;

            zar1BilgisayarTxt.Text = bilgisayarzar1.ToString();
            zar2BilgisayarTxt.Text = bilgisayarzar2.ToString();
            toplamBilgTxt.Text = toplamBilgisayar.ToString();

            if (bilgisayarzar1 == 1)
                dice1pc1.Visible = true;
            else if (bilgisayarzar1 == 2)
                dice1pc2.Visible = true;
            else if (bilgisayarzar1 == 3)
                dice1pc3.Visible = true;
            else if (bilgisayarzar1 == 4)
                dice1pc4.Visible = true;
            else if (bilgisayarzar1 == 5)
                dice1pc5.Visible = true;
            else if (bilgisayarzar1 == 6)
                dice1pc6.Visible = true;
            // second dice png
            if (bilgisayarzar2 == 1)
                dice2pc1.Visible = true;
            else if (bilgisayarzar2 == 2)
                dice2pc2.Visible = true;
            else if (bilgisayarzar2 == 3)
                dice2pc3.Visible = true;
            else if (bilgisayarzar2 == 4)
                dice2pc4.Visible = true;
            else if (bilgisayarzar2 == 5)
                dice2pc5.Visible = true;
            else if (bilgisayarzar2 == 6)
                dice2pc6.Visible = true;

            if (toplamOyuncu > toplamBilgisayar)
            {
                MessageBox.Show("Oyuncu Kazandı! Tekrar oynamak için zar at tuşuna tıklayın.");
            }

            else
            {
                MessageBox.Show("Bilgisayar Kazandı! Tekrar oynamak için zar at tuşuna tıklayın.");
            }



        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
