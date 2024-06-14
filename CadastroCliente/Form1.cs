using CadastroCliente.models;
using System;
using System.Collections.Generic;
using System.Data;
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

        public Form1()
        {
            InitializeComponent();
            CarregarClientes();
            InicializandoCheckTipoCliente();
            listBoxClientes.SelectedIndexChanged += ListBoxClientes_ItemSelecionado;
            listBoxEnderecos.SelectedIndexChanged += ListBoxClientesEnderecos_ItemSelecionado;
            tabControl1.SelectedIndexChanged += TabControl1_SelectedIndexChanged;

            BloquearCamposEdicao(true);
            HabilitarCamposEndereco(false);
            buttonSalvarEndereco.Visible = false;
        }

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPageEnderecos)
            {
                if (clienteSelecionado == null && clientes.Count > 0)
                {
                    listBoxClientes.SelectedIndex = 0;
                    clienteSelecionado = (Cliente)listBoxClientes.SelectedItem;
                }

                if (clienteSelecionado != null)
                {
                    CarregarEnderecos(clienteSelecionado.Id);
                }
            }
        }

        //BD
        private void CarregarClientes()
        {
            clientes = new List<Cliente>();

            string connectionString = "Data Source=dbserver-dev;Initial Catalog=treinamento;User ID=treinamento;Password=treinamento";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string queryClientes = "SELECT Id, Nome, Telefone, AnoNascimento, Registro FROM Clientes";

                try
                {
                    connection.Open();
                    SqlCommand commandClientes = new SqlCommand(queryClientes, connection);
                    SqlDataReader readerClientes = commandClientes.ExecuteReader();

                    while (readerClientes.Read())
                    {
                        Cliente cliente = new Cliente
                        {
                            Id = (int)readerClientes["Id"],
                            Nome = readerClientes["Nome"].ToString(),
                            Telefone = readerClientes["Telefone"].ToString(),
                            AnoNascimento = int.Parse(readerClientes["AnoNascimento"].ToString()),
                            Registro = readerClientes["Registro"].ToString(),
                            Endereco = new Endereco() // Inicializa um Endereco vazio
                        };

                        clientes.Add(cliente);
                    }
                    readerClientes.Close();

                    foreach (var cliente in clientes)
                    {
                        string queryEnderecos = "SELECT Id, Rua, Numero, Bairro, Cidade, Estado FROM Enderecos WHERE ClienteId = @ClienteId";
                        SqlCommand commandEnderecos = new SqlCommand(queryEnderecos, connection);
                        commandEnderecos.Parameters.AddWithValue("@ClienteId", cliente.Id);

                        SqlDataReader readerEnderecos = commandEnderecos.ExecuteReader();
                        if (readerEnderecos.Read())
                        {
                            cliente.Endereco = new Endereco
                            {
                                Id = (int)readerEnderecos["Id"],
                                Rua = readerEnderecos["Rua"].ToString(),
                                Numero = readerEnderecos["Numero"].ToString(),
                                Bairro = readerEnderecos["Bairro"].ToString(),
                                Cidade = readerEnderecos["Cidade"].ToString(),
                                Estado = readerEnderecos["Estado"].ToString()
                            };
                        }
                        readerEnderecos.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar clientes: " + ex.Message);
                }
            }

            listBoxClientes.DataSource = clientes;
            listBoxClientes.DisplayMember = "Nome";
        }

        private void CarregarEnderecos(int clienteId)
        {
            enderecos = new List<Endereco>();

            string connectionString = "Data Source=dbserver-dev;Initial Catalog=treinamento;User ID=treinamento;Password=treinamento";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string queryEnderecos = "SELECT Id, Rua, Numero, Bairro, Cidade, Estado FROM Enderecos WHERE ClienteId = @ClienteId";

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
                            Id = (int)reader["Id"],
                            Rua = reader["Rua"].ToString(),
                            Numero = reader["Numero"].ToString(),
                            Bairro = reader["Bairro"].ToString(),
                            Cidade = reader["Cidade"].ToString(),
                            Estado = reader["Estado"].ToString(),
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

            listBoxEnderecos.DataSource = enderecos;
            listBoxEnderecos.DisplayMember = "Rua";
        }

        private void SalvarCliente()
        {
            string connectionString = "Data Source=dbserver-dev;Initial Catalog=treinamento;User ID=treinamento;Password=treinamento";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string enderecoCompleto = $"{textBoxRuaCad.Text}, {textBoxNumeroCad.Text} - {textBoxBairroCad.Text}, {textBoxCidadeCad.Text}, {textBoxUFCad.Text}";
                string queryCliente = "INSERT INTO Clientes (Nome, AnoNascimento, Telefone, Registro, Endereco) " +
                                      "OUTPUT INSERTED.Id " +
                                      "VALUES (@Nome, @AnoNascimento, @Telefone, @Registro, @Endereco)";

                string queryEndereco = "INSERT INTO Enderecos (Rua, Numero, Bairro, Cidade, Estado, ClienteId) " +
                                       "VALUES (@Rua, @Numero, @Bairro, @Cidade, @Estado, @ClienteId)";

                try
                {
                    connection.Open();

                    SqlCommand commandCliente = new SqlCommand(queryCliente, connection);
                    commandCliente.Parameters.AddWithValue("@Nome", textBoxNomeCad.Text);
                    commandCliente.Parameters.AddWithValue("@AnoNascimento", int.Parse(textBoxAnoNascimentoCad.Text));

                    string telefone = new string(maskedTextBoxTelefoneCad.Text.Where(char.IsDigit).ToArray());
                    string registro = new string(maskedTextBoxRegistroCad.Text.Where(char.IsDigit).ToArray());

                    commandCliente.Parameters.AddWithValue("@Telefone", telefone);
                    commandCliente.Parameters.AddWithValue("@Registro", registro);
                    commandCliente.Parameters.AddWithValue("@Endereco", enderecoCompleto);

                    int clienteId = (int)commandCliente.ExecuteScalar();

                    SqlCommand commandEndereco = new SqlCommand(queryEndereco, connection);
                    commandEndereco.Parameters.AddWithValue("@Rua", textBoxRuaCad.Text);
                    commandEndereco.Parameters.AddWithValue("@Numero", int.Parse(textBoxNumeroCad.Text));
                    commandEndereco.Parameters.AddWithValue("@Bairro", textBoxBairroCad.Text);
                    commandEndereco.Parameters.AddWithValue("@Cidade", textBoxCidadeCad.Text);
                    commandEndereco.Parameters.AddWithValue("@Estado", textBoxUFCad.Text);
                    commandEndereco.Parameters.AddWithValue("@ClienteId", clienteId);

                    commandEndereco.ExecuteNonQuery();

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
            string connectionString = "Data Source=dbserver-dev;Initial Catalog=treinamento;User ID=treinamento;Password=treinamento";

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
            string connectionString = "Data Source=dbserver-dev;Initial Catalog=treinamento;User ID=treinamento;Password=treinamento";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string queryCliente = "UPDATE Clientes SET Nome = @Nome, Telefone = @Telefone, AnoNascimento = @AnoNascimento, Registro = @Registro WHERE Id = @Id";

                try
                {
                    connection.Open();

                    SqlCommand commandCliente = new SqlCommand(queryCliente, connection);
                    commandCliente.Parameters.AddWithValue("@Nome", textBoxNomeCad.Text);
                    commandCliente.Parameters.AddWithValue("@AnoNascimento", int.Parse(textBoxAnoNascimentoCad.Text));

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

        private void AtualizarEndereco(Endereco endereco)
        {
            string connectionString = "Data Source=dbserver-dev;Initial Catalog=treinamento;User ID=treinamento;Password=treinamento";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Enderecos SET Rua = @Rua, Numero = @Numero, Bairro = @Bairro, Cidade = @Cidade, Estado = @Estado WHERE Id = @Id";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Rua", endereco.Rua);
                command.Parameters.AddWithValue("@Numero", endereco.Numero);
                command.Parameters.AddWithValue("@Bairro", endereco.Bairro);
                command.Parameters.AddWithValue("@Cidade", endereco.Cidade);
                command.Parameters.AddWithValue("@Estado", endereco.Estado);
                command.Parameters.AddWithValue("@Id", endereco.Id);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Endereço atualizado com sucesso!");
                    CarregarEnderecos(endereco.ClienteId);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao atualizar endereço: " + ex.Message);
                }
            }
        }

        private void ExcluirCliente(int id)
        {
            if (MessageBox.Show("Tem certeza de que deseja excluir este cliente?", "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string connectionString = "Data Source=dbserver-dev;Initial Catalog=treinamento;User ID=treinamento;Password=treinamento";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string queryEndereco = "DELETE FROM Enderecos WHERE ClienteId = @Id";
                    string queryCliente = "DELETE FROM Clientes WHERE Id = @Id";

                    try
                    {
                        connection.Open();

                        SqlCommand commandEndereco = new SqlCommand(queryEndereco, connection);
                        commandEndereco.Parameters.AddWithValue("@Id", id);
                        commandEndereco.ExecuteNonQuery();

                        SqlCommand commandCliente = new SqlCommand(queryCliente, connection);
                        commandCliente.Parameters.AddWithValue("@Id", id);
                        commandCliente.ExecuteNonQuery();

                        MessageBox.Show("Cliente excluído com sucesso!");
                        LimparCampos();
                        CarregarClientes();
                        buttonExcluir.Visible = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao excluir cliente: " + ex.Message);
                    }
                }
            }
        }

        private void ExcluirEndereco(Endereco enderecoSelecionado)
        {
            if (MessageBox.Show("Tem certeza de que deseja excluir este endereço?", "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string connectionString = "Data Source=dbserver-dev;Initial Catalog=treinamento;User ID=treinamento;Password=treinamento";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM Enderecos WHERE ClienteId = @ClienteId AND Id = @Id";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ClienteId", enderecoSelecionado.ClienteId);
                    command.Parameters.AddWithValue("@Id", enderecoSelecionado.Id);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Endereço excluído com sucesso!");
                        CarregarEnderecos(enderecoSelecionado.ClienteId);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao excluir endereço: " + ex.Message);
                    }
                }
            }
        }

        // Botoes Menu
        private void salvarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            LimparCampos();
            clienteSelecionado = null;
            BloquearCamposEdicao(false);
            BloquearCamposEdicaoEndereco(false);
            buttonExcluir.Visible = false;
            buttonSalvar.Visible = true;
        }

        private void excluirToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            CarregarClientes();
            BloquearCamposEdicao(true);
            BloquearCamposEdicaoEndereco(true);
            buttonExcluir.Visible = true;
            buttonSalvar.Visible = false;
        }

        private void editarToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            CarregarClientes();
            BloquearCamposEdicao(false);
            BloquearCamposEdicaoEndereco(true);
            buttonExcluir.Visible = false;
            buttonSalvar.Visible = true;
        }

        // Botoes
        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            if (clienteSelecionado != null)
            {
                AtualizarCliente(clienteSelecionado.Id);
            } else
            {
                SalvarCliente();
            }

        }

        private void buttonExcluir_Click_1(object sender, EventArgs e)
        {
            if (clienteSelecionado != null)
            {
                ExcluirCliente(clienteSelecionado.Id);
            }
        }


        private void buttonEnderecoNovo_Click(object sender, EventArgs e)
        {
            LimparCamposEndereco();
            listBoxEnderecos.SelectedItem = null;
            HabilitarCamposEndereco(true);
            buttonSalvarEndereco.Visible = true;
        }

        private void buttonEnderecoEditar_Click(object sender, EventArgs e)
        {
            buttonSalvarEndereco.Visible = true;
            HabilitarCamposEndereco(true);
        }

        private void buttonEnderecoExcluir_Click(object sender, EventArgs e)
        {
            Endereco enderecoSelecionado = (Endereco)listBoxEnderecos.SelectedItem;
            if (enderecoSelecionado != null)
            {
                ExcluirEndereco(enderecoSelecionado);
            }
        }

        private void buttonSalvarEndereco_Click_1(object sender, EventArgs e)
        {
            if (clienteSelecionado != null)
            {
                Endereco enderecoSelecionado = (Endereco)listBoxEnderecos.SelectedItem;
                if (enderecoSelecionado != null)
                {
                    enderecoSelecionado.Rua = textBoxEnderecoRua.Text;
                    enderecoSelecionado.Numero = textBoxEnderecoNumero.Text;
                    enderecoSelecionado.Bairro = textBoxEnderecoBairro.Text;
                    enderecoSelecionado.Cidade = textBoxEnderecoCidade.Text;
                    enderecoSelecionado.Estado = textBoxEnderecoUF.Text;
                    AtualizarEndereco(enderecoSelecionado);
                }
                else
                {
                    SalvarEndereco(clienteSelecionado.Id);
                }
            }

        }

        // Metodos
        private void ListBoxClientes_ItemSelecionado(object sender, EventArgs e)
        {
            clienteSelecionado = (Cliente)listBoxClientes.SelectedItem;
            if (clienteSelecionado != null)
            {
                textBoxNomeCad.Text = clienteSelecionado.Nome;
                maskedTextBoxTelefoneCad.Text = clienteSelecionado.Telefone;
                textBoxAnoNascimentoCad.Text = clienteSelecionado.AnoNascimento.ToString();
                maskedTextBoxRegistroCad.Text = clienteSelecionado.Registro;
                textBoxRuaCad.Text = clienteSelecionado.Endereco.Rua;
                textBoxNumeroCad.Text = clienteSelecionado.Endereco.Numero;
                textBoxBairroCad.Text = clienteSelecionado.Endereco.Bairro;
                textBoxCidadeCad.Text = clienteSelecionado.Endereco.Cidade;
                textBoxUFCad.Text = clienteSelecionado.Endereco.Estado;

                CarregarEnderecos(clienteSelecionado.Id);
            }
        }

        private void ListBoxClientesEnderecos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Endereco enderecoSelecionado = (Endereco)listBoxEnderecos.SelectedItem;
            if (enderecoSelecionado != null)
            {
                textBoxEnderecoRua.Text = enderecoSelecionado.Rua;
                textBoxEnderecoNumero.Text = enderecoSelecionado.Numero;
                textBoxEnderecoBairro.Text = enderecoSelecionado.Bairro;
                textBoxEnderecoUF.Text = enderecoSelecionado.Estado;
                textBoxEnderecoCidade.Text = enderecoSelecionado.Cidade;
            }
        }

        private void InicializandoCheckTipoCliente()
        {
            radioButtonPessoaFisicaCad.CheckedChanged += new EventHandler(radioButtonPessoaFisicaCad_CheckedChanged);
            radioButtonPessoaJuridicaCad.CheckedChanged += new EventHandler(radioButtonPessoaFisicaCad_CheckedChanged);

            radioButtonPessoaFisicaCad.Checked = true;
        }

        private void radioButtonPessoaFisicaCad_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonPessoaFisicaCad.Checked)
            {
                maskedTextBoxRegistroCad.Mask = "000.000.000-00";
                maskedTextBoxRegistroCad.Text = string.Empty;
            }
            else if (radioButtonPessoaJuridicaCad.Checked)
            {
                maskedTextBoxRegistroCad.Mask = "00.000.000/0000-00";
                maskedTextBoxRegistroCad.Text = string.Empty;
            }
        }

        private void HabilitarCamposEndereco(bool liberar)
        {
            textBoxEnderecoRua.ReadOnly = !liberar;
            textBoxEnderecoNumero.ReadOnly = !liberar;
            textBoxEnderecoBairro.ReadOnly = !liberar;
            textBoxEnderecoUF.ReadOnly = !liberar;
            textBoxEnderecoCidade.ReadOnly = !liberar;
        }

        private void LimparCamposEndereco()
        {
            textBoxEnderecoRua.Clear();
            textBoxEnderecoNumero.Clear();
            textBoxEnderecoBairro.Clear();
            textBoxEnderecoUF.Clear();
            textBoxEnderecoCidade.Clear();
        }

        private void LimparCampos()
        {
            textBoxNomeCad.Clear();
            textBoxAnoNascimentoCad.Clear();
            textBoxRuaCad.Clear();
            textBoxNumeroCad.Clear();
            textBoxBairroCad.Clear();
            textBoxCidadeCad.Clear();
            textBoxUFCad.Clear();
            maskedTextBoxTelefoneCad.Clear();
            maskedTextBoxRegistroCad.Clear();

            clienteSelecionado = null;
            buttonExcluir.Visible = false;
            buttonSalvar.Visible = false;
        }

        private void BloquearCamposEdicao(bool bloquear)
        {
            textBoxNomeCad.ReadOnly = bloquear;
            maskedTextBoxTelefoneCad.ReadOnly = bloquear;
            textBoxAnoNascimentoCad.ReadOnly = bloquear;
            maskedTextBoxRegistroCad.ReadOnly = bloquear;
        }

        private void BloquearCamposEdicaoEndereco(bool bloquear)
        {
            textBoxRuaCad.ReadOnly = bloquear;
            textBoxNumeroCad.ReadOnly = bloquear;
            textBoxBairroCad.ReadOnly = bloquear;
            textBoxCidadeCad.ReadOnly = bloquear;
            textBoxUFCad.ReadOnly = bloquear;
        }

        private void ListBoxClientesEnderecos_ItemSelecionado(object sender, EventArgs e)
        {
            Endereco enderecoSelecionado = (Endereco)listBoxEnderecos.SelectedItem;
            if (enderecoSelecionado != null)
            {
                textBoxEnderecoRua.Text = enderecoSelecionado.Rua;
                textBoxEnderecoNumero.Text = enderecoSelecionado.Numero;
                textBoxEnderecoBairro.Text = enderecoSelecionado.Bairro;
                textBoxEnderecoUF.Text = enderecoSelecionado.Estado;
                textBoxEnderecoCidade.Text = enderecoSelecionado.Cidade;
            }
        }

        // Forms Inicializados
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
