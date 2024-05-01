using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace repeticao_06_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            int cont = 1, n, num1 = 0, num2= 1, num3 = 0;
            n = int.Parse(txt_num.Text);

            ltx_imprimir.Items.Clear();

            while (cont <= n)
            {
                ltx_imprimir.Items.Add(cont + "  -  " + num3);
                cont++;
                num1 = num2;
                num2 = num3;
                num3 = num1 + num2;
            }
        }
    }
}
