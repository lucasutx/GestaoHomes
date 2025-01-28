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
    public enum CategoriaDespesa
    {
        salarios,
        gas,
        material,
        gasolina,
        luz,
        agua,
        uber
    }
    public partial class FormDespesas : Form
    {
        public FormDespesas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadastroDespesa cd = new CadastroDespesa(cbCategoria.Text, txtValor.Text,dtDespesa.Text);
            MessageBox.Show(cd.msg);
            cbCategoria.Text = "";
            txtValor.Text = "";
            
        }
    }
}
