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
    public partial class FrmEmpresa : Form
    {
        private AbrirFrm abrir;
        public FrmEmpresa()
        {
            InitializeComponent();
            abrir = new AbrirFrm(PnelEmpresaC);
        }

        private void FrmEmpresa_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_MiperfilE_Click(object sender, EventArgs e)
        {
            abrir.AbrirFormEnPanel(new frmPerfilEmpresa());
        }
    }
}
