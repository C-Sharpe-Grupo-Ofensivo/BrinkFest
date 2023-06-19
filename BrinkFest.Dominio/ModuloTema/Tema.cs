using BrinkFest.Dominio.ModuloTema;

namespace BrinkFest.Dominio.ModuloTema2
{
    public class Tema : EntidadeBase<Tema>
    {
        public string tema;
        public List<Item> items;

        public Tema()
        {
        }

        public Tema(string tema)
        {
            this.tema = tema;
            this.items = new List<Item>();
        }

        public Tema(int id, string tema)
        {
            this.id = id;
            this.tema = tema;
            this.items = new List<Item>();
        }

        public override void AtualizarInformacoes(Tema registroAtualizado)
        {
            this.tema = registroAtualizado.tema;
        }

        public void AdicionarItem(Item item)
        {
            items.Add(item);
        }

        public override string[] Validar()
        {
            List<string> erros = new List<string>();
            if (string.IsNullOrEmpty(tema))
            {
                erros.Add("O Campo 'titulo' é obrigatório");

            }
            return erros.ToArray();
        }

        public void DesmarcarItem(Item item)
        {
            Item itemSelecionado = items.FirstOrDefault(x => x.Equals(item));

            itemSelecionado.Desmarcar();

            //CalcularPercentualConcluido();
        }

        //private void CalcularPercentualConcluido()
        //{
        //    decimal qtdItens = items.Count();

        //    if (qtdItens == 0)
        //        return;

        //    decimal qtdConcluidos = items.Count(x => x.concluido == true);

        //    decimal resultado = (qtdConcluidos / qtdItens) * 100;

        //    percentualConcluido = Math.Round(resultado, 2);
        //}

        public override string ToString()
        {
            return "Id: " + id + ", " + tema ;
        }
 
    }
}
