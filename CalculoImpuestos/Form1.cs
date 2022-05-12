using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoImpuestos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CalcularNeto();

        }

        private void CalcularNeto()
        {
            // Isr 9%, AFP 7%, SFS 10%
            double suelBruto, afp, sfs, isr, suelNeto;
            suelBruto = double.Parse(SueldoBruto.Text);

            afp = suelBruto * 0.07;
            sfs = suelBruto * 0.10;
            isr = suelBruto * 0.09;

            suelNeto = suelBruto - afp - sfs - isr;

            AFP.Text= afp.ToString();
            SFS.Text= sfs.ToString();
            ISR.Text= isr.ToString();
            SueldoNeto.Text = suelNeto.ToString();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
