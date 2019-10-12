using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bmarcotte2d1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            textBox1Input.Text = "Frank";
            textBox2Input.Text = "";
            textBox3Input.Text = "2.3";
            textBox4Input.Text = "false";
            textBox5InputA.Text = "2";
            textBox5InputB.Text = "2";
            textBox6Input.Text = "xyz";
            textBox7Input.Text = "1";
            textBox8InputA.Text = "1";
            textBox8InputB.Text = "2";
            textBox9Input.Text = "500";
            textBox10InputA.Text = "2";
            textBox10InputB.Text = "3";
        }

        private void SetFailValuesButton_Click(object sender, EventArgs e)
        {
            textBox1Input.Text = "xyz";
            textBox2Input.Text = "xyz";
            textBox3Input.Text = "2.4";
            textBox4Input.Text = "true";
            textBox5InputA.Text = "2";
            textBox5InputB.Text = "3";
            textBox6Input.Text = "Jones";
            textBox7Input.Text = "0";
            textBox8InputA.Text = "1";
            textBox8InputB.Text = "1";
            textBox9Input.Text = "499";
            textBox10InputA.Text = "4";
            textBox10InputB.Text = "3";
        }

        private void Calculatebutton_Click(object sender, EventArgs e)
        {
            textBox1Result.Text = "Fail";
            textBox2Result.Text = "Fail";
            textBox3Result.Text = "Fail";
            textBox4Result.Text = "Fail";
            textBox5Result.Text = "Fail";
            textBox6Result.Text = "Fail";
            textBox7Result.Text = "Fail";
            textBox8Result.Text = "Fail";
            textBox9Result.Text = "Fail";
            textBox10Result.Text = "Fail";

            textBox1ResultB.Text = "Success";
            textBox2ResultB.Text = "Success";
            textBox3ResultB.Text = "Success";
            textBox4ResultB.Text = "Success";
            textBox5ResultB.Text = "Success";
            textBox6ResultB.Text = "Success";
            textBox7ResultB.Text = "Success";
            textBox8ResultB.Text = "Success";
            textBox9ResultB.Text = "Success";
            textBox10ResultB.Text = "Success";

            if (textBox1Input.Text == "Frank")
                textBox1Result.Text = "Success";
            if (textBox1Input.Text != "Frank")
                textBox1ResultB.Text = "Fail";

            if (textBox2Input.Text == "")
                textBox2Result.Text = "Success";
            if (textBox2Input.Text != "")
                textBox2Result.Text = "Fail";

            decimal val3 = Convert.ToDecimal(textBox3Input.Text);
            if (val3 == 2.3m)
                textBox3Result.Text = "Success";
            if (val3 != 2.3m)
                textBox3ResultB.Text = "Fail";

            bool val4 = Convert.ToBoolean(textBox4Input.Text);
            if (val4 == false)
                textBox4Result.Text = "Success";
            if (val4 != false)
                textBox4ResultB.Text = "Fail";

            decimal val5a = Convert.ToDecimal(textBox5InputA.Text);
            decimal val5b = Convert.ToDecimal(textBox5InputB.Text);
            if (val5a == val5b)
                textBox5Result.Text = "Success";
            if (val5a != val5b)
                textBox5ResultB.Text = "Fail";

            if (textBox6Input.Text != "Jones")
                textBox6Result.Text = "Success";
            if (textBox6Input.Text == "Jones")
                textBox6Result.Text = "Fail";

            decimal val7 = Convert.ToDecimal(textBox7Input.Text);
            if (val7 > 0)
                textBox7Result.Text = "Success";
            if (val7 < 0)
                textBox7ResultB.Text = "Fail";

            decimal val8a = Convert.ToDecimal(textBox8InputA.Text);
            decimal val8b = Convert.ToDecimal(textBox8InputB.Text);
            if (val8a < val8b)
                textBox8Result.Text = "Success";
            if (val8a > val8b)
                textBox8ResultB.Text = "Fail";

            decimal val9 = Convert.ToDecimal(textBox9Input.Text);
            if (val9 >= 500m)
                textBox9Result.Text = "Success";
            if (val9 < 500m)
                textBox9ResultB.Text = "Fail";

            decimal val10a = Convert.ToDecimal(textBox10InputA.Text);
            decimal val10b = Convert.ToDecimal(textBox10InputB.Text);
            if (val10a <= val10b)
                textBox10Result.Text = "Success";
            if (val10a > val10b)
                textBox10ResultB.Text = "Fail";




        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void SetPassValuesButton_Click(object sender, EventArgs e)
        {

        }

        private void Label10_Click(object sender, EventArgs e)
        {

        }
    }
}
