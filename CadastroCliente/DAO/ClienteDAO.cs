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
    class ClienteDAO
    {
        static string connectionString = "Data Source=dbserver-dev;Initial Catalog=treinamento;User ID=treinamento;Password=treinamento";
        public static DataTable CarregarClientes()
        {     
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string queryClientes = "SELECT id_cliente AS Codigo, nome AS Nome, ano_fundacao AS AnoFundacao, telefone AS Telefone, registro AS Registro FROM clientes";

                try
                {
                    connection.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(queryClientes, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    //dataGridViewClientes.DataSource = dataTable;
                    return dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar clientes: " + ex.Message);
                    return new DataTable();
                }
            }
        }


        public static DataTable CarregarClientesComEndereco()
        {
            string query = "SELECT * FROM vw_clientes_com_endereco";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                //dataGridViewClientes.DataSource = dt;
                return dataTable;
            }
        }

        public static void IncluirCliente(int clienteIdAtual, string nome, string ano_fundacao, string telefone, string registro)
        {           
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string queryCliente = "INSERT INTO Clientes (nome, ano_fundacao, telefone, registro) " +
                                      "OUTPUT INSERTED.id_cliente " +
                                      "VALUES (@nome, @ano_fundacao, @telefone, @registro)";

                try
                {
                    connection.Open();

                    SqlCommand commandCliente = new SqlCommand(queryCliente, connection);
                    commandCliente.Parameters.AddWithValue("@nome", nome);
                    commandCliente.Parameters.AddWithValue("@ano_fundacao", int.Parse(ano_fundacao));
                    commandCliente.Parameters.AddWithValue("@telefone", new string(telefone.Where(char.IsDigit).ToArray()));
                    commandCliente.Parameters.AddWithValue("@registro", new string(registro.Where(char.IsDigit).ToArray()));

                    clienteIdAtual = (int)commandCliente.ExecuteScalar();

                    MessageBox.Show("Cliente salvo com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao salvar cliente: " + ex.Message);
                }
            }
        }

        public static void AtualizarCliente(int id, string nome, string ano_fundacao, string telefone, string registro)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string queryCliente = "UPDATE Clientes SET nome = @nome, ano_fundacao = @ano_fundacao, telefone = @telefone, registro = @registro WHERE id_cliente = @id";

                try
                {
                    connection.Open();

                    SqlCommand commandCliente = new SqlCommand(queryCliente, connection);
                    commandCliente.Parameters.AddWithValue("@nome", nome);
                    commandCliente.Parameters.AddWithValue("@ano_fundacao", int.Parse(ano_fundacao));
                    commandCliente.Parameters.AddWithValue("@telefone", new string(telefone.Where(char.IsDigit).ToArray()));
                    commandCliente.Parameters.AddWithValue("@registro", new string(registro.Where(char.IsDigit).ToArray()));
                    commandCliente.Parameters.AddWithValue("@id", id);

                    commandCliente.ExecuteNonQuery();

                    MessageBox.Show("Cliente atualizado com sucesso!");
                    //CarregarClientes();
                    //LimparCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao atualizar cliente: " + ex.Message);
                }
            }
        }

        public static void ExcluirCliente(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //string queryExcluirEnderecos = "DELETE FROM Enderecos WHERE cliente_id = @cliente_id";
                string queryExcluirCliente = "DELETE FROM Clientes WHERE id_cliente = @id";

                try
                {
                    connection.Open();

                    //SqlCommand commandExcluirEnderecos = new SqlCommand(queryExcluirEnderecos, connection);
                    //commandExcluirEnderecos.Parameters.AddWithValue("@cliente_id", id);
                    //commandExcluirEnderecos.ExecuteNonQuery();

                    SqlCommand commandExcluirCliente = new SqlCommand(queryExcluirCliente, connection);
                    commandExcluirCliente.Parameters.AddWithValue("@id", id);
                    commandExcluirCliente.ExecuteNonQuery();

                    MessageBox.Show("Cliente e seus endereços excluídos com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir cliente: " + ex.Message);
                }
            }
        }


        // Atualizando a fonte de dados da grid de clientes
        // ClienteDAO.CarregarClientesComEndereco();
        // Método para carregar clientes com endereços

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}