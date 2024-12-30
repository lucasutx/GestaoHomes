using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homes2
{
    public partial class FormValorLiquido : Form
    {
        public FormValorLiquido()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            LucroPorPeriodo lp = new LucroPorPeriodo(dtInicio.Text, dtFim.Text);
            dtInicio.Text = "";
            dtFim.Text = "";


            MessageBox.Show(
                string.Format(
                    "O Valor Líquido entre os dias {0} e {1}:\nR${2}",
                    DateTime.Parse(dtInicio.Text).ToString("dd/MM/yyyy", CultureInfo.InvariantCulture),
                    DateTime.Parse(dtFim.Text).ToString("dd/MM/yyyy", CultureInfo.InvariantCulture),
                    lp.valorLiquido.ToString("F2", CultureInfo.InvariantCulture)
                ),
                "Valor Total",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );

            ;
        }
    }
}
