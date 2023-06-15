﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrinkFest.WinApp.ModuloTema2
{
    public partial class TabelaTemaControl : UserControl
    {
        public TabelaTemaControl()
        {
            InitializeComponent();

            gridTema2.ConfigurarGridSomenteLeitura();
            gridTema2.ConfigurarGridZebrado();

            ConfigurarColunas();
        }

        private void ConfigurarColunas()
        {
            DataGridViewTextBoxColumn id = new DataGridViewTextBoxColumn();
            id.Name = "Id";
            id.HeaderText = "ID";

            DataGridViewTextBoxColumn tema2 = new DataGridViewTextBoxColumn();
            tema2.Name = "tema";
            tema2.HeaderText = "Tema";

            DataGridViewTextBoxColumn item = new DataGridViewTextBoxColumn();
            item.Name = "item";
            item.HeaderText = "Item";

            gridTema2.Columns.Add(id);
            gridTema2.Columns.Add(tema2);
            gridTema2.Columns.Add(item);

        }
        public void AtualizarTema2(List<Tema> temas2)
        {
            gridTema2.Rows.Clear();

            foreach (Tema tema2 in temas2)
            {
                gridTema2.Rows.Add(tema2.id, tema2.tema2, tema2.items);
            }

        }
        public int ObterIdSelecionado()
        {
            if (gridTema2.SelectedRows.Count == 0)
                return -1;

            int id = Convert.ToInt32(gridTema2.SelectedRows[0].Cells["Id"].Value);

            return id;
        }

    }
}