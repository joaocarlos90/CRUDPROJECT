using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Produto : System.Web.UI.Page
{
    ProdutoBLL objProduto = new ProdutoBLL();

    protected void Page_Load(object sender, EventArgs e)
    {
        CarregarCategorias();
        CarregarGridView();
    }

    public void CarregarCategorias()
    {
        ddlcategoriaid.DataSource = objProduto.RetCategoriasProdutos();
        ddlcategoriaid.DataValueField = "id";
        ddlcategoriaid.DataTextField = "nome";
        ddlcategoriaid.DataBind();
    }

    private void CarregarGridView()
    {
        gdproduto.DataSource = objProduto.RetListarProdutos();
        gdproduto.DataBind();
    }

    protected void btngravar_Click(object sender, EventArgs e)
    {
        objProduto.Nome = txtnome.Text;
        objProduto.Descricao = txtdescricao.Text;
        objProduto.Preco_Custo = decimal.Parse(txtprecocusto.Text);
        objProduto.Preco_Venda = decimal.Parse(txtprecovenda.Text);
        objProduto.Quantidade = double.Parse(txtquantidade.Text);
        objProduto.Unidade_Medida = txtunidademedida.Text;
        objProduto.Categoria_Id = int.Parse(ddlcategoriaid.SelectedValue.ToString());

        if (string.IsNullOrEmpty(txtid.Text))
        {
            objProduto.InserirProduto();
        }
        else
        {
            objProduto.AlterarProduto(txtid.Text);
        }

        CarregarGridView();
    }



    protected void btncarregar_Click(object sender, EventArgs e)
    {
        DataTable data = objProduto.CarregarProdutoPorId(txtid.Text);

        txtnome.Text = data.Rows[0]["nome"].ToString();
        txtdescricao.Text = data.Rows[0]["descricao"].ToString();
        txtprecocusto.Text = data.Rows[0]["preco_custo"].ToString();
        txtprecovenda.Text = data.Rows[0]["preco_venda"].ToString();
        txtquantidade.Text = data.Rows[0]["quantidade"].ToString();
        txtunidademedida.Text = data.Rows[0]["unidade_medida"].ToString();
        ddlcategoriaid.SelectedValue = data.Rows[0]["categoria_id"].ToString();
    }
}