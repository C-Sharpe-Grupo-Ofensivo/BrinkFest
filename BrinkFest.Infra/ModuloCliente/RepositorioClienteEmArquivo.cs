using BrinkFest.Dominio.ModuloCliente;

namespace BrinkFest.Infra.Arquivo.ModuloCliente
{
    public class RepositorioClienteEmArquivo : RepositorioEmArquivoBase<Cliente>, IRepositorioCliente
    {
        public RepositorioClienteEmArquivo(ContextoDados contexto) : base(contexto)
        {

        }


        protected override List<Cliente> ObterRegistros()
        {
            return contextoDados.clientes;
        }
    }
}
