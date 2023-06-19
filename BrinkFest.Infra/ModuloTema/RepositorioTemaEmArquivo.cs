using BrinkFest.Dominio.ModuloTema2;

namespace BrinkFest.Infra.Arquivo.ModuloTema2
{
    public class RepositorioTemaEmArquivo : RepositorioEmArquivoBase<Tema>, IRepositorioTema
    {
        public RepositorioTemaEmArquivo(ContextoDados contexto) : base(contexto)
        {

        }

        protected override List<Tema> ObterRegistros()
        {
            return contextoDados.tema2;
        }
    }
}
