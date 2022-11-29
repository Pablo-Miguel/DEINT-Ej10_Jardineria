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
    public partial class FormJefes : Form
    {
        private EmpleadoDLL empleadoDLL;
        public FormJefes()
        {
            InitializeComponent();
            empleadoDLL = new EmpleadoDLL();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            listaJefes.Items.Clear();
            DataTable dt = empleadoDLL.getEmpleadosJefe(Int32.Parse(txtJefe.Text)).Tables[0];

            String cad = "";
            for (int i = 0; i < dt.Rows.Count; i++) {

                cad += $"Nombre y apellidos: {dt.Rows[i]["nombre"]} {dt.Rows[i]["apellido1"]} {dt.Rows[i]["apellido2"]}, email: {dt.Rows[i]["email"]}, cuyo jefe tiene un código de jefe igual a {Int32.Parse(txtJefe.Text)}";
                listaJefes.Items.Add(cad);
                cad = "";

            }

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtJefe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
