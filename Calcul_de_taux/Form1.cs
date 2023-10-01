using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcul_de_taux
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calculer_Click(object sender, EventArgs e)
        {
            double montant = double.Parse(text_montant.Text);
            double taux=0;
            double total = 0;
            
            if (montant < 1000)
            {
                total = montant;
                taux = 0;
            }
            if(montant>1000 && montant <= 3000)
            {
                total = montant - ((montant * 5) / 100);
                taux = 5;
            }else
            if (montant > 3000 && montant <= 4000)
            {
                total = montant - ((montant * 10) / 100);
                taux = 10;
            }else
            if (montant > 4000 && montant <= 5000)
            {
                total = montant - ((montant * 15) / 100);
                taux = 15;
            }else
            if (montant > 5000)
            {
                total = montant - ((montant * 20) / 100);
                taux = 20;
            }

            text_total.Text = total.ToString();
            text_taux.Text = taux.ToString();
        }
    }
}
