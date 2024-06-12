﻿using CadastroCliente.models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroCliente
{
    public partial class Form1 : Form
    {
        private List<Cliente> clientes;
        private Cliente clienteSelecionado;

        public Form1()
        {
            InitializeComponent();
            CarregarClientes();
            InicializandoCheckTipoCliente();
            listBoxClientes.SelectedIndexChanged += listBoxClientes_SelectedIndexChanged;
        }

        private void CarregarClientes()
        {
            clientes = new List<Cliente>();

            string connectionString = "Data Source=dbserver-dev;Initial Catalog=treinamento;User ID=treinamento;Password=treinamento";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Id, Nome, Telefone, Endereco, AnoNascimento, Registro FROM Clientes";

                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Cliente cliente = new Cliente
                        {
                            Id = (int)reader["Id"],
                            Nome = reader["Nome"].ToString(),
                            Telefone = reader["Telefone"].ToString(),
                            Endereco = new Endereco { Rua = reader["Endereco"].ToString() },
                            AnoNascimento = int.Parse(reader["AnoNascimento"].ToString()),
                            Registro = reader["Registro"].ToString()
                        };

                        clientes.Add(cliente);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar clientes: " + ex.Message);
                }
            }

            listBoxClientes.DataSource = clientes;
            listBoxClientes.DisplayMember = "Nome";
        }

        private void listBoxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            clienteSelecionado = (Cliente)listBoxClientes.SelectedItem;
            if (clienteSelecionado != null)
            {
                textBoxNome.Text = clienteSelecionado.Nome;
                maskedTextBoxTelefone.Text = clienteSelecionado.Telefone;
                textBoxEnderecoCompleto.Text = clienteSelecionado.Endereco.RetornaEnderecoString();
                textBoxAoNascimento.Text = clienteSelecionado.AnoNascimento.ToString();
                maskedTextBoxRegistro.Text = clienteSelecionado.Registro;
            }
        }

        private void InicializandoCheckTipoCliente()
        {
            radioButtonPessoaFisica.CheckedChanged += new EventHandler(RadioButton_RegistroCheck);
            radioButtonPessoaJuridica.CheckedChanged += new EventHandler(RadioButton_RegistroCheck);

            radioButtonPessoaFisica.Checked = true;
        }

        private void RadioButton_RegistroCheck(object sender, EventArgs e)
        {
            if (radioButtonPessoaFisica.Checked)
            {
                maskedTextBoxRegistro.Mask = "000.000.000-00";
                maskedTextBoxRegistro.Text = string.Empty;
            }
            else if (radioButtonPessoaJuridica.Checked)
            {
                maskedTextBoxRegistro.Mask = "00.000.000/0000-00";
            }
        }

        private void salvarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            CadastrarClienteForm frm = new CadastrarClienteForm();
            frm.ShowDialog();
        }

        private void salvarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            buttonExcluir.Visible = false;
            buttonSalvar.Visible = false;
            CadastrarClienteForm frm = new CadastrarClienteForm();
            frm.ShowDialog();
            CarregarClientes();
        }

        private void editarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CarregarClientes();
            buttonSalvar.Visible = true;
            buttonExcluir.Visible = false;
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (clienteSelecionado != null)
            {
                ExcluirCliente(clienteSelecionado.Id);
            }
        }

        private void ExcluirCliente(int id)
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
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir cliente: " + ex.Message);
                }
            }
        }

        private void AtualizarCliente(int id)
        {
            string connectionString = "Data Source=dbserver-dev;Initial Catalog=treinamento;User ID=treinamento;Password=treinamento";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string queryCliente = "UPDATE Clientes SET Nome = @Nome, Telefone = @Telefone, Endereco = @Endereco, AnoNascimento = @AnoNascimento, Registro = @Registro WHERE Id = @Id";

                try
                {
                    connection.Open();

                    SqlCommand commandCliente = new SqlCommand(queryCliente, connection);
                    commandCliente.Parameters.AddWithValue("@Nome", textBoxNome.Text);
                    commandCliente.Parameters.AddWithValue("@Telefone", maskedTextBoxTelefone.Text);
                    commandCliente.Parameters.AddWithValue("@Endereco", textBoxEnderecoCompleto.Text);
                    commandCliente.Parameters.AddWithValue("@AnoNascimento", int.Parse(textBoxAoNascimento.Text));
                    commandCliente.Parameters.AddWithValue("@Registro", maskedTextBoxRegistro.Text);
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

        private void LimparCampos()
        {
            textBoxNome.Clear();
            textBoxAoNascimento.Clear();
            textBoxEnderecoCompleto.Clear();
            maskedTextBoxTelefone.Clear();
            maskedTextBoxRegistro.Clear();
            clienteSelecionado = null;
            buttonExcluir.Visible = false;
            buttonSalvar.Visible = false; // Adicione esta linha para esconder o botão de salvar
        }

        private void excluirToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            CarregarClientes();
            buttonExcluir.Visible = true;
            buttonSalvar.Visible = false;
        }

        private void editarToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            CarregarClientes();
            buttonExcluir.Visible = false;
            buttonSalvar.Visible = true;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void buttonSalvar_Click_1(object sender, EventArgs e)
        {
            if (clienteSelecionado != null)
            {
                AtualizarCliente(clienteSelecionado.Id);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}