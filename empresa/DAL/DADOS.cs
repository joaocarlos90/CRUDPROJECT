using empresa.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace empresa.DAL
{
    public class DADOS : CONEXAO
    {
        public string InserirEmpresa(EmpresaModel empresa)
        {
            //SALVA DADOS DAS INFORMAÇÕES BASICAS DO CONTRATANTE NO BANCO
            StringBuilder queryInserirEmpresa = new StringBuilder();
            queryInserirEmpresa.AppendLine("INSERT INTO EmpresaModel (Nome, QuantidadeFuncionarios, Site)");
            queryInserirEmpresa.AppendLine($"VALUES (UPPER('{empresa.Nome}'), UPPER('{empresa.QuantidadeFuncionarios}'), UPPER('{empresa.Site}'))");

            ExecutarComando(queryInserirEmpresa.ToString());
            
            return "";

        }

        public string UpdateEmpresa(EmpresaModel empresa)
        {
            StringBuilder queryUpdateEmpresa = new StringBuilder();
            queryUpdateEmpresa.AppendLine("UPDATE EmpresaModel");
            queryUpdateEmpresa.AppendLine($"SET Nome = '{empresa.Nome}', QuantidadeFuncionarios = '{empresa.QuantidadeFuncionarios}', Site ='{empresa.Site}'");
            queryUpdateEmpresa.AppendLine($"WHERE Id = {empresa.Id}");
            
            ExecutarComando(queryUpdateEmpresa.ToString());
            
            return "";
        }

        public string DeleteEmpresa(int id)
        {
            try
            {
                StringBuilder queryDeleteEmpresa = new StringBuilder();
                queryDeleteEmpresa.AppendLine("DELETE EmpresaModel");
                queryDeleteEmpresa.AppendLine($"WHERE Id = {id}");
                ExecutarComando(queryDeleteEmpresa.ToString());
            }
            catch (Exception e)
            {
                MessageBox.Show("Aconteceu algo inesperado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return "deletou";
        }

        public List<EmpresaModel> retornaTodosClientes()
        {
            {
                var lista = new List<EmpresaModel>();
                var dt = RetornaTabela($"SELECT * FROM EmpresaModel");

                foreach (DataRow row in dt.Rows)
                {
                    lista.Add(new EmpresaModel
                    {
                        Id = Convert.ToInt32(row["Id"]),
                        Nome = row["Nome"].ToString(),
                        QuantidadeFuncionarios = row["QuantidadeFuncionarios"].ToString(),
                        Site = row["Site"].ToString(),

                    });

                }

                return lista;
            }
        }

            public List<EmpresaModel> retornaEmpresa(int id)
        {
            var lista = new List<EmpresaModel>();
            var dt = RetornaTabela($"SELECT * FROM EmpresaModel WHERE Id = '{id}' ");

            foreach (DataRow row in dt.Rows)
            {
                lista.Add(new EmpresaModel
                {
                    Id = Convert.ToInt32(row["Id"]),
                    Nome = row["Nome"].ToString(),
                    QuantidadeFuncionarios = row["QuantidadeFuncionarios"].ToString(),
                    Site = row["Site"].ToString(),

                });

            }

            return lista;
        }
    }
}
