using BLL;
namespace ListaDeTelefone
{
    public partial class frmListaDeTelefone : Form
    {
        //Declarando o "Banco de dados"
        public Repositorio Repositorio { get; set; } = new Repositorio();
        public frmListaDeTelefone()
        {
            InitializeComponent();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            Telefone telefone = new Telefone();

            telefone.Nome = txtNome.Text;
            telefone.Numero = txtTelefone.Text;

            Repositorio.Incluir(telefone);
            MessageBox.Show("Telefone Incluido com sucesso");

            lblListaDeTelefone.Visible = true;
            btnListar.Visible = true;
            txtNome.Text = "";
            txtTelefone.Text = "";

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            listTelefone.Visible = true;
            listTelefone.Items.Clear();
            foreach (var tel in Repositorio.Telefones)
            {
                listTelefone.Items.Add(tel);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}