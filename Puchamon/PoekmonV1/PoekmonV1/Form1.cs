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
        public void CPony1()
        {
            Puchamon Pony1 = new Puchamon();
        }


        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            pctPokePick2.ImageLocation = "D:/David/Documents/UAD/5to/D-UI/Proto-TypeJuan/PoekmonV1/Pokes/" + comboBox2.Text + ".png";
            if(comboBox2.Text == "Pony1")
            {
                //   DefineP1
               
            }
            if(comboBox2.Text == "Pony2")
            {

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pctPokePick1.ImageLocation = "D:/David/Documents/UAD/5to/D-UI/Proto-TypeJuan/PoekmonV1/Pokes/" + comboBox1.Text + ".png";
            if (comboBox1.Text == "Pony1")
            {
                //   DefineP1
            }
            if (comboBox1.Text == "Pony2")
            {

            }
        }

        private void btnBattle_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Pony1")
            { CPony1(); }
            this.Hide();
            Battle_ newBattle = new Battle_();
            newBattle.Show();
        }
    }
}
