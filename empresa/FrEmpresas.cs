using empresa.DAL;
using empresa.Modelo;
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
    public partial class FrEmpresas : Form
    {
        EmpresaModel empresa = new EmpresaModel();
        DADOS dados = new DADOS();
        public FrEmpresas()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            
            empresa.Nome = tbxNome.Text;
            empresa.QuantidadeFuncionarios = tbxQuantidadeFuncionario.Text;
            empresa.Site = tbxSite.Text;

            dados.InserirEmpresa(empresa);
        }
    }
}
