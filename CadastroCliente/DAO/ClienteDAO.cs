using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace CadastroCliente.DAO
{
    public class ClienteDAO
    {
        public static DataTable CarregarClientes(int? cdCliente = null)
        {
            string query = "SELECT cd_cliente AS Codigo, nm_cliente AS Nome, dt_fundacao AS DataFundacao, telefone AS Telefone, registro AS Registro FROM cliente";
            SqlParameter[] parameters = null;

            if (cdCliente.HasValue)
            {
                query += " WHERE cd_cliente = @cd_cliente";
                parameters = new SqlParameter[]
                {
                    new SqlParameter("@cd_cliente", cdCliente.Value)
                };
            }

            try
            {
                DataSet ds = DatabaseConnection.ExecuteQuery(query, parameters);
                return ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar clientes: " + ex.Message);
                return new DataTable();
            }
        }

        public static DataTable CarregarClientesComEndereco()
        {
            string query = "SELECT * FROM vw_clientes_com_endereco";
            try
            {
                DataSet ds = DatabaseConnection.ExecuteQuery(query);
                return ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar clientes com endereço: " + ex.Message);
                return new DataTable();
            }
        }

        public static void IncluirCliente(string nome, string data_fundacao, string telefone, string registro)
        {
            string query = "INSERT INTO cliente (nm_cliente, dt_fundacao, telefone, registro) " +
                           "OUTPUT INSERTED.cd_cliente " +
                           "VALUES (@nm_cliente, @dt_fundacao, @telefone, @registro)";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@nm_cliente", nome),
                new SqlParameter("@dt_fundacao", DateTime.Parse(data_fundacao)),
                new SqlParameter("@telefone", new string(telefone.Where(char.IsDigit).ToArray())),
                new SqlParameter("@registro", new string(registro.Where(char.IsDigit).ToArray()))
            };

            try
            {
                DataSet ds = DatabaseConnection.ExecuteQuery(query, parameters);
                int clienteIdAtual = (int)ds.Tables[0].Rows[0]["cd_cliente"];
                MessageBox.Show("Cliente salvo com sucesso! ID: " + clienteIdAtual);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar cliente: " + ex.Message);
            }
        }

        public static void AtualizarCliente(int id, string nome, string data_fundacao, string telefone, string registro)
        {
            string query = "UPDATE cliente SET nm_cliente = @nm_cliente, dt_fundacao = @dt_fundacao, telefone = @telefone, registro = @registro WHERE cd_cliente = @cd_cliente";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@nm_cliente", nome),
                new SqlParameter("@dt_fundacao", DateTime.Parse(data_fundacao)),
                new SqlParameter("@telefone", new string(telefone.Where(char.IsDigit).ToArray())),
                new SqlParameter("@registro", new string(registro.Where(char.IsDigit).ToArray())),
                new SqlParameter("@cd_cliente", id)
            };

            try
            {
                DatabaseConnection.ExecuteNonQuery(query, parameters);
                MessageBox.Show("Cliente atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar cliente: " + ex.Message);
            }
        }

        public static void ExcluirCliente(int id)
        {
            string query = "DELETE FROM cliente WHERE cd_cliente = @cd_cliente";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@cd_cliente", id)
            };

            try
            {
                DatabaseConnection.ExecuteNonQuery(query, parameters);
                MessageBox.Show("Cliente excluído com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir cliente: " + ex.Message);
            }
        }
    }
}
