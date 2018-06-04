using System;
using System.Windows.Forms;




namespace PoekmonV1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            pctPokePick2.ImageLocation = "D:/David/Documents/UAD/5to/D-UI/Proto-TypeJuan/PoekmonV1/Pokes/" + comboBox2.Text + ".png";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pctPokePick1.ImageLocation = "D:/David/Documents/UAD/5to/D-UI/Proto-TypeJuan/PoekmonV1/Pokes/" + comboBox1.Text + ".png";
        }

        private void btnBattle_Click(object sender, EventArgs e)
        {
            this.Hide();
            Battle_ newBattle = new Battle_();
            newBattle.Show();
        }
    }
}
