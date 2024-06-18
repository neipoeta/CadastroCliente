using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace CadastroCliente
{
    public partial class Form1 : Form
    {
        private string connectionString = "Data Source=dbserver-dev;Initial Catalog=treinamento;User ID=treinamento;Password=treinamento";
        private bool novoCliente;
        private bool novoEndereco;
        private bool novoEnderecoCadastroCliente;
        private int clienteIdAtual = -1;
        private int enderecoAtual = -1;

        public Form1()
        {
            InitializeComponent();
            CarregarClientes();
            tabControlClientes.SelectedIndexChanged += TabControlClientes_SelectedIndexChanged;

            BloquearCamposEdicao(true);
            HabilitarCamposEndereco(false);
            buttonEnderecoConfirmarSalvar.Visible = false;

        }

        private void TabControlClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlClientes.SelectedTab == tabPageClientes)
            {
                if (dataGridViewClientes.Rows.Count > 0)
                {
                    if (dataGridViewClientes.SelectedRows.Count == 0)
                    {
                        dataGridViewClientes.ClearSelection();
                        dataGridViewClientes.Rows[0].Selected = true;
                    }
                    PreencherCamposCliente(dataGridViewClientes.SelectedRows[0]);
                }
            }
            else if (tabControlClientes.SelectedTab == tabPageEnderecos)
            {
                if (clienteIdAtual != -1)
                {
                    CarregarEnderecos(clienteIdAtual);
                }
                else
                {
                    dataGridViewEnderecos.DataSource = null;
                }
            }
        }

        #region DAO
        private void CarregarClientes()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string queryClientes = "SELECT id_cliente AS Codigo, nome AS Nome, telefone AS Telefone, ano_fundacao AS AnoFundacao, registro AS Registro FROM clientes";

                try
                {
                    connection.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(queryClientes, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridViewClientes.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar clientes: " + ex.Message);
                }
            }
        }

        private void CarregarEnderecos(int clienteId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string queryEnderecos = "SELECT id_endereco, rua, numero, bairro, cidade, uf FROM enderecos WHERE cliente_id = @clienteId";

                SqlCommand command = new SqlCommand(queryEnderecos, connection);
                command.Parameters.AddWithValue("@clienteId", clienteId);

                try
                {
                    connection.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridViewEnderecos.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar endereços: " + ex.Message);
                }
            }
        }

        private void IncluirCliente()
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
                    commandCliente.Parameters.AddWithValue("@nome", textBoxNomeCad.Text);
                    commandCliente.Parameters.AddWithValue("@ano_fundacao", int.Parse(textBoxAnoFundacaoCad.Text));
                    commandCliente.Parameters.AddWithValue("@telefone", new string(maskedTextBoxTelefoneCad.Text.Where(char.IsDigit).ToArray()));
                    commandCliente.Parameters.AddWithValue("@registro", new string(maskedTextBoxRegistroCad.Text.Where(char.IsDigit).ToArray()));

                    clienteIdAtual = (int)commandCliente.ExecuteScalar();

                    MessageBox.Show("Cliente salvo com sucesso!");
                    CarregarClientes();
                    LimparCampos();
                    NavegarParaEndereco(clienteIdAtual);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao salvar cliente: " + ex.Message);
                }
            }
        }

        private void IncluirEndereco(int clienteId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Enderecos (rua, numero, bairro, cidade, uf, cliente_id) VALUES (@rua, @numero, @bairro, @cidade, @uf, @cliente_id)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@rua", textBoxEnderecoRua.Text);
                command.Parameters.AddWithValue("@numero", textBoxEnderecoNumero.Text);
                command.Parameters.AddWithValue("@bairro", textBoxEnderecoBairro.Text);
                command.Parameters.AddWithValue("@cidade", textBoxEnderecoCidade.Text);
                command.Parameters.AddWithValue("@uf", textBoxEnderecoUF.Text);
                command.Parameters.AddWithValue("@cliente_id", clienteId);

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
                string queryCliente = "UPDATE Clientes SET nome = @nome, telefone = @telefone, ano_fundacao = @ano_fundacao, registro = @registro WHERE id_cliente = @id";

                try
                {
                    connection.Open();

                    SqlCommand commandCliente = new SqlCommand(queryCliente, connection);
                    commandCliente.Parameters.AddWithValue("@nome", textBoxNomeCad.Text);
                    commandCliente.Parameters.AddWithValue("@ano_fundacao", int.Parse(textBoxAnoFundacaoCad.Text));
                    commandCliente.Parameters.AddWithValue("@telefone", new string(maskedTextBoxTelefoneCad.Text.Where(char.IsDigit).ToArray()));
                    commandCliente.Parameters.AddWithValue("@registro", new string(maskedTextBoxRegistroCad.Text.Where(char.IsDigit).ToArray()));
                    commandCliente.Parameters.AddWithValue("@id", id);

                    commandCliente.ExecuteNonQuery();

                    MessageBox.Show("Cliente atualizado com sucesso!");
                    CarregarClientes();
                    LimparCampos();
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
                string queryExcluirEnderecos = "DELETE FROM Enderecos WHERE cliente_id = @cliente_id";
                string queryExcluirCliente = "DELETE FROM Clientes WHERE id_cliente = @id";

                try
                {
                    connection.Open();

                    SqlCommand commandExcluirEnderecos = new SqlCommand(queryExcluirEnderecos, connection);
                    commandExcluirEnderecos.Parameters.AddWithValue("@cliente_id", id);
                    commandExcluirEnderecos.ExecuteNonQuery();

                    SqlCommand commandExcluirCliente = new SqlCommand(queryExcluirCliente, connection);
                    commandExcluirCliente.Parameters.AddWithValue("@id", id);
                    commandExcluirCliente.ExecuteNonQuery();

                    MessageBox.Show("Cliente e seus endereços excluídos com sucesso!");
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
                string query = "UPDATE Enderecos SET rua = @rua, numero = @numero, bairro = @bairro, cidade = @cidade, uf = @uf WHERE id_endereco = @id";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@rua", textBoxEnderecoRua.Text);
                command.Parameters.AddWithValue("@numero", textBoxEnderecoNumero.Text);
                command.Parameters.AddWithValue("@bairro", textBoxEnderecoBairro.Text);
                command.Parameters.AddWithValue("@cidade", textBoxEnderecoCidade.Text);
                command.Parameters.AddWithValue("@uf", textBoxEnderecoUF.Text);
                command.Parameters.AddWithValue("@id", id);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Endereço atualizado com sucesso!");
                    CarregarEnderecos(clienteIdAtual);
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
                string query = "DELETE FROM Enderecos WHERE id_endereco = @id";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Endereço excluído com sucesso!");
                    CarregarEnderecos(clienteIdAtual); // Use clienteIdAtual to load addresses
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir endereço: " + ex.Message);
                }
            }
        }
        #endregion

        #region EventsClicks
        private void DataGridViewClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow rowClientes = this.dataGridViewClientes.Rows[e.RowIndex];
                PreencherCamposCliente(rowClientes);
                clienteIdAtual = Convert.ToInt32(rowClientes.Cells[0].Value);
            }
        }

        private void DataGridViewEnderecos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewEnderecos.Rows[e.RowIndex];
                PreencherCamposEndereco(row);
                enderecoAtual = Convert.ToInt32(row.Cells[0].Value);
            }
        }

        private void ButtonClienteConfirmar_Click(object sender, EventArgs e)
        {
            if (!ValidacaoUtils.ValidarCamposClientes(
                textBoxNomeCad.Text,
                textBoxAnoFundacaoCad.Text,
                maskedTextBoxRegistroCad.Text,
                maskedTextBoxTelefoneCad.Text
            ))
            {
                return;
            }

            maskedTextBoxRegistroCad.Mask = "";
            maskedTextBoxTelefoneCad.Mask = "";

            if (novoCliente)
            {
                IncluirCliente();
            }
            else
            {
                AtualizarCliente(clienteIdAtual);
            }

            BloquearCamposEdicao(true);
        }

        private void ButtonEnderecoConfirmar_Click(object sender, EventArgs e)
        {
            if (!ValidacaoUtils.ValidarCamposEnderecos(
                textBoxEnderecoRua.Text,
                textBoxEnderecoNumero.Text,
                textBoxEnderecoBairro.Text,
                textBoxEnderecoCidade.Text,
                textBoxEnderecoUF.Text
            ))
            {
                return;
            }

            if(!novoEnderecoCadastroCliente)
            {
                if (!novoEndereco)
                {
                    AtualizarEndereco(enderecoAtual);
                } else
                {
                    IncluirEndereco(clienteIdAtual);
                }              
            } else
            {
                IncluirEndereco(clienteIdAtual);
            }
           

            BloquearCamposEdicao(true);
            LimparCampos();
            novoEndereco = false;
            novoEnderecoCadastroCliente = false;
            tabControlClientes.SelectedTab = tabPageClientes;
        }

        private void ButtonClienteNovo_Click(object sender, EventArgs e)
        {
            LimparCampos();
            BloquearCamposEdicao(false);
            CriarMaskaras();
            radioButtonPessoaFisicaCad.Checked = true;
            radioButtonPessoaJuridicaCad.Checked = false;
            novoCliente = true;
            clienteIdAtual = -1;
            novoEnderecoCadastroCliente = true;
        }

        private void ButtonClienteEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewClientes.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridViewClientes.SelectedRows[0];
                PreencherCamposCliente(row);
                clienteIdAtual = Convert.ToInt32(row.Cells[0].Value);
            }
            else if (dataGridViewClientes.Rows.Count > 0)
            {
                dataGridViewClientes.ClearSelection();
                dataGridViewClientes.Rows[0].Selected = true;
                DataGridViewRow row = dataGridViewClientes.Rows[0];
                PreencherCamposCliente(row);
                clienteIdAtual = Convert.ToInt32(row.Cells[0].Value);
            }

            BloquearCamposEdicao(false);
            string registro = maskedTextBoxRegistroCad.Text.Replace(".", "").Replace("-", "").Replace("/", "").Trim();
            if (registro.Length > 14)
            {
                maskedTextBoxRegistroCad.Mask = "00.000.000/0000-00";
            }
            else
            {
                maskedTextBoxRegistroCad.Mask = "000.000.000-00";
            }
            novoCliente = false;
        }

        private void ButtonClienteExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridViewClientes.SelectedCells.Count > 0)
            {
                var result = MessageBox.Show("Você tem certeza que deseja excluir este cliente?", "Confirmação de Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    ExcluirCliente(clienteIdAtual);
                }
            }
        }

        private void ButtonEnderecoNovo_Click(object sender, EventArgs e)
        {
            LimparCampos();
            HabilitarCamposEndereco(true);
            buttonEnderecoConfirmarSalvar.Visible = true;
            novoEndereco = true;
        }

        private void ButtonEnderecoEditar_Click(object sender, EventArgs e)
        {
            novoEndereco = false;
            novoEnderecoCadastroCliente = false;
            if (dataGridViewEnderecos.SelectedCells.Count > 0)
            {
                DataGridViewRow row = dataGridViewEnderecos.Rows[0];
                PreencherCamposEndereco(row);
            }
            HabilitarCamposEndereco(true);
            buttonEnderecoConfirmarSalvar.Visible = true;
        }

        private void ButtonEnderecoExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridViewEnderecos.SelectedCells.Count > 0)
            {
                var result = MessageBox.Show("Você tem certeza que deseja excluir este endereco?", "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(result == DialogResult.Yes)
                {
                    ExcluirEndereco(enderecoAtual);
                }
            }
        }

        private void SalvarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //Strip Clique Correto
            if (tabControlClientes.SelectedTab == tabPageClientes)
            {
                ButtonClienteNovo_Click(sender, e);
            } else if (tabControlClientes.SelectedTab == tabPageEnderecos)
            {
                ButtonEnderecoNovo_Click(sender, e);
            }
        }

        private void EditarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (tabControlClientes.SelectedTab == tabPageClientes)
            {
                ButtonClienteEditar_Click(sender, e);
            }
            else if (tabControlClientes.SelectedTab == tabPageEnderecos)
            {
                ButtonEnderecoEditar_Click(sender, e);
            }
        }

        private void ExcluirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Strip Clique Correto
            if (tabControlClientes.SelectedTab == tabPageClientes)
            {
                ButtonClienteExcluir_Click(sender, e);
            }
            else if (tabControlClientes.SelectedTab == tabPageEnderecos)
            {
                ButtonEnderecoExcluir_Click(sender, e);
            }
        }
        #endregion

        #region auxiliares
        private void LimparCampos()
        {
            textBoxNomeCad.Clear();
            maskedTextBoxTelefoneCad.Clear();
            textBoxAnoFundacaoCad.Clear();
            maskedTextBoxRegistroCad.Clear();
            textBoxEnderecoRua.Clear();
            textBoxEnderecoNumero.Clear();
            textBoxEnderecoBairro.Clear();
            textBoxEnderecoCidade.Clear();
        }

        private void BloquearCamposEdicao(bool bloqueio)
        {
            textBoxNomeCad.Enabled = !bloqueio;
            textBoxAnoFundacaoCad.Enabled = !bloqueio;
            maskedTextBoxTelefoneCad.Enabled = !bloqueio;
            maskedTextBoxRegistroCad.Enabled = !bloqueio;
            radioButtonPessoaFisicaCad.Enabled = !bloqueio;
            radioButtonPessoaJuridicaCad.Enabled = !bloqueio;

            textBoxEnderecoRua.Enabled = !bloqueio;
            textBoxEnderecoNumero.Enabled = !bloqueio;
            textBoxEnderecoBairro.Enabled = !bloqueio;
            textBoxEnderecoUF.Enabled = !bloqueio;
            textBoxEnderecoCidade.Enabled = !bloqueio;
        }

        private void HabilitarCamposEndereco(bool habilitar)
        {
            textBoxEnderecoRua.Enabled = habilitar;
            textBoxEnderecoNumero.Enabled = habilitar;
            textBoxEnderecoBairro.Enabled = habilitar;
            textBoxEnderecoUF.Enabled = habilitar;
            textBoxEnderecoCidade.Enabled = habilitar;
        }

        private void CriarMaskaras()
        {
            string registro = maskedTextBoxRegistroCad.Text.Replace(".", "").Replace("-", "").Replace("/", "").Trim();
            if (registro.Length > 11)
            {
                maskedTextBoxRegistroCad.Mask = "00.000.000/0000-00";
            }
            else
            {
                maskedTextBoxRegistroCad.Mask = "000.000.000-00";
            }
        }

        private void RadioButtonPessoaFisicaCad_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonPessoaFisicaCad.Checked)
            {
                maskedTextBoxRegistroCad.Mask = "000.000.000-00";
            }
        }

        private void RadioButtonPessoaJuridicaCad_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonPessoaJuridicaCad.Checked)
            {
                maskedTextBoxRegistroCad.Mask = "00.000.000/0000-00";
            }
        }

        private void PreencherCamposCliente(DataGridViewRow row)
        {
            textBoxNomeCad.Text = row.Cells[1].Value.ToString();
            textBoxAnoFundacaoCad.Text = row.Cells[3].Value.ToString();
            maskedTextBoxTelefoneCad.Text = row.Cells[2].Value.ToString();
            maskedTextBoxRegistroCad.Text = row.Cells[4].Value.ToString();
        }

        private void PreencherCamposEndereco(DataGridViewRow row)
        {
            textBoxEnderecoRua.Text = row.Cells[1].Value.ToString();
            textBoxEnderecoNumero.Text = row.Cells[2].Value.ToString();
            textBoxEnderecoBairro.Text = row.Cells[3].Value.ToString();
            textBoxEnderecoCidade.Text = row.Cells[4].Value.ToString();
            textBoxEnderecoUF.Text = row.Cells[5].Value.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.enderecosTableAdapter.Fill(this.dataSetCliente.enderecos);
            this.clientesTableAdapter.Fill(this.dataSetCliente.clientes);
        }

        private void NavegarParaEndereco(int clienteId)
        {
            tabControlClientes.SelectedTab = tabPageEnderecos;
            LimparCampos();
            HabilitarCamposEndereco(true);
            buttonEnderecoConfirmarSalvar.Visible = true;
            dataGridViewEnderecos.DataSource = null;
            MessageBox.Show("Cliente incluído com sucesso! Cadastre o endereço.");
        }
        #endregion
    }
}
