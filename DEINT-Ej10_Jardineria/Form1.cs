using DEINT_Ej10_Jardineria.DLL;
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
        private GamaDLL gamaDLL;
        private ProductoDLL productoDLL;

        public Form1()
        {
            InitializeComponent();
            dgJard = this.dgJardineria;
            gamaDLL = new GamaDLL();
            productoDLL = new ProductoDLL();
        }

        private void btnAnadirProducto_Click(object sender, EventArgs e)
        {
            FormProducto frmProd = new FormProducto(this);
            frmProd.ShowDialog();
        }

        private void btnMostrarProd_Click(object sender, EventArgs e)
        {
            dgJardineria.DataSource = productoDLL.getProductos().Tables[0];
        }

        private void btnGama_Click(object sender, EventArgs e)
        {
            dgJardineria.DataSource = gamaDLL.getGamas().Tables[0];
        }

        private void btnEliminarGama_Click(object sender, EventArgs e)
        {
            FormGama frmGama = new FormGama(this);
            frmGama.ShowDialog();
        }
    }
}
