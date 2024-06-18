using System.Windows.Forms;

public static class ValidacaoUtils
{
    public static bool ValidarCamposClientes(string nome, string ano_fundacao, string registro, string telefone)
    {
        if (string.IsNullOrWhiteSpace(nome))
        {
            MessageBox.Show("O campo Nome é obrigatório.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        if (string.IsNullOrWhiteSpace(ano_fundacao))
        {
            MessageBox.Show("O campo Ano Fundação é obrigatório.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        if (string.IsNullOrWhiteSpace(registro))
        {
            MessageBox.Show("O campo Registro é obrigatório.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        if (string.IsNullOrWhiteSpace(telefone))
        {
            MessageBox.Show("O campo Telefone é obrigatório.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        return true;
    }

    public static bool ValidarCamposEnderecos(string rua, string numero, string cidade, string bairro, string uf)
    {
        if (string.IsNullOrWhiteSpace(rua))
        {
            MessageBox.Show("O campo Rua é obrigatório.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        if (string.IsNullOrWhiteSpace(numero))
        {
            MessageBox.Show("O campo Número é obrigatório.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        if (string.IsNullOrWhiteSpace(cidade))
        {
            MessageBox.Show("O campo Cidade é obrigatório.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        if (string.IsNullOrWhiteSpace(bairro))
        {
            MessageBox.Show("O campo Bairro é obrigatório.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        if (string.IsNullOrWhiteSpace(uf))
        {
            MessageBox.Show("O campo UF é obrigatório.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        return true;
    }
    
}
