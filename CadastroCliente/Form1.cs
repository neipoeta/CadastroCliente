using CadastroCliente.DAO;
using CadastroCliente.Utils;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CadastroCliente
{
    public partial class Form1 : Form
    {
        private bool novoCliente;
        private bool novoEndereco;
        private int clienteIdAtual = -1;
        private int enderecoAtual = -1;

        public Form1()
        {
            InitializeComponent();
            //dataGridViewClientes.DataSource = ClienteDAO.CarregarClientes();
            dataGridViewClientes.DataSource = ClienteDAO.CarregarClientesComEndereco();

            //Event setado nas propriedades do design -> outra maneira de adicionar o event:
            //tabControlClientes.SelectedIndexChanged += TabControlClientes_SelectedIndexChanged;

            BloquearCamposEdicao(true);
            HabilitarCamposEndereco(false);
            buttonEnderecoConfirmarSalvar.Visible = false;

            //verificar se consigo setar nas proproedades dos forms
            textBoxAnoFundacaoCad.KeyPress += KeyPressNumbers.ApenasNumeros_KeyPress;
            maskedTextBoxRegistroCad.KeyPress += KeyPressNumbers.ApenasNumeros_KeyPress;
            maskedTextBoxTelefoneCad.KeyPress += KeyPressNumbers.ApenasNumeros_KeyPress;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.enderecosTableAdapter.Fill(this.dataSetCliente.enderecos);
            this.clientesTableAdapter.Fill(this.dataSetCliente.clientes);
        }

        #region EventsForms
        private void SalvarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (tabControlClientes.SelectedTab == tabPageClientes)
            {
                ButtonClienteNovo_Click(sender, e);
            }
            else if (tabControlClientes.SelectedTab == tabPageEnderecos)
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
            if (tabControlClientes.SelectedTab == tabPageClientes)
            {
                ButtonClienteExcluir_Click(sender, e);
            }
            else if (tabControlClientes.SelectedTab == tabPageEnderecos)
            {
                ButtonEnderecoExcluir_Click(sender, e);
            }
        }

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
            maskedTextBoxRegistroCad.Mask = "";
            maskedTextBoxTelefoneCad.Mask = "";
            if (!ValidacaoUtils.ValidarCamposClientes(
                textBoxNomeCad.Text,
                textBoxAnoFundacaoCad.Text,
                maskedTextBoxTelefoneCad.Text,
                maskedTextBoxRegistroCad.Text
                
            ))
            {
                return;
            }
            if (novoCliente)
            {
                ClienteDAO.IncluirCliente(
                    clienteIdAtual,
                    textBoxNomeCad.Text,
                    textBoxAnoFundacaoCad.Text,
                    maskedTextBoxTelefoneCad.Text,
                    maskedTextBoxRegistroCad.Text);

                dataGridViewClientes.DataSource = ClienteDAO.CarregarClientes();
                LimparCampos();
            }
            else
            {
                ClienteDAO.AtualizarCliente(
                    clienteIdAtual,
                    textBoxNomeCad.Text,
                    textBoxAnoFundacaoCad.Text,
                    maskedTextBoxTelefoneCad.Text,
                    maskedTextBoxRegistroCad.Text);

                dataGridViewClientes.DataSource = ClienteDAO.CarregarClientes();
            }

            if (!novoCliente)
            {
                BloquearCamposEdicao(true);
            }

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

            if (!novoEndereco)
            {
                EnderecoDAO.AtualizarEndereco(enderecoAtual,
                    textBoxEnderecoRua.Text,
                    textBoxEnderecoNumero.Text,
                    textBoxEnderecoBairro.Text,
                    textBoxEnderecoCidade.Text,
                    textBoxEnderecoUF.Text);
                dataGridViewEnderecos.DataSource = EnderecoDAO.CarregarEnderecos(clienteIdAtual);
            }
            else
            {
                EnderecoDAO.IncluirEndereco(clienteIdAtual,
                    textBoxEnderecoRua.Text,
                    textBoxEnderecoNumero.Text,
                    textBoxEnderecoBairro.Text,
                    textBoxEnderecoCidade.Text,
                    textBoxEnderecoUF.Text);
                dataGridViewEnderecos.DataSource = EnderecoDAO.CarregarEnderecos(clienteIdAtual);
            }

            BloquearCamposEdicao(true);
            LimparCampos();
            novoEndereco = false;
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
        }

        private void ButtonClienteEditar_Click(object sender, EventArgs e)
        {
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
                    ClienteDAO.ExcluirCliente(clienteIdAtual);
                    dataGridViewClientes.DataSource = ClienteDAO.CarregarClientes();
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
            if (dataGridViewEnderecos.SelectedCells.Count > 0)
            {
                foreach (DataGridViewRow rowEndereco in dataGridViewEnderecos.Rows)
                {
                    var idEndereco = rowEndereco.Cells[0].Value.ToString();

                    if (idEndereco == enderecoAtual.ToString())
                    {
                        {
                            PreencherCamposEndereco(rowEndereco);
                            HabilitarCamposEndereco(true);
                            buttonEnderecoConfirmarSalvar.Visible = true;
                        }
                    }
                }
            }
        }

        private void ButtonEnderecoExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridViewEnderecos.SelectedCells.Count > 0)
            {
                var result = MessageBox.Show("Você tem certeza que deseja excluir este endereco?", "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    EnderecoDAO.ExcluirEndereco(enderecoAtual);
                    dataGridViewEnderecos.DataSource = EnderecoDAO.CarregarEnderecos(clienteIdAtual);
                }
            }
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
                LimparCampos();
                BloquearCamposEdicao(true);
            }
            else if (tabControlClientes.SelectedTab == tabPageEnderecos)
            {
                if (clienteIdAtual != -1)
                {
                    dataGridViewEnderecos.DataSource = EnderecoDAO.CarregarEnderecos(clienteIdAtual);
                }
                else
                {
                    dataGridViewEnderecos.DataSource = EnderecoDAO.CarregarEnderecos(1);
                }
                if(dataGridViewEnderecos.Rows.Count > 0)
                {
                    DataGridViewRow row = this.dataGridViewEnderecos.Rows[0];
                    PreencherCamposEndereco(row);
                    enderecoAtual = Convert.ToInt32(row.Cells[0].Value);
                }
                if (!novoCliente)
                {
                    BloquearCamposEdicao(true);
                }
            }
        }

        private void dataGridViewClientes_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            HoverStyle.Hover(dataGridViewClientes, e.RowIndex, Color.LightCyan, Color.Black);
        }

        private void dataGridViewClientes_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            HoverStyle.Hover(dataGridViewClientes, e.RowIndex, Color.White, Color.Black);
        }

        private void dataGridViewEnderecos_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            HoverStyle.Hover(dataGridViewEnderecos, e.RowIndex, Color.LightCyan, Color.Black);
        }

        private void dataGridViewEnderecos_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            HoverStyle.Hover(dataGridViewEnderecos, e.RowIndex, Color.White, Color.Black);
        }
        #endregion

        #region Auxiliares
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
            textBoxAnoFundacaoCad.Text = row.Cells[2].Value.ToString();
            maskedTextBoxTelefoneCad.Text = row.Cells[3].Value.ToString();
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

        //private void NavegarParaEndereco(int clienteId)
        //{
        //    tabControlClientes.SelectedTab = tabPageEnderecos;
        //    LimparCampos();
        //    HabilitarCamposEndereco(true);
        //    buttonEnderecoConfirmarSalvar.Visible = true;
        //    dataGridViewEnderecos.DataSource = null;
        //    MessageBox.Show("Cliente incluído com sucesso! Cadastre o endereço.");
        //}
        #endregion
    }
}
