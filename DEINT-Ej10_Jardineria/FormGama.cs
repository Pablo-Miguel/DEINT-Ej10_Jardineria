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
    public partial class FormGama : Form
    {
        private Form1 frm;
        private GamaDLL gamaDLL;
        private ProductoDLL productoDLL;
        public FormGama(Form1 frm)
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

        private void cbGama_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDescrTexto.Text = gamaDLL.getGama(cbGama.Text).Tables[0].Rows[0]["descripcion_texto"].ToString();
            txtDescrHtml.Text = gamaDLL.getGama(cbGama.Text).Tables[0].Rows[0]["descripcion_html"].ToString();
            txtImagen.Text = gamaDLL.getGama(cbGama.Text).Tables[0].Rows[0]["imagen"].ToString();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {

            Boolean borrado = gamaDLL.Borrar(cbGama.Text);

            if (borrado) {
                MessageBox.Show("Se ha borrado la gama correctamente");
                frm.dgJard.DataSource = gamaDLL.getGamas().Tables[0];
                this.Close();
            }
            else
            {
                MessageBox.Show("Se ha producido un error al borrar la gama\nEsta gama está siendo utilizada en más partes de la DB");
            }
        }
    }
}
