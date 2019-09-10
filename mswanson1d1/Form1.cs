using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mswanson1d1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            txtAmountAustralia.Text = "0.00";
            txtAmountBhutan.Text = "0.00";
            txtAmountEuro.Text = "0.00";
            txtAmountYen.Text = "0.00";
            txtRateYen.Text = "0.00931046";
            txtRateAustralia.Text = "0.685706";
            txtRateBhutan.Text = "0.0139189";
            txtRateEuro.Text = "1.10450";
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AustraliaTextChanged(object sender, EventArgs e)
        {
            txtUSDAustralia.Text = (
                Convert.ToDecimal(txtAmountAustralia.Text) * Convert.ToDecimal(txtRateAustralia.Text)
                ).ToString("0.00");
        }

        private void BhutanTextChanged(object sender, EventArgs e)
        {
            txtUSDBhutan.Text = (
                Convert.ToDecimal(txtAmountBhutan.Text) * Convert.ToDecimal(txtRateBhutan.Text)
                ).ToString("0.00");
        }

        private void EuroTextChanged(object sender, EventArgs e)
        {
            txtUSDEuro.Text = (
                Convert.ToDecimal(txtAmountEuro.Text) * Convert.ToDecimal(txtRateEuro.Text)
                ).ToString("0.00");
        }

        private void YenTextChanged(object sender, EventArgs e)
        {
            txtUSDYen.Text = (
                Convert.ToDecimal(txtAmountYen.Text) * Convert.ToDecimal(txtRateYen.Text)
                ).ToString("0.00");
        }

        private void USDTextChange(object sender, EventArgs e)
        {
            txtTotalUSD.Text = (
                Convert.ToDecimal(txtUSDAustralia.Text) + Convert.ToDecimal(txtUSDBhutan.Text) + Convert.ToDecimal(txtUSDEuro.Text) + Convert.ToDecimal(txtUSDYen.Text)
                ).ToString("0.00");
        }
    }
}


 
