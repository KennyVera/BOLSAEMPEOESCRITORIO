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
    public partial class Inicio_sesion : Form
    {
        public Inicio_sesion()
        {
            InitializeComponent();
        }

        private void btn_iniciarSesion__Click(object sender, EventArgs e)
        {
            string usuario = txt_CORREO_.Text.Trim();
            string contraseña = txt_CONTRA_.Text.Trim();

            login_ log = new login_();

            if (log.VerificarCredenciales(usuario, contraseña))
            {
                MessageBox.Show("Inicio de sesión exitoso", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (log.RolObtenido == "candidato")
                {
                    frmPerfilPostulante frm = new frmPerfilPostulante();
                    frm.Show();
                    this.Hide();
                }
                else if (log.RolObtenido == "empresa")
                {
                    frmPerfilEmpresa frmEMPRE = new frmPerfilEmpresa();
                    frmEMPRE.Show();
                    this.Hide();
                    //frmAdministrador frm = new frmAdministrador();
                    //frm.Show();
                    //this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Error al iniciar sesión", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_registra__Click(object sender, EventArgs e)
        {
            frm_RegistroPostulante frmP = new frm_RegistroPostulante();
            frmP.StartPosition = FormStartPosition.CenterScreen;
            frmP.Show();
            this.Hide();
        }
    }
}
