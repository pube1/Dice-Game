namespace dicegame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            computer computer = new computer();
            this.Hide();
            computer.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            player player = new player();
            this.Hide();
            player.Show();
        }
    }
}
