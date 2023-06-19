
using BrinkFest.Dominio.ModuloAluguel;

namespace BrinkFest.Infra.Arquivo.ModuloAluguel
{
    public class RepositorioAluguelEmArquivo : RepositorioEmArquivoBase<Aluguel>, IRepositorioAluguel
    {
        public RepositorioAluguelEmArquivo(ContextoDados contexto) : base(contexto)
        {
        }

        public List<Aluguel> SelecionarAluguelPassados(DateTime hoje)
        {
            return ObterRegistros().Where(x => x.data.Date < hoje.Date).ToList();
        }

        public List<Aluguel> SelecionarAluguelFuturos(DateTime dataInicio, DateTime dataFinal)
        {
            return ObterRegistros()
                .Where(x => x.data > dataInicio)
                .Where(x => x.data < dataFinal)
                .ToList();
        }

        protected override List<Aluguel> ObterRegistros()
        {
            return contextoDados.aluguel;
        }
    }
}
