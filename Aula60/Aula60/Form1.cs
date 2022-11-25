namespace Aula60
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            listaPrimaria.Text += tb_veiculo.Text + ", ";
            tb_veiculo.Clear();
            tb_veiculo.Focus();
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            tb_veiculo.Clear();
            tb_veiculo.Focus();
        }

        private void btn_listaVeiculos_Click(object sender, EventArgs e)
        {
            TelaSecundaria telaSecundaria = new TelaSecundaria(listaPrimaria.Text);
            telaSecundaria.Show();
        }
    }
}