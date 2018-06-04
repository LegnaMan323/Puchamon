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
            ponys.attack_Enemigo();
            pbrYourLife.Value = ponys.vidaPony();
        }

        private void btnDefend_Click(object sender, EventArgs e)
        {
            ponys.defenderse();
        }

        private void btnHeal_Click(object sender, EventArgs e)
        {
            ponys.curarse();
            pbrYourLife.Value = ponys.vidaPony();
        }
    }
}
