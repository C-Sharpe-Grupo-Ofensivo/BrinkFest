using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrinkFest.WinApp.ModuloTema2
{
    [Serializable]
    public class Item
    {
        public string item;
        public decimal valor;
        public Tema tema;
        public bool concluido;

        public Item () 
        {
            
        }

        public Item(string item, decimal valor)
        {
            this.item = item;
            this.valor = valor;
        }

        public Item(string item, Tema tema)
        {
            this.item = item;
          
        }

        public override string ToString()
        {
            return $"Item: {item}   Valor: R${valor}" ;
        }

        public override bool Equals(object? obj)
        {
            return obj is Item itens && 
                          item == itens.item &&
                          tema == itens.tema;
                
        }
        public void Desmarcar()
        {
            concluido = false;
        }
        public void Concluir()
        {
            concluido = true;
        }
    }
}
