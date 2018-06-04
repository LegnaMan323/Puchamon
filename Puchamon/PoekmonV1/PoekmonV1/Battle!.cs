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
        }

        private void btnAttack_Click(object sender, EventArgs e)
        {
            ponys.attack();
            pbrFoesLife.Value = ponys.vidaPony_Enemigo();
            timer1.Enabled = true;
            btnAttack.Enabled = false;
            btnDefend.Enabled = false;
            btnHeal.Enabled = false;
              
        }

        private void btnDefend_Click(object sender, EventArgs e)
        {
            ponys.defenderse();
            timer1.Enabled = true;
            btnAttack.Enabled = false;
            btnDefend.Enabled = false;
            btnHeal.Enabled = false;
        }

        private void btnHeal_Click(object sender, EventArgs e)
        {
            ponys.curarse();
            pbrYourLife.Value = ponys.vidaPony();
            timer1.Enabled = true;
            btnAttack.Enabled = false;
            btnDefend.Enabled = false;
            btnHeal.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
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
                }

                if (randomNumber == 4)
                {
                    ponys.defenderse_Enemigo();
                    btnAttack.Enabled = true;
                    btnDefend.Enabled = true;
                    btnHeal.Enabled = true;
                }

                if (randomNumber == 3)
                {
                    ponys.curarse_Enemigo();
                    pbrFoesLife.Value = ponys.vidaPony_Enemigo();
                    btnAttack.Enabled = true;
                    btnDefend.Enabled = true;
                    btnHeal.Enabled = true;
                }

            }
        }
    }
}
