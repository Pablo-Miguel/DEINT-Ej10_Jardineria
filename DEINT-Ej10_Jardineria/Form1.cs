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
        private ClienteDLL clienteDLL;

        public Form1()
        {
            InitializeComponent();
            dgJard = this.dgJardineria;
            gamaDLL = new GamaDLL();
            productoDLL = new ProductoDLL();
            clienteDLL = new ClienteDLL();
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

        private void btnPedidosEntregados_Click(object sender, EventArgs e)
        {
            FormPedidos frmPedidos = new FormPedidos(this);
            frmPedidos.ShowDialog();
        }

        private void btnEmpleadosDeUnJefe_Click(object sender, EventArgs e)
        {
            FormJefes frmJefes = new FormJefes();
            frmJefes.ShowDialog();
        }

        private void btnPrecioMasCaroBarato_Click(object sender, EventArgs e)
        {
            dgJardineria.DataSource = productoDLL.getProductoMasCaroYMasBarato().Tables[0];
        }

        private void btnClientesQueNoPagan_Click(object sender, EventArgs e)
        {
            dgJardineria.DataSource = clienteDLL.getClientesQueNoPagan().Tables[0];
        }
    }
}
