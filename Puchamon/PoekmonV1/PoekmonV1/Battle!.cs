using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace PoekmonV1
{
    public partial class Battle_ : Form
    {
        private int iattack = 5;
        private int iHeal = 10;
        private int Health = 0;
     


        public Battle_()
        {
            InitializeComponent();
        }
      
        

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnAttack_Click(object sender, EventArgs e)
        {
            if (pbrYourLife.Value > 0) 
            {
                pbrFoesLife.Value-=iattack;
                pbrYourLife.Value -= iattack;
                txtActions.Text = "YOU CHARGE DEALING 7DMG";
                txtFoesActions.Text = "FOE DEALS 7 DMG biatch";

            }
            if (pbrYourLife.Value == 0)
            {
                MessageBox.Show("You Looser!");
                this.Hide();
                Form1 NewFight = new Form1();
                NewFight.Show();
            }
            if (pbrFoesLife.Value == 0)
            {
                MessageBox.Show("You Win!");
                this.Hide();
                Form1 NewFight = new Form1();
                NewFight.Show();

            }

        }

        private void btnHeal_Click(object sender, EventArgs e)
        {
            if (pbrYourLife.Value > 0)
            {
                pbrYourLife.Value -= iattack/2;
                txtActions.Text = "YOU Use defense";
                txtFoesActions.Text = "FOE DEALS 2.5 DMG biatch";

            }
            if (pbrYourLife.Value == 0)
            {
                MessageBox.Show("You Looser!");
                this.Hide();
                Form1 NewFight = new Form1();
                NewFight.Show();
            }
            if (pbrFoesLife.Value == 0)
            {
                MessageBox.Show("You Win!");
                this.Hide();
                Form1 NewFight = new Form1();
                NewFight.Show();
            }
        }

        private void btnDefend_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 NewFight = new Form1();
            NewFight.Show();
        }
           

        private void btnHeal_Click_1(object sender, EventArgs e)
        {
            if (pbrYourLife.Value > 0 && pbrYourLife.Value < 20)
            {
                pbrYourLife.Value += iHeal;
                pbrYourLife.Value -= iattack;
                txtActions.Text = "YOU Use Heal - Recover 10 Hp";
                txtFoesActions.Text = "FOE DEALS 5 DMG biatch";

            }
            else
            {
                txtActions.Text = "CANT DO THAT NOW";
            }
        }

        private void cbxObjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            pctObjs.ImageLocation = "D:/David/Documents/UAD/5to/D-UI/Proto-TypeJuan/PoekmonV1/Objs/" + cbxObjects.Text + ".png";

        }
    }
}
