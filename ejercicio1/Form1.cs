using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio1
{
    public partial class Form1 : Form
    {
        calculos proceso = new calculos();

        conversion datos = new conversion();

        pagos multi = new pagos();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            proceso.numero1 = Convert.ToInt16(txtvalor1.Text);
            proceso.numero2 = Convert.ToInt16(txtvalor2.Text);
            proceso.numero3 = Convert.ToInt16(txtvalor3.Text);

            lblresultado.Text = Convert.ToString(proceso.sumar);

            MessageBox.Show(Convert.ToString(proceso.numero1));
            MessageBox.Show(Convert.ToString(proceso.numero2));
            MessageBox.Show(Convert.ToString(proceso.numero3));

            txtvalor1.Text = "";
            txtvalor2.Text = "";
            txtvalor3.Text = "";
        }

        private void btnconvertir_Click(object sender, EventArgs e)
        {
            datos.valordolares = Convert.ToDouble(txtdolares.Text);
            lblresultado1.Text = Convert.ToString(datos.convertir);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnpagar_Click(object sender, EventArgs e)
        {
            multi.dias = Convert.ToInt16(txtdias.Text);
            multi.valor = Convert.ToInt32(txtvalor.Text);

            lblpagar.Text = "Valor a pagar : " + Convert.ToString(multi.multiplicar);

            MessageBox.Show(Convert.ToString(multi.multiplicar));

            txtnombre.Text = "";
            txtdias.Text = "";
            txtvalor.Text = "";
        }
    }
}
