﻿using BrinkFest.WinApp.ModuloCliente;
using BrinkFest.WinApp.ModuloTema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrinkFest.WinApp.ModuloAluguel
{
    public class ControladorAluguel : ControladorBase
    {
        private IRepositorioCliente repositorioCliente;
        private IRepositorioAluguel repositorioAluguel;
        private IRepositorioTema repositorioTema;
        private TabelaAluguelControl tabelaAluguel;

        public ControladorAluguel(IRepositorioCliente repositorioCliente, IRepositorioAluguel repositorioAluguel, IRepositorioTema repositorioTema)
        {
            this.repositorioCliente = repositorioCliente;
            this.repositorioAluguel = repositorioAluguel;
            this.repositorioTema = repositorioTema;
           
        }

        public override string ToolTipInserir => "Inserir novo Compromisso";

        public override string ToolTipEditar => "Editar Compromisso existente";

        public override string ToolTipExcluir => "Excluir Compromisso existente";

        public override string ToolTipFiltrar => "Filtrar Compromissos";

        public override bool FiltrarHabilitado => true;

        public override void Inserir()
        {
            List<Cliente> clientes = repositorioCliente.SelecionarTodos();
            List<Tema> temas = repositorioTema.SelecionarTodos();
            TelaAluguelForm telaAluguel = new TelaAluguelForm(clientes, temas);

            DialogResult opcaoEscolhida = telaAluguel.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Aluguel aluguel = telaAluguel.ObterAluguel();

                repositorioAluguel.Inserir(aluguel);

            }
            CarregarAluguel();
        }

        public override void Editar()
        {
            Aluguel aluguelSelecionado = ObterAluguelSelecionado();

            if (aluguelSelecionado == null)
            {
                MessageBox.Show($"Selecione um aluguel primeiro!",
                   "Edição de Compromissos",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Exclamation);

                return;
            }

            List<Cliente> clientes = repositorioCliente.SelecionarTodos();
            List<Tema> temas = repositorioTema.SelecionarTodos();
            TelaAluguelForm telaAluguel = new TelaAluguelForm(clientes, temas);

            telaAluguel.ConfigurarTela(aluguelSelecionado);

            DialogResult opcaoEscolhida = telaAluguel.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Aluguel aluguel = telaAluguel.ObterAluguel();

                repositorioAluguel.Editar(aluguel.id, aluguel);

            }
            CarregarAluguel();
        }

        public override void Excluir()
        {
            Aluguel aluguelSelecionado = ObterAluguelSelecionado();

            if (aluguelSelecionado == null)
            {
                MessageBox.Show($"Selecione um aluguel primeiro!",
                   "Exclusão de Aluguel",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Exclamation);

                return;
            }

            DialogResult opcaoEscolhida =
                MessageBox.Show(
                    $"Deseja excluir o aluguel do {aluguelSelecionado.cliente.nome}?",
                    "Exclusão de Aluguel",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioAluguel.Excluir(aluguelSelecionado);

            }
            CarregarAluguel();
        }

        //public override void Filtrar()
        //{
        //    TelaFiltroCompromissoForm telaFiltro = new TelaFiltroCompromissoForm();
        //    DialogResult opcaoEscolhida = telaFiltro.ShowDialog();

        //    if (opcaoEscolhida == DialogResult.OK)
        //    {
        //        StatusCompromissoEnum status = telaFiltro.ObterStatus();
        //        List<Compromisso> compromissos = null;

        //        if (status == StatusCompromissoEnum.Todos)
        //        {
        //            compromissos = repositorioCompromisso.SelecionarTodos();
        //        }

        //        else if (status == StatusCompromissoEnum.Passados)
        //        {
        //            compromissos = repositorioCompromisso.SelecionarCompromissosPassados(DateTime.Now);
        //        }
        //        else if (status == StatusCompromissoEnum.Futuros)
        //        {
        //            DateTime dataInicio = telaFiltro.ObterDataInicio();
        //            DateTime dataFinal = telaFiltro.ObterDataFinal();

        //            compromissos = repositorioCompromisso.SelecionarCompromissosFuturos(dataInicio, dataFinal);
        //        }

        //        CarregarCompromissos(compromissos);

        //        TelaPrincipalForm.Instancia.AtualizarRodape($"Visualizando {compromissos.Count} compromissos");
        //    }
        //}

        public override UserControl ObterListagem()
        {
            if (tabelaAluguel == null)
            {
                tabelaAluguel = new TabelaAluguelControl();
            }

            CarregarAluguel();

            return tabelaAluguel;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Aluguel";
        }

        private void CarregarAluguel(List<Aluguel> aluguel)
        {
            tabelaAluguel.AtualizarRegistros(aluguel);
        }

        private Aluguel ObterAluguelSelecionado()
        {
            int id = tabelaAluguel.ObterIdSelecionado();

            return repositorioAluguel.SelecionarPorId(id);
        }

        private void CarregarAluguel()
        {
            List<Aluguel> aluguel = repositorioAluguel.SelecionarTodos();

            tabelaAluguel.AtualizarRegistros(aluguel);
        }
    }
}
