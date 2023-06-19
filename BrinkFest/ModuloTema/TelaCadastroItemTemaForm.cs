using BrinkFest.Dominio.ModuloCliente;
using BrinkFest.Dominio.ModuloTema;
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
    public partial class TelaCadastroItemTemaForm : Form
    {
        private IRepositorioTema repositorioTema2;
        private Tema temaSelecionado;
        private List<Tema> temas;

        public TelaCadastroItemTemaForm(Tema tema)
        {
            InitializeComponent();

            this.ConfigurarDialog();

            ConfigurarTela(tema);


        }


        //private void CarregarTemas(List<Tema> temas2)
        //{
        //    foreach (Tema tema in temas2)
        //    {
        //        cmbTema.Items.Add(tema);
        //    }
        //}

        //public Tema ObterTema()
        //{
        //    cmbTema.Text = tema;
        //}

        public List<Item> ObterTema()
        {
            return listItens.Items.Cast<Item>().ToList();
        }

        private void ConfigurarTela(Tema tema)
        {

            txtTema.Text = tema.tema;
            txtId.Text = tema.id.ToString();
            txtNovoItem.Text = tema.tema;

            foreach (Item item in tema.items)
            {
                listItens.Items.Add(item);
            }
            //listItens.Items.AddRange(tema.items.ToArray());


        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
          
            
                string novoItem = txtNovoItem.Text;
                decimal novoValor = Convert.ToDecimal(txtValor.Text);

                Item itemTema = new Item(novoItem, novoValor);
                
                if(txtNovoItem.Text == "")
                {
                MessageBox.Show("Campo item precisa ser preenchido");
                }
                else if(listItens.Items.Count == 0)
                {
                    listItens.Items.Add(itemTema);
                }
                else 
                {
                MessageBox.Show("Lista já preenchida");        
                }
            
       
            


        }

        public List<Item> ObterItensCadastrados()
        {
            return listItens.Items.Cast<Item>().ToList();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if(listItens.SelectedIndex != -1)
            {
                listItens.Items.RemoveAt(listItens.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Selecione um elemento!");
            }
            
        }
    }
}
