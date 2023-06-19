using BrinkFest.Dominio.Compartilhado;
using BrinkFest.Dominio.ModuloCliente;
using BrinkFest.Dominio.ModuloTema2;




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrinkFest.Dominio.ModuloAluguel
{
    //Tela Cadastro Festa = Cliente, Tema, DataFesta, HoraInicio, HoraFinal, EndereçoDaFesta, ValorEntrada
  
        [Serializable]
    public  class Aluguel : EntidadeBase<Aluguel>
    {
       

        public DateTime data;

        public TimeSpan horarioInicio;

        public TimeSpan horarioFinal;

        public Cliente cliente;

        public Tema tema;

        public string local;


        public Aluguel()
        {

        }

        public Aluguel(int id, DateTime data, TimeSpan horarioInicio, TimeSpan horarioFinal,
            Cliente cliente, Tema tema, string local )
        {
            this.id = id;
        
            this.data = data;
            this.horarioInicio = horarioInicio;
            this.horarioFinal = horarioFinal;
            this.cliente = cliente;
            this.tema = tema;
            this.local = local;

        }

        public Aluguel(DateTime data, TimeSpan horarioInicio, TimeSpan horarioFinal,
            Cliente cliente, Tema tema, string local)
        {
            this.id = id;
       
            this.data = data;
            this.horarioInicio = horarioInicio;
            this.horarioFinal = horarioFinal;
            this.cliente = cliente;
            this.tema= tema;
            this.local = local;

        
        }

        public override string ToString()
        {
            return "Id: " + id + ", " + cliente + ", Tema" + tema + ", Data: " + data;
        }

        public override void AtualizarInformacoes(Aluguel registroAtualizado)
        {
         
            data = registroAtualizado.data;
            horarioInicio = registroAtualizado.horarioInicio;
            horarioFinal = registroAtualizado.horarioFinal;
            cliente = registroAtualizado.cliente;
            local = registroAtualizado.local;

        }

        public override string[] Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(cliente.nome))
                erros.Add("O campo 'cliente' é obrigatório");

            return erros.ToArray();
        }

        public override bool Equals(object? obj)
        {
            return obj is Aluguel compromisso &&
                   id == compromisso.id &&

                   data == compromisso.data &&
                   horarioInicio.Equals(compromisso.horarioInicio) &&
                   horarioFinal.Equals(compromisso.horarioFinal) &&
                   EqualityComparer<Cliente>.Default.Equals(cliente, compromisso.cliente) &&
                   local == compromisso.local; 
        
        }

    }
}
