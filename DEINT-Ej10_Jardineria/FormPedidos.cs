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
    public partial class FormPedidos : Form
    {
        private Form1 frm;
        private ProductoDLL productoDLL;
        public FormPedidos(Form1 frm)
        {
            InitializeComponent();
            this.frm = frm;
            cbMes.SelectedIndex = 0;

            productoDLL = new ProductoDLL();

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            frm.dgJard.DataSource = productoDLL.getProductoMes(cbMes.SelectedIndex + 1).Tables[0];
            this.Close();
        }
    }
}
