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

        private void pb1_Click(object sender, EventArgs e)
        {
            PesquisaEvento pq = new PesquisaEvento(dt1.Text);

            // Exibe a mensagem geral da pesquisa
            MessageBox.Show(pq.msg);

            if (pq.Resultados.Count > 0)
            {
                // Cria uma string para exibir os resultados
                string detalhes = "Os eventos encontrados correspondem a:\n\n";

                    foreach (var coluna in pq.Resultados) // Itera sobre cada par chave-valor do dicionário
                    {
                        detalhes += $"{coluna.Key}: {coluna.Value}\n"; // Adiciona os pares ao texto
                    }
                    detalhes += "\n"; // Adiciona uma linha em branco entre registros
                

                // Exibe os detalhes no MessageBox
                MessageBox.Show(detalhes,
                                "Detalhes do Evento",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Nenhum evento encontrado.",
                                "Sem Resultados",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }

            // Limpa o campo de texto
            dt1.Text = "";
        }
    }
}
