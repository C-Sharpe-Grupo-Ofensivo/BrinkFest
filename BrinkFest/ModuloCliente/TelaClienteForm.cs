using BrinkFest.Dominio.ModuloCliente;

namespace BrinkFest.WinApp.ModuloCliente
{
    public partial class TelaClienteForm : Form
    {
        public TelaClienteForm()
        {
            InitializeComponent();
            this.ConfigurarDialog();
        }
        public Cliente ObterCliente()
        {
            int id = Convert.ToInt32(txtId.Text);

            string nome = txtNome.Text;

            string telefone = txtTelefone.Text;

            string endereco = txtEndereco.Text;

            Cliente cliente = new Cliente(nome, telefone, endereco);

            if (id > 0)
                cliente.id = id;

            return cliente;


        }

        public void ConfigurarTela(Cliente cliente)
        {
            txtId.Text = cliente.id.ToString();
            txtNome.Text = cliente.nome;
            txtTelefone.Text = cliente.telefone;
            txtEndereco.Text = cliente.endereco;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Cliente cliente = ObterCliente();

            string[] erros = cliente.Validar();

            if (erros.Length > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
            if (txtNome.Text == "")
            {
                MessageBox.Show("Campo Nome precisa ser preenchido");
            }
            if (txtEndereco.Text == "")
            {
                MessageBox.Show("Campo Endereço precisa ser preenchido");
            }
            if (txtTelefone.Text == "")
            {
                MessageBox.Show("Campo Telefone precisa ser preenchido");
            }
        }
    }
}
