using panorama;

namespace costura
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            cadastrar cadastrar = new cadastrar();
            cadastrar.Show();

            this.Hide();
        }

        private void btn_pedido_Click(object sender, EventArgs e)
        {
            pedido pedido = new pedido();
            pedido.Show();

            this.Hide();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadastrar cadastrar = new cadastrar();
            cadastrar.Show();

            this.Hide();
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            pedido pedido = new pedido();
            pedido.Show();

            this.Hide();
        }

        private void historicoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void hist�ricoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            historico Historico = new historico();
            Historico.Show();

            this.Hide();
        }

        private void home_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

        }
    }
}
