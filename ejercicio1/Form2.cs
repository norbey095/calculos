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
    public partial class Form2 : Form
    {
        conversion datos = new conversion();
        public Form2()
        {
            InitializeComponent();
        }

        private void btnconvertir_Click(object sender, EventArgs e)
        {
            datos.valordolares = Convert.ToDouble(txtdolares.Text);
            lblresultado1.Text = Convert.ToString(datos.convertir);
        }
    }
}
