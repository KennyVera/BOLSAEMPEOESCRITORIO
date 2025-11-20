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
    public partial class frm_RegistroPostulante : Form
    {
        public frm_RegistroPostulante()
        {
            InitializeComponent();
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_RegistraPostulante_Click(object sender, EventArgs e)
        {
            login_ log = new login_();

            string xml = log.GenerarXMLCandidato(
                txt_correo_.Text,
                txt_contraseña_.Text,
                txt_nombre_.Text,
                txt_Apellido_.Text,
                txt_tele_.Text,
                txt_fn_.Text,  // formato: 2025-01-15
                txt_resumen_.Text
            );
            bool ok = log.InsertarCandidatoXML(xml);

            if (ok)
                MessageBox.Show("Candidato registrado correctamente");
            else
                MessageBox.Show("Error al registrar el candidato");
        }

        private void btn_registra_AP_Click(object sender, EventArgs e)
        {
            frmRegistroEmpresa frmE = new frmRegistroEmpresa();
            frmE.StartPosition = FormStartPosition.CenterScreen;
            frmE.Show();
            this.Hide();
        }

        private void btn_linkIniciaP_Click(object sender, EventArgs e)
        {
            Inicio_sesion frm = new Inicio_sesion();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
            this.Hide();
        }
    }
}
