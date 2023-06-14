﻿using BrinkFest.WinApp.ModuloCliente;
using BrinkFest.WinApp.ModuloTema;
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
    public partial class TelaAluguelForm : Form
    {
        public TelaAluguelForm(List<Cliente> clientes, List<Tema> temas)
        {
            InitializeComponent();
            this.ConfigurarDialog();

            CarregarClientes(clientes);
            CarregarTemas(temas);
        }

        private void CarregarClientes(List<Cliente> clientes)
        {
            foreach (Cliente cliente in clientes)
            {
                cmbCliente.Items.Add(cliente);
            }
        }

        private void CarregarTemas(List<Tema> temas)
        {
            foreach (Tema tema in temas)
            {
                cmbTemas.Items.Add(tema);
            }
        }

        public Aluguel ObterAluguel()
        {
            int id = Convert.ToInt32(txtId.Text);


            DateTime data = txtData.Value;

            TimeSpan horarioInicio = txtHorarioInicio.Value.TimeOfDay;
            TimeSpan horarioFinal = txtHorarioFinal.Value.TimeOfDay;


            string local = txtEndereco.Text;

            Cliente cliente = (Cliente)cmbCliente.SelectedItem;
            Tema tema = (Tema)cmbTemas.SelectedItem;

            Aluguel aluguel = new Aluguel(id, data, horarioInicio, horarioFinal, cliente, tema, local);

            if (id > 0)
                aluguel.id = id;

            return aluguel;
        }

        public void ConfigurarTela(Aluguel aluguelSelecionado)
        {
            txtId.Text = aluguelSelecionado.id.ToString();

            txtData.Value = aluguelSelecionado.data;
            txtHorarioInicio.Value = DateTime.Now.Date.Add(aluguelSelecionado.horarioInicio);
            txtHorarioFinal.Value = DateTime.Now.Date.Add(aluguelSelecionado.horarioFinal);

            if (aluguelSelecionado.tema != null)
            {
                chkSelecionarTema.Checked = true;
                cmbTemas.SelectedItem = aluguelSelecionado.tema;
            }

            if (aluguelSelecionado.cliente != null)
            {
                cmbCliente.SelectedIndex = 0;
                cmbCliente.SelectedItem = aluguelSelecionado.cliente;
            }



        }




        private void btnGravar_Click_1(object sender, EventArgs e)
        {
            Aluguel aluguel = ObterAluguel();

            string[] erros = aluguel.Validar();

            if (erros.Length > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
        }

        private void chkSelecionarTema_CheckedChanged(object sender, EventArgs e)
        {
            cmbTemas.Enabled = !cmbTemas.Enabled;
            cmbTemas.SelectedIndex = -1;
        }
    }
}
