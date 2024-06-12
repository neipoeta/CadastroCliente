using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CadastroCliente
{
    public partial class CadastrarClienteForm : Form
    {
        private bool clienteSalvo = false;
        public CadastrarClienteForm()
        {
            InitializeComponent();
        }


        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            SalvarCliente();
            clienteSalvo = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void SalvarCliente()
        {
            string connectionString = "Data Source=dbserver-dev;Initial Catalog=treinamento;User ID=treinamento;Password=treinamento";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string enderecoCompleto = $"{textBoxRua.Text}, {textBoxNumero.Text} - {textBoxBairro.Text}, {textBoxCidade.Text}, {textBoxUF.Text}";
                string queryCliente = "INSERT INTO Clientes (Nome, AnoNascimento, Telefone, Registro, Endereco) " +
                                      "OUTPUT INSERTED.Id " +
                                      "VALUES (@Nome, @AnoNascimento, @Telefone, @Registro, @Endereco)";

                string queryEndereco = "INSERT INTO Enderecos (Rua, Numero, Bairro, Cidade, Estado, ClienteId) " +
                                       "VALUES (@Rua, @Numero, @Bairro, @Cidade, @Estado, @ClienteId)";

                try
                {
                    connection.Open();

                    // Inserindo cliente
                    SqlCommand commandCliente = new SqlCommand(queryCliente, connection);
                    commandCliente.Parameters.AddWithValue("@Nome", textBoxNome.Text);
                    commandCliente.Parameters.AddWithValue("@AnoNascimento", int.Parse(textBoxAnoNascimento.Text));
                    commandCliente.Parameters.AddWithValue("@Telefone", maskedTextBoxTelefone.Text);
                    commandCliente.Parameters.AddWithValue("@Registro", maskedTextBoxRegistro.Text);
                    commandCliente.Parameters.AddWithValue("@Endereco", enderecoCompleto);

                    int clienteId = (int)commandCliente.ExecuteScalar();

                    // Inserindo endereço
                    SqlCommand commandEndereco = new SqlCommand(queryEndereco, connection);
                    commandEndereco.Parameters.AddWithValue("@Rua", textBoxRua.Text);
                    commandEndereco.Parameters.AddWithValue("@Numero", int.Parse(textBoxNumero.Text));
                    commandEndereco.Parameters.AddWithValue("@Bairro", textBoxBairro.Text);
                    commandEndereco.Parameters.AddWithValue("@Cidade", textBoxCidade.Text);
                    commandEndereco.Parameters.AddWithValue("@Estado", textBoxUF.Text);
                    commandEndereco.Parameters.AddWithValue("@ClienteId", clienteId);

                    commandEndereco.ExecuteNonQuery();

                    MessageBox.Show("Cliente salvo com sucesso!");
                    LimparCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao salvar cliente: " + ex.Message);
                }
            }
        }

        private void LimparCampos()
        {
            textBoxNome.Clear();
            textBoxAnoNascimento.Clear();
            textBoxRua.Clear();
            textBoxNumero.Clear();
            textBoxBairro.Clear();
            textBoxCidade.Clear();
            textBoxUF.Clear();
            maskedTextBoxTelefone.Clear();
            maskedTextBoxRegistro.Clear();
        }

        // Eventos de inicialização
        private void CadastrarClienteForm_Load(object sender, EventArgs e)
        {
            radioButtonPessoaFisica.Checked = true;
            this.FormClosing += new FormClosingEventHandler(CadastrarClienteForm_FormClosing);
        }

        private void radioButtonPessoaFisica_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonPessoaFisica.Checked)
            {
                maskedTextBoxRegistro.Mask = "000.000.000-00";
                maskedTextBoxRegistro.Text = string.Empty;
            }
            else if (radioButtonPessoaJuridica.Checked)
            {
                maskedTextBoxRegistro.Mask = "00.000.000/0000-00";
                maskedTextBoxRegistro.Text = string.Empty;
            }
        }

        private void CadastrarClienteForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!clienteSalvo)
            {
                var result = MessageBox.Show("Cliente não foi salvo, fechar mesmo assim?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}