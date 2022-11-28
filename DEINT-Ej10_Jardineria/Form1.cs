using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DEINT_Ej10_Jardineria
{
    public partial class Form1 : Form
    {
        public DataGridView dgJard;
        public Form1()
        {
            InitializeComponent();
            dgJard = this.dgJardineria;
        }

        private void btnAnadirProducto_Click(object sender, EventArgs e)
        {
            FormProducto frmProd = new FormProducto(this);
            frmProd.ShowDialog();
        }
    }
}
