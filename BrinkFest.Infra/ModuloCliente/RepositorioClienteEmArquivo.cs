using BrinkFest.Dominio.ModuloCliente;
using BrinkFest.Infra.Arquivo.Compartilhado;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
