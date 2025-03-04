using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        void atribuirOperacao(string oper)
        {
            lbloper.Text = oper;
            btigual.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btsoma_Click(object sender, EventArgs e)
        {
            atribuirOperacao(btsoma.Text);
        }

        private void btsub_Click(object sender, EventArgs e)
        {
            atribuirOperacao(btsub.Text);
        }

        private void btmult_Click(object sender, EventArgs e)
        {
            atribuirOperacao(btmult.Text);
        }

        private void btdiv_Click(object sender, EventArgs e)
        {
            atribuirOperacao(btdiv.Text);
            Travarbotao();
        }
        double resultado;
        private void btigual_Click(object sender, EventArgs e)
        {
            double num1, num2 ;
            num1 = (double)numOper1.Value;
            num2 = (double)numOper2.Value;

            if (lbloper.Text == btsoma.Text)
                resultado = num1 + num2;
            else if (lbloper.Text == btsub.Text)
                resultado = num2 - num1;
            else if (lbloper.Text == btmult.Text)
                resultado = num1 * num2;
            else
                resultado = num1 / num2;

            lblresult.Text = resultado.ToString();
            ativarBotaoSegue();
        }
        void Travarbotao()
        {
            /*if ((lbloper.Text == btdiv.Text && numOper2.Value == 0)
             || lbloper.Text == *...*)
                btigual.Enabled = false;
            else
                btigual.Enabled = true;*/
            btigual.Enabled = !((lbloper.Text == btdiv.Text && numOper2.Value == 0) || lbloper.Text == " ");
        }

        private void numOper2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numOper1_ValueChanged(object sender, EventArgs e)
        {

        }

        void ativarBotaoSegue()
        {
            btsegue.Enabled = !string.IsNullOrEmpty(lblresult.Text);
        }

        private void btsegue_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lblresult.Text))
            {
                numOper1.Value = Convert.ToDecimal(lblresult.Text);
            }
        }

        private void btlimpa_Click_1(object sender, EventArgs e)
        {
            numOper1.Value = 0;
            numOper2.Value = 0;
            lblresult.Text = "";
            lbloper.Text = "";
            btigual.Enabled = false;
            btsegue.Enabled = false;
        }
    }
}
