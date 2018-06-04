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
        Pelea_Ponys ponys = new Pelea_Ponys();
        int contador = 0;
        public Battle_()
        {
            InitializeComponent();

            ponys.Ponys_define();
            pbrFoesLife.Value = ponys.vidaPony_Enemigo();
            pbrYourLife.Value = ponys.vidaPony();
            lblNameu.Text = ponys.P1name();
            label1.Text = ponys.P2name();
        }

        private void btnAttack_Click(object sender, EventArgs e)
        {
            if (pbrFoesLife.Value == 0)
            {
                MessageBox.Show("You Win!");
                
            }
            ponys.attack();
            pbrFoesLife.Value = ponys.vidaPony_Enemigo();
            timer1.Enabled = true;
            btnAttack.Enabled = false;
            btnDefend.Enabled = false;
            btnHeal.Enabled = false;
            txtActions.Text = "You deal Damage";


        }

        private void btnDefend_Click(object sender, EventArgs e)
        {
            ponys.defenderse();
            timer1.Enabled = true;
            btnAttack.Enabled = false;
            btnDefend.Enabled = false;
            btnHeal.Enabled = false;
            txtActions.Text = "You use defense";


        }

        private void btnHeal_Click(object sender, EventArgs e)
        {
            
            if (pbrYourLife.Value < 90)
            {
                ponys.curarse();
                pbrYourLife.Value = ponys.vidaPony();
                timer1.Enabled = true;
                btnAttack.Enabled = false;
                btnDefend.Enabled = false;
                btnHeal.Enabled = false;
                txtActions.Text = "You used Heal";

            }
            else
            {
                txtActions.Text = "Can't do that";
            }

        }
        

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtActions.Text = " ";
            txtFoesActions.Text = " ";
            contador += 1;
            if (contador == 2)
              
            {
                timer1.Enabled = false;
                contador = 0;

                Random rand = new Random();
                int randomNumber = rand.Next(1, 4);

                if (randomNumber == 1 || randomNumber == 2)
                {
                    ponys.attack_Enemigo();
                    pbrYourLife.Value = ponys.vidaPony();
                    btnAttack.Enabled = true;
                    btnDefend.Enabled = true;
                    btnHeal.Enabled = true;
                    txtFoesActions.Text = "Pony2 deals Damage";

                }

                if (randomNumber == 4)
                {
                    ponys.defenderse_Enemigo();
                    btnAttack.Enabled = true;
                    btnDefend.Enabled = true;
                    btnHeal.Enabled = true;
                    txtFoesActions.Text = "Pony2 uses defend";
                }

                if (randomNumber == 3 && pbrFoesLife.Value < 85)
                {
                    ponys.curarse_Enemigo();
                    pbrFoesLife.Value = ponys.vidaPony_Enemigo();
                    btnAttack.Enabled = true;
                    btnDefend.Enabled = true;
                    btnHeal.Enabled = true;
                    txtFoesActions.Text = "Pony2 uses Heal";

                }
               

                if (pbrFoesLife.Value == 0 )
                {
                    MessageBox.Show("You Win!");
                    this.Hide();
                    Form1 newGame = new Form1();
                    newGame.Show();
                }
                if ( pbrYourLife.Value == 0)
                {
                    MessageBox.Show("You Loose!");
                    this.Hide();
                    Form1 newGame = new Form1();
                    newGame.Show();
                }

            }
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 newGame = new Form1();
            newGame.Show();
        }

        
    }
}

