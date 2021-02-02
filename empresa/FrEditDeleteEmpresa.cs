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
    public partial class FrEditDeleteEmpresa : Form
    {
        DADOS dados = new DADOS();
        EmpresaModel empresaModel = new EmpresaModel();
        public FrEditDeleteEmpresa()
        {
            InitializeComponent();
        }

        private void btnCarregarInfoEmpresa_Click(object sender, EventArgs e)
        {
            
            int id =Int32.Parse(tbxId.Text);
            var lista = dados.retornaEmpresa(id);

            foreach (var Empresa in lista)
            {
                string nome = Empresa.Nome;
                string qtdFuncionario = Empresa.QuantidadeFuncionarios;
                string site = Empresa.Site;

                tbxNome.Text = nome;
                tbxQuantidadeFuncionario.Text = qtdFuncionario.ToString();
                tbxSite.Text = site;
            }
                  
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            empresaModel.Id = Convert.ToInt32(tbxId.Text);
            empresaModel.Nome = tbxNome.Text;
            empresaModel.QuantidadeFuncionarios= tbxQuantidadeFuncionario.Text;
            empresaModel.Site= tbxSite.Text;
            
            dados.UpdateEmpresa(empresaModel);
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(tbxId.Text);
            dados.DeleteEmpresa(id);
        }
    }
}
