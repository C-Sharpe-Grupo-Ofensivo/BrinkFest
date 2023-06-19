using BrinkFest.Dominio.ModuloAluguel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrinkFest.WinApp.ModuloAluguel
{
    public partial class TabelaAluguelControl : UserControl
    {
        public TabelaAluguelControl()
        {
            InitializeComponent();

            ConfigurarColunas();

            gridAluguel.ConfigurarGridZebrado();

            gridAluguel.ConfigurarGridSomenteLeitura();
        }
        private void ConfigurarColunas()
        {
            DataGridViewColumn[] colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn()
                {
                    Name = "id",
                    HeaderText = "Id"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "cliente.nome",
                    HeaderText = "Cliente"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "data",
                    HeaderText = "Data"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "horarioInicio",
                    HeaderText = "Horário Início"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "tema.titulo",
                    HeaderText = "Tema"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "local",
                    HeaderText = "Local"
                }
            };

            gridAluguel.Columns.AddRange(colunas);
        }

        public void AtualizarRegistros(List<Aluguel> aluguels)
        {
            gridAluguel.Rows.Clear();

            foreach (Aluguel aluguel in aluguels)
            {
                gridAluguel.Rows.Add(aluguel.id, aluguel.cliente?.nome, aluguel.data, aluguel.horarioInicio, aluguel.tema.tema, aluguel.local);
            }
        }

        public int ObterIdSelecionado()
        {
            if (gridAluguel.SelectedRows.Count == 0)
                return -1;

            int id = Convert.ToInt32(gridAluguel.SelectedRows[0].Cells["id"].Value);

            return id;
        }
    }
}
