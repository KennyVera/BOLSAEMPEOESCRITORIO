using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REDEMPLEO.Clases
{
    public class AbrirFrm
    {
        private Panel panelDestino;
        public AbrirFrm(Panel panel)
        {
            panelDestino = panel;
        }

        public void AbrirFormEnPanel(Form formHijo)
        {
            if (panelDestino.Controls.Count > 0)
                panelDestino.Controls.RemoveAt(0);
            formHijo.TopLevel = false;
            formHijo.Dock = DockStyle.Fill;

            panelDestino.Controls.Add(formHijo);
            panelDestino.Tag = formHijo;

            formHijo.Show();
        }
    }
}
