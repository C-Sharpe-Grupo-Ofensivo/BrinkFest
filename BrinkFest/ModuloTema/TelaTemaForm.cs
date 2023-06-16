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
    public partial class TelaTemaForm : Form
    {
        public TelaTemaForm(List<Tema> temas)
        {
            InitializeComponent();

            this.ConfigurarDialog();
        }
        public Tema ObterTema()
        {
            int id = Convert.ToInt32(txtId.Text);

            string tema = txtTema2.Text;

            return new Tema(id, tema);
        }
        public void ConfigurarTela(Tema tema)
        {
            txtId.Text = tema.id.ToString();

            txtTema2.Text = tema.tema;
        }
        private void btnGravar_Click(object sender, EventArgs e)
        {
            Tema tema = ObterTema();

            string[] erros = tema.Validar();

            if (erros.Count() > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
        }
    }
}
