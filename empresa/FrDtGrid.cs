using empresa.DAL;
using empresa.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace empresa
{
    public partial class FrDtGrid : Form
    {

        public FrDtGrid()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<EmpresaModel> listaProdutos = new List<EmpresaModel>();
            DADOS dados = new DADOS();
            listaProdutos = dados.retornaTodosClientes();

            //atribui o datatable ao datagridview para exibir o resultado
            dataGridView1.DataSource = listaProdutos;
        }
    }
}
