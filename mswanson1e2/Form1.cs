using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mswanson1e2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            txtAvg.Text = (
                (Convert.ToDecimal(txt1.Text) + Convert.ToDecimal(txt2.Text) + Convert.ToDecimal(txt3.Text)) / 3m
                ).ToString("00.00");
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txt1.Text = "0";
            txt2.Text = "0";
            txt3.Text = "0";
            txtAvg.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
