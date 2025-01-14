using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homes2
{
    public partial class Agendamentos : Form
    {
        public Agendamentos()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show(
                "Tem certeza que gostaria de cadastrar esse evento?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );

            if (resposta == DialogResult.Yes)
            {
                CadastroAgenda ag = new CadastroAgenda(txtNome.Text, data.Text, txtTelefone.Text, txtEndereco.Text, cbStatus.Text, txtValor.Text);
                MessageBox.Show(ag.msg);
                txtNome.Text = "";
                data.Text = "";
                txtTelefone.Text = "";
                txtEndereco.Text = "";
                cbStatus.Text = "";
            }
            else
            {
                txtNome.Text = "";
                data.Text = "";
                txtTelefone.Text = "";
                txtEndereco.Text = "";
                cbStatus.Text = "";
                txtValor.Text = "";
            }

        }

        private void txtTelefone_TextChanged(object sender, EventArgs e)
        {
            txtTelefone.TextChanged -= txtTelefone_TextChanged; // Evita loop recursivo

            string texto = txtTelefone.Text.Replace(" ", ""); // Remove espaços
            if (texto.Length > 10) // Verifica se tem tamanho suficiente
            {
                // Formata como '(XX) XXXXX-XXXX'
                string telefoneFormatado = $"({texto.Substring(0, 2)}) {texto.Substring(2, 5)}) {texto.Substring(7)}";
                txtTelefone.Text = telefoneFormatado;
            }

            txtTelefone.SelectionStart = txtTelefone.Text.Length; // Mantém o cursor no final
            txtTelefone.TextChanged += txtTelefone_TextChanged; // Reassocia o evento
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            txtValor.TextChanged -= txtValor_TextChanged; // Evita loop recursivo

            try
            {
                if (decimal.TryParse(txtValor.Text, out decimal valor))
                {
                    if (valor <= 0)
                    {
                        MessageBox.Show("Valor do Evento não pode ser zero ou negativo");
                    }
                }
                else if (!string.IsNullOrEmpty(txtValor.Text))
                {
                    MessageBox.Show("Insira um valor numérico válido.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro: {ex.Message}");
            }
            finally
            {
                // Restaurar o cursor no final do texto
                txtValor.SelectionStart = txtValor.Text.Length;
                txtValor.TextChanged += txtValor_TextChanged;
            }
        }

    }
}
