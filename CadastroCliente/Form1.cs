using CadastroCliente.models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace CadastroCliente
{
    public partial class Form1 : Form
    {
        private List<Cliente> clientes;
        private Cliente clienteSelecionado;
        private List<Endereco> enderecos;
        private string connectionString = "Data Source=dbserver-dev;Initial Catalog=treinamento;User ID=treinamento;Password=treinamento";

        public Form1()
        {
            InitializeComponent();
            CarregarClientes();
            //InicializandoCheckTipoCliente();
            tabControl1.SelectedIndexChanged += TabControl1_SelectedIndexChanged;

            BloquearCamposEdicao(true);
            HabilitarCamposEndereco(false);
            buttonSalvarEndereco.Visible = false;

            // Event handlers for DataGridView selection changes
            dataGridViewClientes.SelectionChanged += DataGridViewClientes_SelectionChanged;
            dataGridViewEnderecos.SelectionChanged += DataGridViewEnderecos_SelectionChanged;
        }

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPageEnderecos)
            {
                if (clienteSelecionado == null && clientes.Count > 0)
                {
                    dataGridViewClientes.ClearSelection();
                    dataGridViewClientes.Rows[0].Selected = true;
                }

                if (clienteSelecionado != null)
                {
                    CarregarEnderecos(clienteSelecionado.Id);
                }
            }
        }

        private void DataGridViewClientes_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewClientes.SelectedRows.Count > 0)
            {
                clienteSelecionado = (Cliente)dataGridViewClientes.SelectedRows[0].DataBoundItem;
                if (clienteSelecionado != null)
                {
                    textBoxNomeCad.Text = clienteSelecionado.Nome;
                    maskedTextBoxTelefoneCad.Text = clienteSelecionado.Telefone;
                    textBoxAnoFundacaoCad.Text = clienteSelecionado.AnoFundacao.ToString();
                    maskedTextBoxRegistroCad.Text = clienteSelecionado.Registro;
                    CarregarEnderecos(clienteSelecionado.Id);
                }
            }
        }

        private void DataGridViewEnderecos_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewEnderecos.SelectedRows.Count > 0)
            {
                Endereco enderecoSelecionado = (Endereco)dataGridViewEnderecos.SelectedRows[0].DataBoundItem;
                if (enderecoSelecionado != null)
                {
                    textBoxEnderecoRua.Text = enderecoSelecionado.Rua;
                    textBoxEnderecoNumero.Text = enderecoSelecionado.Numero;
                    textBoxEnderecoBairro.Text = enderecoSelecionado.Bairro;
                    textBoxEnderecoUF.Text = enderecoSelecionado.Estado;
                    textBoxEnderecoCidade.Text = enderecoSelecionado.Cidade;
                }
            }
        }

        #region BD
        private void CarregarClientes()
        {
            clientes = new List<Cliente>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string queryClientes = "SELECT id_cliente, nome, telefone, ano_fundacao, registro FROM clientes";

                try
                {
                    connection.Open();
                    SqlCommand commandClientes = new SqlCommand(queryClientes, connection);
                    SqlDataReader readerClientes = commandClientes.ExecuteReader();

                    while (readerClientes.Read())
                    {
                        Cliente cliente = new Cliente
                        {
                            Id = (int)readerClientes["id_cliente"],
                            Nome = readerClientes["nome"].ToString(),
                            Telefone = readerClientes["telefone"].ToString(),
                            AnoFundacao = int.Parse(readerClientes["ano_fundacao"].ToString()),
                            Registro = readerClientes["registro"].ToString(),
                        };

                        clientes.Add(cliente);
                    }
                    readerClientes.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar clientes: " + ex.Message);
                }
            }

            dataGridViewClientes.DataSource = clientes;
        }

        private void CarregarEnderecos(int clienteId)
        {
            enderecos = new List<Endereco>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string queryEnderecos = "SELECT id_endereco, rua, numero, bairro, cidade, estado FROM enderecos WHERE cliente_id = @ClienteId";

                SqlCommand command = new SqlCommand(queryEnderecos, connection);
                command.Parameters.AddWithValue("@ClienteId", clienteId);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Endereco endereco = new Endereco
                        {
                            Id = (int)reader["id_endereco"],
                            Rua = reader["rua"].ToString(),
                            Numero = reader["numero"].ToString(),
                            Bairro = reader["bairro"].ToString(),
                            Cidade = reader["cidade"].ToString(),
                            Estado = reader["estado"].ToString(),
                            ClienteId = clienteId
                        };

                        enderecos.Add(endereco);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar endereços: " + ex.Message);
                }
            }

            dataGridViewEnderecos.DataSource = enderecos;
        }

        private void SalvarCliente()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string queryCliente = "INSERT INTO Clientes (Nome, AnoFundacao, Telefone, Registro) " +
                                      "OUTPUT INSERTED.id_cliente " +
                                      "VALUES (@Nome, @AnoFundacao, @Telefone, @Registro)";

                try
                {
                    connection.Open();

                    SqlCommand commandCliente = new SqlCommand(queryCliente, connection);
                    commandCliente.Parameters.AddWithValue("@Nome", textBoxNomeCad.Text);
                    commandCliente.Parameters.AddWithValue("@AnoFundacao", int.Parse(textBoxAnoFundacaoCad.Text));

                    string telefone = new string(maskedTextBoxTelefoneCad.Text.Where(char.IsDigit).ToArray());
                    string registro = new string(maskedTextBoxRegistroCad.Text.Where(char.IsDigit).ToArray());

                    commandCliente.Parameters.AddWithValue("@Telefone", telefone);
                    commandCliente.Parameters.AddWithValue("@Registro", registro);

                    int clienteId = (int)commandCliente.ExecuteScalar();

                    MessageBox.Show("Cliente salvo com sucesso!");
                    LimparCampos();
                    CarregarClientes();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao salvar cliente: " + ex.Message);
                }
            }
        }

        private void SalvarEndereco(int clienteId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Enderecos (Rua, Numero, Bairro, Cidade, Estado, ClienteId) VALUES (@Rua, @Numero, @Bairro, @Cidade, @Estado, @ClienteId)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Rua", textBoxEnderecoRua.Text);
                command.Parameters.AddWithValue("@Numero", textBoxEnderecoNumero.Text);
                command.Parameters.AddWithValue("@Bairro", textBoxEnderecoBairro.Text);
                command.Parameters.AddWithValue("@Cidade", textBoxEnderecoCidade.Text);
                command.Parameters.AddWithValue("@Estado", textBoxEnderecoUF.Text);
                command.Parameters.AddWithValue("@ClienteId", clienteId);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Endereço criado com sucesso!");
                    CarregarEnderecos(clienteId);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao criar endereço: " + ex.Message);
                }
            }
        }

        private void AtualizarCliente(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string queryCliente = "UPDATE Clientes SET Nome = @Nome, Telefone = @Telefone, AnoFundacao = @AnoFundacao, Registro = @Registro WHERE id_cliente = @Id";

                try
                {
                    connection.Open();

                    SqlCommand commandCliente = new SqlCommand(queryCliente, connection);
                    commandCliente.Parameters.AddWithValue("@Nome", textBoxNomeCad.Text);
                    commandCliente.Parameters.AddWithValue("@AnoFundacao", int.Parse(textBoxAnoFundacaoCad.Text));

                    string telefone = new string(maskedTextBoxTelefoneCad.Text.Where(char.IsDigit).ToArray());
                    string registro = new string(maskedTextBoxRegistroCad.Text.Where(char.IsDigit).ToArray());

                    commandCliente.Parameters.AddWithValue("@Telefone", telefone);
                    commandCliente.Parameters.AddWithValue("@Registro", registro);
                    commandCliente.Parameters.AddWithValue("@Id", id);

                    commandCliente.ExecuteNonQuery();

                    MessageBox.Show("Cliente atualizado com sucesso!");
                    LimparCampos();
                    CarregarClientes();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao atualizar cliente: " + ex.Message);
                }
            }
        }

        private void ExcluirCliente(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Clientes WHERE id_cliente = @Id";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Cliente excluído com sucesso!");
                    CarregarClientes();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir cliente: " + ex.Message);
                }
            }
        }

        private void AtualizarEndereco(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Enderecos SET Rua = @Rua, Numero = @Numero, Bairro = @Bairro, Cidade = @Cidade, Estado = @Estado WHERE id_endereco = @Id";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Rua", textBoxEnderecoRua.Text);
                command.Parameters.AddWithValue("@Numero", textBoxEnderecoNumero.Text);
                command.Parameters.AddWithValue("@Bairro", textBoxEnderecoBairro.Text);
                command.Parameters.AddWithValue("@Cidade", textBoxEnderecoCidade.Text);
                command.Parameters.AddWithValue("@Estado", textBoxEnderecoUF.Text);
                command.Parameters.AddWithValue("@Id", id);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Endereço atualizado com sucesso!");
                    CarregarEnderecos(clienteSelecionado.Id);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao atualizar endereço: " + ex.Message);
                }
            }
        }

        private void ExcluirEndereco(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Enderecos WHERE id_endereco = @Id";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Endereço excluído com sucesso!");
                    CarregarEnderecos(clienteSelecionado.Id);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir endereço: " + ex.Message);
                }
            }
        }
        #endregion

        #region Componentes

        private void LimparCampos()
        {
            textBoxNomeCad.Clear();
            maskedTextBoxTelefoneCad.Clear();
            textBoxAnoFundacaoCad.Clear();
            maskedTextBoxRegistroCad.Clear();
            textBoxEnderecoRua.Clear();
            textBoxEnderecoNumero.Clear();
            textBoxEnderecoBairro.Clear();
            textBoxEnderecoUF.Clear();
            textBoxEnderecoCidade.Clear();
        }

        private void BloquearCamposEdicao(bool bloqueio)
        {
            textBoxNomeCad.Enabled = !bloqueio;
            textBoxAnoFundacaoCad.Enabled = !bloqueio;
            maskedTextBoxTelefoneCad.Enabled = !bloqueio;
            maskedTextBoxRegistroCad.Enabled = !bloqueio;
        }

        private void HabilitarCamposEndereco(bool habilitar)
        {
            textBoxEnderecoRua.Enabled = habilitar;
            textBoxEnderecoNumero.Enabled = habilitar;
            textBoxEnderecoBairro.Enabled = habilitar;
            textBoxEnderecoUF.Enabled = habilitar;
            textBoxEnderecoCidade.Enabled = habilitar;
        }

        #endregion

        #region Eventos
        private void buttonNovo_Click(object sender, EventArgs e)
        {
            LimparCampos();
            BloquearCamposEdicao(false);
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            if (clienteSelecionado == null)
            {
                SalvarCliente();
            }
            else
            {
                AtualizarCliente(clienteSelecionado.Id);
            }

            BloquearCamposEdicao(true);
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            BloquearCamposEdicao(false);
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (clienteSelecionado != null)
            {
                ExcluirCliente(clienteSelecionado.Id);
            }
        }

        private void buttonSalvarEndereco_Click(object sender, EventArgs e)
        {
            if (clienteSelecionado != null)
            {
                SalvarEndereco(clienteSelecionado.Id);
            }
        }

        private void buttonNovoEndereco_Click(object sender, EventArgs e)
        {
            LimparCampos();
            HabilitarCamposEndereco(true);
            buttonSalvarEndereco.Visible = true;
        }

        private void buttonEditarEndereco_Click(object sender, EventArgs e)
        {
            HabilitarCamposEndereco(true);
            buttonSalvarEndereco.Visible = true;
        }

        private void buttonExcluirEndereco_Click(object sender, EventArgs e)
        {
            if (dataGridViewEnderecos.SelectedRows.Count > 0)
            {
                Endereco enderecoSelecionado = (Endereco)dataGridViewEnderecos.SelectedRows[0].DataBoundItem;
                if (enderecoSelecionado != null)
                {
                    ExcluirEndereco(enderecoSelecionado.Id);
                }
            }
        }
        #endregion
    }
}
