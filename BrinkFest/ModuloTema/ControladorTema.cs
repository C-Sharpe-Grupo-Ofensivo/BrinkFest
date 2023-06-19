
using BrinkFest.Dominio.ModuloTema;
using BrinkFest.Dominio.ModuloTema2;

namespace BrinkFest.WinApp.ModuloTema2
{
    public class ControladorTema : ControladorBase
    {
        private IRepositorioTema repositorioTema;
        private TabelaTemaControl tabelaTema2;

        public ControladorTema(IRepositorioTema repositorioTema)
        {
            this.repositorioTema = repositorioTema;
        }

        #region tooltips
        public override string ToolTipInserir => "Inserir nova Tema";

        public override string ToolTipEditar => "Editar Tema existente";

        public override string ToolTipExcluir => "Excluir Tema existente";

        public override string ToolTipFiltrar => "Filtrar Tema";

        public override string ToolTipAdicionarItens => "Adicionar Itens na Tema";

        public override string ToolTipConcluirItens => "Concluir Itens da Tema";

        #endregion

        public override bool FiltrarHabilitado => true;

        public override bool AdicionarItensHabilitado => true;

        public override bool ConcluirItensHabilitado => true;

        public override void Inserir()
        {
            
            List<Tema> temas = repositorioTema.SelecionarTodos();
            TelaTemaForm telaTema = new TelaTemaForm(temas);


            DialogResult opcaoEscolhida = telaTema.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Tema novaTema = telaTema.ObterTema();

                repositorioTema.Inserir(novaTema);

            }
            CarregarTemas();
        }

        public override void Editar()
        {
            Tema temaSelecionado = ObterTemaSelecionada();

            if (temaSelecionado == null)
            {
                MessageBox.Show("Selecione uma tema primeiro", "Edição de Tema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }

            List<Tema> temas = repositorioTema.SelecionarTodos();
            TelaTemaForm telaTema = new TelaTemaForm(temas);

            telaTema.ConfigurarTela(temaSelecionado);

            DialogResult opcaoEscolhida = telaTema.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Tema tema = telaTema.ObterTema();

                repositorioTema.Editar(tema.id, tema);

            }
            CarregarTemas();
        }

        public override void Excluir()
        {
            Tema temaSelecionado = ObterTemaSelecionada();

            if (temaSelecionado == null)
            {
                MessageBox.Show("Selecione uma tema primeiro", "Exclusão de Tema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir a tema {temaSelecionado.tema}?",
                "Exclusão de Tema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioTema.Excluir(temaSelecionado);

                CarregarTemas();
            }
        }

        public override void Adicionar()
        {
            Tema temaSelecionado = ObterTemaSelecionada();
            //List<Tema> temas = repositorioTema.SelecionarTodos();
 
            if (temaSelecionado == null)
            {
                MessageBox.Show("Selecione uma tema primeiro", "Adição de Itens da tema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }

            TelaCadastroItemTemaForm telaCadastroItemTema = new TelaCadastroItemTemaForm(temaSelecionado);

            DialogResult opcaoEscolhida = telaCadastroItemTema.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                List<Item> itensParaAdicionar = telaCadastroItemTema.ObterItensCadastrados();

                foreach (Item item in itensParaAdicionar)
                {
                    temaSelecionado.AdicionarItem(item);
                }

                repositorioTema.Editar(temaSelecionado.id, temaSelecionado);
                CarregarTemas();
            }
        }


        public override UserControl ObterListagem()
        {
            if (tabelaTema2 == null)
                tabelaTema2 = new TabelaTemaControl();

            CarregarTemas();

            return tabelaTema2;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Temas";
        }

        private Tema ObterTemaSelecionada()
        {
            int id = tabelaTema2.ObterIdSelecionado();

            return repositorioTema.SelecionarPorId(id);
        }

        private void CarregarTemas()
        {
            List<Tema> tema = repositorioTema.SelecionarTodos();
            tabelaTema2.AtualizarTema(tema);

            TelaPrincipalForm.Instancia.AtualizarRodape($"Visualizando {tema.Count} tema(s)");
        }


    }
}
