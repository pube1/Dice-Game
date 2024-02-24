using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dicegame
{
    public partial class player : Form
    {
        public player()
        {
            InitializeComponent();
        }
        int oyuncu1zar1;
        int oyuncu1zar2;
        int total;
        private void button1_Click(object sender, EventArgs e)
        {
            dice1player11.Visible = false;
            dice1player12.Visible = false;
            dice1player13.Visible = false;
            dice1player14.Visible = false;
            dice1player15.Visible = false;
            dice1player16.Visible = false;
            dice2player11.Visible = false;
            dice2player12.Visible = false;
            dice2player13.Visible = false;
            dice2player14.Visible = false;
            dice2player15.Visible = false;
            dice2player16.Visible = false;

            dice1player21.Visible = false;
            dice1player22.Visible = false;
            dice1player23.Visible = false;
            dice1player24.Visible = false;
            dice1player25.Visible = false;
            dice1player26.Visible = false;

            dice2player21.Visible = false;
            dice2player22.Visible = false;
            dice2player23.Visible = false;
            dice2player24.Visible = false;
            dice2player25.Visible = false;
            dice2player26.Visible = false;
            Random random = new Random();

            oyuncu1zar1 = random.Next(1, 7);
            oyuncu1zar2 = random.Next(1, 7);
            total = oyuncu1zar1 + oyuncu1zar2;

            zar1oyuncu1Txt.Text = oyuncu1zar1.ToString();
            zar2oyuncu1Txt.Text = oyuncu1zar2.ToString();
            totalvalue1txt.Text = total.ToString();

            // first dice png
            if (oyuncu1zar1 == 1)
                dice1player11.Visible = true;
            else if (oyuncu1zar1 == 2)
                dice1player12.Visible = true;
            else if (oyuncu1zar1 == 3)
                dice1player13.Visible = true;
            else if (oyuncu1zar1 == 4)
                dice1player14.Visible = true;
            else if (oyuncu1zar1 == 5)
                dice1player15.Visible = true;
            else if (oyuncu1zar1 == 6)
                dice1player16.Visible = true;
            // second dice png
            if (oyuncu1zar2 == 1)
                dice2player11.Visible = true;
            else if (oyuncu1zar2 == 2)
                dice2player12.Visible = true;
            else if (oyuncu1zar2 == 3)
                dice2player13.Visible = true;
            else if (oyuncu1zar2 == 4)
                dice2player14.Visible = true;
            else if (oyuncu1zar2 == 5)
                dice2player15.Visible = true;
            else if (oyuncu1zar2 == 6)
                dice2player16.Visible = true;

            sira1Txt.Visible = false;
            sira2Txt.Visible = true;
            button1.Enabled = false;
            button2.Enabled = true;
        }
        int oyuncu2zar1;
        int oyuncu2zar2;
        int total2;

        private void button2_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            oyuncu2zar1 = random.Next(1, 7);
            oyuncu2zar2 = random.Next(1, 7);
            total2 = oyuncu2zar1 + oyuncu2zar2;

            zar1oyuncu2Txt.Text = oyuncu2zar1.ToString();
            zar2oyuncu2Txt.Text = oyuncu2zar2.ToString();
            totalvalue2txt.Text = total2.ToString();
            // first dice png
            if (oyuncu2zar1 == 1)
                dice1player21.Visible = true;
            else if (oyuncu2zar1 == 2)
                dice1player23.Visible = true;
            else if (oyuncu2zar1 == 3)
                dice1player24.Visible = true;
            else if (oyuncu2zar1 == 4)
                dice1player25.Visible = true;
            else if (oyuncu2zar1 == 5)
                dice1player26.Visible = true;
            else if (oyuncu2zar1 == 6)
                dice1player26.Visible = true;
            // second dice png
            if (oyuncu2zar2 == 1)
                dice2player21.Visible = true;
            else if (oyuncu2zar2 == 2)
                dice2player22.Visible = true;
            else if (oyuncu2zar2 == 3)
                dice2player23.Visible = true;
            else if (oyuncu2zar2 == 4)
                dice2player24.Visible = true;
            else if (oyuncu2zar2 == 5)
                dice2player25.Visible = true;
            else if (oyuncu2zar2 == 6)
                dice2player26.Visible = true;

            if (total > total2)
            {
                MessageBox.Show("Player 1 is winner!");
                MessageBox.Show("You can click on the roll dice button to play again.");

            }

            else if (total < total2)
            {
                MessageBox.Show("Player 2 is winner!");
                MessageBox.Show("You can click on the roll dice button to play again.");
            }

            else { MessageBox.Show("Draw"); MessageBox.Show("You can click on the roll dice button to play again."); }

            button1.Enabled = true;
            button2.Enabled = false;
            sira1Txt.Visible = true;
            sira2Txt.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
