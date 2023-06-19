using BrinkFest.Dominio.ModuloTema2;
using BrinkFest.Infra.Arquivo.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
