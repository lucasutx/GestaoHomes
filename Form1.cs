namespace Homes2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEvento_Click(object sender, EventArgs e)
        {
            FormEventos formEventos = new FormEventos();
            formEventos.Show();
        }

        private void btnDespesa_Click(object sender, EventArgs e)
        {
            FormDespesas formDespesas = new FormDespesas();
            formDespesas.Show();
        }

        private void btnValorLq_Click(object sender, EventArgs e)
        {
            FormValorLiquido formValorLiquido = new FormValorLiquido();
            formValorLiquido.Show();
        }

        private void btnAgendamentos_Click(object sender, EventArgs e)
        {
            Agendamentos formAgendamentos = new Agendamentos();
            formAgendamentos.Show();
        }
    }
}
