using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Appli1
{
    public partial class FRM_Appli1 : Form
    {
        public FRM_Appli1()
        {
            InitializeComponent();
            this.Gbx_Parametres.Visible = false;
        }

        private void Btn_OK_Click(object sender, EventArgs e)
        {
            this.Gbx_Temperateur.Enabled = false;
            this.Gbx_Vitesse.Enabled = false;
            this.Gbx_Parametres.Visible = true;

            if (Rbt_Vitesse_100.Checked)
            {
                this.Txt_Vitesse_retenue.Text = this.Rbt_Vitesse_100.Text;
            }else if (Rbt_Vitesse_200.Checked)
            {
                this.Txt_Vitesse_retenue.Text = this.Rbt_Vitesse_200.Text;
            }
            else if(Rbt_Vitesse_300.Checked)
            {
                this.Txt_Vitesse_retenue.Text = this.Rbt_Vitesse_300.Text;
            }else if (Rbt_Vitesse_500.Checked)
            {
                this.Txt_Vitesse_retenue.Text = this.Rbt_Vitesse_500.Text;
            }


            if (Rbt_Temp_100.Checked)
            {
                this.Txt_Temp_retenue.Text = this.Rbt_Temp_100.Text;
            }
            else if (Rbt_Temp_80.Checked)
            {
                this.Txt_Temp_retenue.Text = this.Rbt_Temp_80.Text;
            }
            else if (Rbt_Temp_50.Checked)
            {
                this.Txt_Temp_retenue.Text = this.Rbt_Temp_50.Text;
            }
            

        }

        private void Btn_Retablir_Click(object sender, EventArgs e)
        {
            this.Gbx_Temperateur.Enabled = true;
            this.Gbx_Vitesse.Enabled = true;
            this.Gbx_Parametres.Visible = false;
        }

        private void Btn_Quitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
