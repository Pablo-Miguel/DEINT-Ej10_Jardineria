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
    public partial class FormProducto : Form
    {
        private Form1 frm;
        private GamaDLL gamaDLL;
        private ProductoDLL productoDLL;

        public FormProducto(Form1 frm)
        {
            InitializeComponent();

            this.frm = frm;

            gamaDLL = new GamaDLL();
            productoDLL = new ProductoDLL();

            DataTable dt = gamaDLL.getGamas().Tables[0];

            cbGama.ValueMember = "gama";
            cbGama.DisplayMember = "gama";
            cbGama.DataSource = dt;

            cbGama.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            if (!txtNombre.Text.Equals("") && !txtDimensiones.Text.Equals("")
                && !txtProveedor.Text.Equals("") && !txtDescripcion.Text.Equals("")
                && !txtCantidadStock.Text.Equals("") && !txtPrecioVenta.Text.Equals("")
                && !txtPrecioProveedor.Text.Equals(""))
            {
                Boolean insertado = productoDLL.Agregar(txtNombre.Text, cbGama.Text, txtDimensiones.Text, txtProveedor.Text,
                    txtDescripcion.Text, Int32.Parse(txtCantidadStock.Text), Double.Parse(txtPrecioVenta.Text),
                    Double.Parse(txtPrecioProveedor.Text));

                if (insertado)
                {
                    MessageBox.Show("Se ha insertado correctamente");
                    frm.dgJard.DataSource = productoDLL.getProductos().Tables[0];
                    this.Close();
                }
                else {
                    MessageBox.Show("Ha ocurrido un error al insertar el producto");
                }

            }
            else {
                MessageBox.Show("Algún campo está vacío, todos son obligatorios");
            }
        }

        private void txtCantidadStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtCantidadStock_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
