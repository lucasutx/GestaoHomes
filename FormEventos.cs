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
    public partial class FormEventos : Form
    {
        public FormEventos()
        {
            InitializeComponent();
        }

        private void bntCadastrar_Click(object sender, EventArgs e)
        {
            String nome = txtNome.Text;
            String endereco = txtEndereco.Text;
            String preco = txtPreco.Text;
            Cadastrar cadastrar = new Cadastrar(nome, endereco, preco);
            MessageBox.Show(cadastrar.msg);

            nome = "";
            endereco = "";
            preco = "";
        }
    }
}
