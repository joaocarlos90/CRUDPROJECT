using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace empresa
{
    public partial class FormPrincipal : Form
    {
        FrEmpresas frEmpresa = new FrEmpresas();
        FrEditDeleteEmpresa frEditDeleteEmpresa = new FrEditDeleteEmpresa();
        FrDtGrid frDtGrid = new FrDtGrid();
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void cadastrarNovaEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frEmpresa.Show();
        }

        private void editarExcluirEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frEditDeleteEmpresa.Show();
        }

        private void listaDeEmpresasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frDtGrid.Show();
        }
    }
}
