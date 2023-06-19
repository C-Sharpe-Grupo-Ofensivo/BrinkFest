using BrinkFest.Dominio.ModuloTema2;
using System;
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
            ConfigurarColunas();

            gridTema.ConfigurarGridSomenteLeitura();

            gridTema.ConfigurarGridZebrado();

            
        }

        private void ConfigurarColunas()
        {
            DataGridViewTextBoxColumn id = new DataGridViewTextBoxColumn();
            id.Name = "Id";
            id.HeaderText = "ID";

            DataGridViewTextBoxColumn tema = new DataGridViewTextBoxColumn();
            tema.Name = "tema";
            tema.HeaderText = "Tema";

            //DataGridViewTextBoxColumn item = new DataGridViewTextBoxColumn();
            //item.Name = "item";
            //item.HeaderText = "Item";

            gridTema.Columns.Add(id);
            gridTema.Columns.Add(tema);
            //gridTema.Columns.Add(item);

        }
        public void AtualizarTema(List<Tema> temas)
        {
            gridTema.Rows.Clear();

            foreach (Tema tema in temas)
            {
                gridTema.Rows.Add(tema.id, tema.tema/*, tema.items */);
            }

        }
        public int ObterIdSelecionado()
        {
            if (gridTema.SelectedRows.Count == 0)
                return -1;

            int id = Convert.ToInt32(gridTema.SelectedRows[0].Cells["Id"].Value);

            return id;
        }

    }
}
