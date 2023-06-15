﻿using BrinkFest.WinApp.ModuloCliente;
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
    public partial class TelaCadastroItemTemaForm : Form
    {
        private IRepositorioTema repositorioTema2;
        public TelaCadastroItemTemaForm(Tema temas2)
        {
            InitializeComponent();

            this.ConfigurarDialog();

            ConfigurarTela(temas2);

        }

        private void CarregarTemas(List<Tema> temas2)
        {
            foreach (Tema tema2 in temas2)
            {
                cmbTema.Items.Add(tema2);
            }
        }

        private void ConfigurarTela(Tema tema2)
        {

            cmbTema.Text = tema2.tema2;
            txtId.Text = tema2.id.ToString();
            txtNovoItem.Text = tema2.tema2;


            listItens.Items.AddRange(tema2.items.ToArray());


        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string novoItem = txtNovoItem.Text;
            decimal novoValor = Convert.ToDecimal(txtValor.Text);

            Item itemTema = new Item(novoItem, novoValor);
            

            listItens.Items.Add(itemTema);
   

        }

        public List<Item> ObterItensCadastrados()
        {
            return listItens.Items.Cast<Item>().ToList();
        }
    }
}