using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CadastroCliente.DAO
{
    class EnderecoDAO
    {
        static string connectionString = "Data Source=dbserver-dev;Initial Catalog=treinamento;User ID=treinamento;Password=treinamento";

        public static DataTable CarregarEnderecos(int clienteId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string queryEnderecos = "SELECT id_endereco AS Codigo, rua AS Rua, numero As Numero, bairro AS Bairro, cidade AS Cidade, uf AS UF FROM enderecos WHERE cliente_id = @clienteId";

                SqlCommand command = new SqlCommand(queryEnderecos, connection);
                command.Parameters.AddWithValue("@clienteId", clienteId);

                try
                {
                    connection.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    return dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar endereços: " + ex.Message);
                    return new DataTable();
                }
            }
        }

        public static void IncluirEndereco(int clienteId, string rua, string numero, string bairro, string cidade, string uf)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Enderecos (rua, numero, bairro, cidade, uf, cliente_id) VALUES (@rua, @numero, @bairro, @cidade, @uf, @cliente_id)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@rua", rua);
                command.Parameters.AddWithValue("@numero", numero);
                command.Parameters.AddWithValue("@bairro", bairro);
                command.Parameters.AddWithValue("@cidade", cidade);
                command.Parameters.AddWithValue("@uf", uf);
                command.Parameters.AddWithValue("@cliente_id", clienteId);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Endereço criado com sucesso!");
                    //CarregarEnderecos(clienteId);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao criar endereço: " + ex.Message);
                }
            }
        }

        public static void AtualizarEndereco(int id, string rua, string numero, string bairro, string cidade, string uf)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Enderecos SET rua = @rua, numero = @numero, bairro = @bairro, cidade = @cidade, uf = @uf WHERE id_endereco = @id";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@rua", rua);
                command.Parameters.AddWithValue("@numero", numero);
                command.Parameters.AddWithValue("@bairro", bairro);
                command.Parameters.AddWithValue("@cidade", cidade);
                command.Parameters.AddWithValue("@uf", uf);
                command.Parameters.AddWithValue("@id", id);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Endereço atualizado com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao atualizar endereço: " + ex.Message);
                }
            }
        }

        public static void ExcluirEndereco(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $"DELETE FROM Enderecos WHERE id_endereco = {id}";

                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Endereço excluído com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir endereço: " + ex.Message);
                }
            }
        }
    }
}