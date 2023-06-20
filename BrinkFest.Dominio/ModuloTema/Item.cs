using BrinkFest.Dominio.ModuloTema2;

namespace BrinkFest.Dominio.ModuloTema
{
    [Serializable]
    public class Item : EntidadeBase<Item>
    {
        public string item;
        public decimal valor;
        public Tema tema;
        public bool concluido;

        public Item()
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

        public override void AtualizarInformacoes(Item registroAtualizado)
        {
            throw new NotImplementedException();
        }

        public override string[] Validar()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"Item: {item}   Valor: R${valor}";
        }
    }
}
