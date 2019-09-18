using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mswanson1f1
{
    public partial class FrmCurrency : Form
    {
        public FrmCurrency()
        {
            InitializeComponent();
        }

        private void FrmCurrency_Load(object sender, EventArgs e)
        {
            btnAustralia.BackgroundImage = picAustralia.Image;
            btnJapan.BackgroundImage = picJapanDim.Image;
            btnEuro.BackgroundImage = picEuroDim.Image;
            btnBhutan.BackgroundImage = picBhutanDim.Image;
            txtRate.Text = "0.717976";
            txtUSD.Text = "0.00";
            txtTotalUSD.Text = "0.00";
            txtCurrency.Focus();
        }

        private void BtnAustralia_Click(object sender, EventArgs e)
        {
            btnAustralia.BackgroundImage = picAustralia.Image;
            btnJapan.BackgroundImage = picJapanDim.Image;
            btnEuro.BackgroundImage = picEuroDim.Image;
            btnBhutan.BackgroundImage = picBhutanDim.Image;
            labelCurrency.Text = "Australian Dollar:";
            txtRate.Text = "0.685307";
        }

        private void BtnJapan_Click(object sender, EventArgs e)
        {
            btnJapan.BackgroundImage = picJapan.Image;
            btnAustralia.BackgroundImage = picAustraliaDim.Image;
            btnEuro.BackgroundImage = picEuroDim.Image;
            btnBhutan.BackgroundImage = picBhutanDim.Image;
            labelCurrency.Text = "Japanese Yen:";
            txtRate.Text = "0.00924195";
        }

        private void BtnBhutan_Click(object sender, EventArgs e)
        {
            btnBhutan.BackgroundImage = picBhutan.Image;
            btnJapan.BackgroundImage = picJapanDim.Image;
            btnEuro.BackgroundImage = picEuroDim.Image;
            btnAustralia.BackgroundImage = picAustraliaDim.Image;
            labelCurrency.Text = "Bhutanese Ngultrum:";
            txtRate.Text = "0.0139944";
        }

        private void BtnEuro_Click(object sender, EventArgs e)
        {
            btnEuro.BackgroundImage = picEuro.Image;
            btnJapan.BackgroundImage = picJapanDim.Image;
            btnAustralia.BackgroundImage = picAustraliaDim.Image;
            btnBhutan.BackgroundImage = picBhutanDim.Image;
            labelCurrency.Text = "Euro:";
            txtRate.Text = "1.10691";
        }

        private void calcUSD(object sender, EventArgs e)
        {
            txtUSD.Text = (
                Convert.ToDecimal(txtRate.Text) * Convert.ToDecimal(txtCurrency.Text)
                ).ToString("0.00");
        }

        private void TxtCurrency_Enter(object sender, EventArgs e)
        {
            txtCurrency.SelectAll();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            txtTotalUSD.Text = (
                Convert.ToDecimal(txtUSD.Text) + Convert.ToDecimal(txtTotalUSD.Text)
                ).ToString("0.00");
            lblEquation.Text = lblEquation.Text + " + " + txtUSD.Text;
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            btnAustralia.BackgroundImage = picAustralia.Image;
            btnJapan.BackgroundImage = picJapanDim.Image;
            btnEuro.BackgroundImage = picEuroDim.Image;
            btnBhutan.BackgroundImage = picBhutanDim.Image;
            txtRate.Text = "0.717976";
            txtUSD.Text = "0.00";
            txtTotalUSD.Text = "0.00";
            txtCurrency.Focus();
            txtCurrency.Text = "0.00";
            lblEquation.Text = "";
        }
    }
}
