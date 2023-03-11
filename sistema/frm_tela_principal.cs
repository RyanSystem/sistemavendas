namespace sistema
{
    public partial class frm_tela_principal : Form
    {
        public frm_tela_principal()
        {
            InitializeComponent();
        }

        private void btn_cad_pro_Click(object sender, EventArgs e)
        {
            frm_cad_pro frm = new frm_cad_pro();
            frm.Show();
        }

        private void btn_cap_cli_Click(object sender, EventArgs e)
        {
            frm_cad_cli frm = new frm_cad_cli();
            frm.Show();
        }

        private void novoProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_cad_pro frm = new frm_cad_pro();
            frm.Show();
        }

        private void novoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_cad_cli frm = new frm_cad_cli();
            frm.Show();
        }

        private void novaCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_categoria frm = new frm_categoria();
            frm.Show();
        }
    }
}