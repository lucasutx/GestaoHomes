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
                CadastroAgenda ag = new CadastroAgenda(txtNome.Text, data.Text, txtTelefone.Text, txtEndereco.Text, cbStatus.Text);
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
            }
            
        }
    }
}
