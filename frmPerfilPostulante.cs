using REDEMPLEO.Clases;
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
    public partial class frmPerfilPostulante : Form
    {
        private AbrirFrm abrir;
        public frmPerfilPostulante()
        {
            InitializeComponent();
            abrir = new AbrirFrm(PnelContenedor);
        }
        
        private void btn_Miperfil_Click(object sender, EventArgs e)
        {
            abrir.AbrirFormEnPanel(new FrmPerfil_());

        }
    }
}
