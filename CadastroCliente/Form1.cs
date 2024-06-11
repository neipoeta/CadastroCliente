using CadastroCliente.models;
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

        public Form1()
        {
            InitializeComponent();
            CarregarClientes();

            InicializandoCheckTipoCliente();
        }

        private void CarregarClientes()
        {
            clientes = new List<Cliente>();

            string connectionString = "Data Source=dbserver-dev;Initial Catalog=treinamento;User ID=treinamento;Password=treinamento";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Nome, Telefone, Endereco, AnoNascimento, Registro FROM Clientes";

                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Cliente cliente = new Cliente
                        {
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
            var cliente = (Cliente)listBoxClientes.SelectedItem;
            if (cliente != null)
            {
                textBoxNome.Text = cliente.Nome;
                textBox2.Text = cliente.Telefone;
                textBox1.Text = cliente.Endereco.RetornaEnderecoString();
                textBox3.Text = cliente.AnoNascimento.ToString();
                maskedTextBoxRegistro.Text = cliente.Registro;
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
            if(radioButtonPessoaFisica.Checked)
            {
                maskedTextBoxRegistro.Mask = "000.000.000-00";
                maskedTextBoxRegistro.Text = string.Empty;
            }
            else if(radioButtonPessoaJuridica.Checked)
            {
                maskedTextBoxRegistro.Mask = "00.000.000/0000-00";
            }
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarClienteForm frm = new CadastrarClienteForm();
            frm.Show();
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void editarToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void excluirToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}