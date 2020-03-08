<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Produto.aspx.cs" Inherits="Produto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="title" runat="server" Text="Cadastro de Produtos"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btngravar" runat="server" Text="Gravar" OnClick="btngravar_Click" />
        <br />
        <br />
        <br />
        <br />
        <div>
        <asp:Label ID="id" runat="server" Text="Id"></asp:Label>
        <asp:TextBox ID="txtid" runat="server"></asp:TextBox>
            <asp:Button ID="btncarregar" runat="server" Text="Carregar" OnClick="btncarregar_Click" />
        </div>
        &nbsp;&nbsp;
        <div>
            <asp:Label ID="nome" runat="server" Text="Nome"></asp:Label>
            <asp:TextBox ID="txtnome" runat="server" Width="160px"></asp:TextBox>
        </div>
        
        <div>
        <asp:Label ID="descricao" runat="server" Text="Descrição"></asp:Label>
        <asp:TextBox ID="txtdescricao" runat="server"></asp:TextBox>
       </div>
        
        <div>
        <asp:Label ID="precocusto" runat="server" Text="Preço de Custo"></asp:Label>
        <asp:TextBox ID="txtprecocusto" runat="server"></asp:TextBox>
            <br />
        </div>
        
        <div>
            Preço de venda
            <asp:TextBox ID="txtprecovenda" runat="server"></asp:TextBox>
            <br />
        <asp:Label ID="quantidade" runat="server" Text="Quantidade"></asp:Label>
        <asp:TextBox ID="txtquantidade" runat="server"></asp:TextBox>
        </div>

        <div>
        <asp:Label ID="unidademedida" runat="server" Text="Unidade de Medida"></asp:Label>
             <asp:TextBox ID="txtunidademedida" runat="server"></asp:TextBox>
        </div>

        <div>
            <asp:Label ID="categoriaid" runat="server" Text="Categoria_Id"></asp:Label>
            <asp:DropDownList ID="ddlcategoriaid" runat="server"></asp:DropDownList>
        </div>
            <br />
            <br />
            <asp:GridView ID="gdproduto" runat="server" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2">
                <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#FFF1D4" />
                <SortedAscendingHeaderStyle BackColor="#B95C30" />
                <SortedDescendingCellStyle BackColor="#F1E5CE" />
                <SortedDescendingHeaderStyle BackColor="#93451F" />
            </asp:GridView>
            <br />
            <br />
            <br />
        </div>

    </form>
</body>
</html>
