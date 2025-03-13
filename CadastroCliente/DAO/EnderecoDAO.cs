using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CadastroCliente.DAO
{
    class EnderecoDAO
    {

        public static DataTable CarregarEnderecos(int? cd_cliente = null)
        {
            string query = "SELECT cd_endereco AS Codigo, nm_rua AS Rua, numero, nm_bairro AS Bairro, nm_cidade AS Cidade, nm_uf AS Estado FROM endereco";
            SqlParameter[] parameters = null;
            if (cd_cliente.HasValue)
            {
                query += " WHERE cd_cliente = @cd_cliente";
                parameters = new SqlParameter[]
                {
                new SqlParameter("@cd_cliente", cd_cliente.Value)
                };
            }

            try
            {
                DataSet ds = DatabaseConnection.ExecuteQuery(query, parameters);
                return ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar endereços: " + ex.Message);
                return new DataTable();
            }
        }

        public static void IncluirEndereco(int cd_cliente, string rua, int numero, string bairro, string cidade, string uf)
        {
            string queryIncluirEndereco = "INSERT INTO endereco (nm_rua, numero, nm_bairro, nm_cidade, nm_uf, cd_cliente) VALUES (@rua, @numero, @bairro, @cidade, @uf, @cd_cliente)";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@rua", rua),
                new SqlParameter("@numero", numero),
                new SqlParameter("@bairro", bairro),
                new SqlParameter("@cidade", cidade),
                new SqlParameter("@uf", uf),
                new SqlParameter("@cd_cliente", cd_cliente)
            };

            try
            {
                DatabaseConnection.ExecuteNonQuery(queryIncluirEndereco, parameters);
                MessageBox.Show("Endereço criado com sucesso!");
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao incluir cliente: " + e);
            }


        }

        public static void AtualizarEndereco(int id, string rua, int numero, string bairro, string cidade, string uf)
        {
            string queryAtualizarEndereco = "UPDATE endereco SET nm_rua = @nm_rua, numero = @numero, nm_bairro = @nm_bairro, nm_cidade = @nm_cidade, nm_uf = @nm_uf WHERE cd_endereco = @cd_endereco";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@nm_rua", rua),
                new SqlParameter("@numero", numero),
                new SqlParameter("@nm_bairro", bairro),
                new SqlParameter("@nm_cidade", cidade),
                new SqlParameter("@nm_uf", uf),
                new SqlParameter("@cd_endereco", id),
            };

            try
            {
                DatabaseConnection.ExecuteNonQuery(queryAtualizarEndereco, parameters);
                MessageBox.Show("Endereço atualizado com sucesso!");
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao atualizar cliente: " + e);
            }

        }

        public static void ExcluirEndereco(int id)
        {
            string queryExcluirEndereco = $"DELETE FROM endereco WHERE cd_endereco = {id}";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@cd_endereco", id)
            };

            try
            {
                DatabaseConnection.ExecuteNonQuery(queryExcluirEndereco, parameters);
                MessageBox.Show("Endereço excluído com sucesso!");
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao excluir endereço: " + e);
            }

        }
    }
}
