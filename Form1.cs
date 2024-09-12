using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Productos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double cant1, cant2, cant3, cant4, cant5, cant6, prec1, prec2, prec3, prec4, prec5, prec6, iva1, iva2, iva3, iva4, iva5, iva6, sub1, sub2, sub3, sub4, sub5, sub6, total;
            cant1 = Convert.ToDouble(textBox7.Text);
            cant2 = Convert.ToDouble(textBox8.Text);
            cant3 = Convert.ToDouble(textBox9.Text);
            cant4 = Convert.ToDouble(textBox10.Text);
            cant5 = Convert.ToDouble(textBox11.Text);
            cant6 = Convert.ToDouble(textBox12.Text);
            prec1 = Convert.ToDouble(textBox13.Text);
            prec2 = Convert.ToDouble(textBox14.Text);
            prec3 = Convert.ToDouble(textBox15.Text);
            prec4 = Convert.ToDouble(textBox16.Text);
            prec5 = Convert.ToDouble(textBox17.Text);
            prec6 = Convert.ToDouble(textBox18.Text);
            iva1 = 100 * prec1;
            iva2 = 100 * prec2;
            iva3 = 100 * prec3;
            iva4 = 100 * prec4;
            iva5 = 100 * prec5;
            iva6 = 100 * prec6;
            sub1 = (cant1 * prec1) + iva1;
            sub2 = (cant2 * prec2) + iva2;
            sub3 = (cant3 * prec3) + iva3;
            sub4 = (cant4 * prec4) + iva4;
            sub5 = (cant5 * prec5) + iva5;
            sub6 = (cant6 * prec6) + iva6;
            total = sub1 + sub2 + sub3 + sub4 + sub5 + sub6;
            textBox19.Text = Convert.ToString(iva1);
            textBox20.Text = Convert.ToString(iva2);
            textBox21.Text = Convert.ToString(iva3);
            textBox22.Text = Convert.ToString(iva4);
            textBox23.Text = Convert.ToString(iva5);
            textBox24.Text = Convert.ToString(iva6);
            textBox25.Text = Convert.ToString(sub1);
            textBox26.Text = Convert.ToString(sub2);
            textBox27.Text = Convert.ToString(sub3);
            textBox28.Text = Convert.ToString(sub4);
            textBox29.Text = Convert.ToString(sub5);
            textBox30.Text = Convert.ToString(sub6);
            textBox31.Text = Convert.ToString(total);
        }
    }
}
