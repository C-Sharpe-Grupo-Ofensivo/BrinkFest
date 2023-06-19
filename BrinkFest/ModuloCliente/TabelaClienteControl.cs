using BrinkFest.Dominio.ModuloCliente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrinkFest.WinApp.ModuloCliente
{
    public partial class TabelaClienteControl : UserControl
    {
        public TabelaClienteControl()
        {
            InitializeComponent();
            ConfigurarColunas();

            gridClientes.ConfigurarGridZebrado();

            gridClientes.ConfigurarGridSomenteLeitura();
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
                    Name = "nome",
                    HeaderText = "Nome"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "telefone",
                    HeaderText = "Telefone"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "endereço",
                    HeaderText = "Endereço"
                },

            };

            gridClientes.Columns.AddRange(colunas);
        }

        public void AtualizarRegistros(List<Cliente> clientes)
        {
            gridClientes.Rows.Clear();

            foreach (Cliente cliente in clientes)
            {
                gridClientes.Rows.Add(cliente.id, cliente.nome,  cliente.endereco, cliente.telefone);
            }
        }

        public int ObterIdSelecionado()
        {
            if (gridClientes.SelectedRows.Count == 0)
                return -1;

            int id = Convert.ToInt32(gridClientes.SelectedRows[0].Cells["id"].Value);

            return id; ;
        }
    }
}
