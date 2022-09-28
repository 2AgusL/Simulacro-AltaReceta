using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prog2_Simulacro1__Proyecto_AltaCocina_.Presentacion;

namespace Prog2_Simulacro1__Proyecto_AltaCocina_
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void TsmAltaReceta_Click(object sender, EventArgs e)
        {
            FrmAltaReceta frmAltaReceta = new FrmAltaReceta();
            frmAltaReceta.ShowDialog();
            frmAltaReceta.Dispose();
        }
    }
}
