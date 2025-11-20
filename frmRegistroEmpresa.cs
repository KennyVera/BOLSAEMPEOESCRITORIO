using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REDEMPLEO
{
    public partial class frmRegistroEmpresa : Form
    {
        public frmRegistroEmpresa()
        {
            InitializeComponent();
        }

        private void btn_RegistraEmpresa_Click(object sender, EventArgs e)
        {
            login_ log = new login_();

            string xml = log.GenerarXMLEmpresa(
                txtResEmail.Text,
                txtResContra.Text,
                txtResEmpresa.Text,
                txtResRuc.Text,
                txtResDireccion.Text,
                txtResSitioWeb.Text,
                txtResCorreoC.Text,
                txtResDescripcion.Text
            );
            bool ok = log.InsertarEmpresaXML(xml);

            if (ok)
                MessageBox.Show("Candidato registrado correctamente");
            else
                MessageBox.Show("Error al registrar el candidato");
        }

        private void btn_registra_A_Click(object sender, EventArgs e)
        {
            frm_RegistroPostulante frmP = new frm_RegistroPostulante();
            frmP.StartPosition = FormStartPosition.CenterScreen;
            frmP.Show();
            this.Hide();
        }

        private void btn_linkInicia_Click(object sender, EventArgs e)
        {
            Inicio_sesion frmI = new Inicio_sesion();
            frmI.StartPosition = FormStartPosition.CenterScreen;
            frmI.Show();
            this.Hide();
        }
    }
}
