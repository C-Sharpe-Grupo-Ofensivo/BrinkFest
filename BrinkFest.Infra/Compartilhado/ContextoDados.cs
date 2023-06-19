using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading.Tasks;
using BrinkFest.Dominio.ModuloCliente;

using BrinkFest.Dominio.ModuloAluguel;
using BrinkFest.Dominio.ModuloTema2;

namespace BrinkFest.Infra.Arquivo.Compartilhado
{
    public class ContextoDados //container
    {
        private const string NOME_ARQUIVO = "BrinkFest.json";

        public List<Cliente> clientes;

        public List<Aluguel> aluguel;
        public List<Tema> tema2; 

     

        public ContextoDados()
        {
            clientes = new List<Cliente>();
  
            aluguel = new List<Aluguel>();
            tema2 = new List<Tema>();
      
        }

        public ContextoDados(bool carregarDados) : this()
        {
            if (carregarDados)
                CarregarDoArquivoJson();
        }

        public void GravarEmArquivoJson()
        {
            JsonSerializerOptions config = ObterConfiguracoes();

            string registrosJson = JsonSerializer.Serialize(this, config);

            File.WriteAllText(NOME_ARQUIVO, registrosJson);
        }

        private void CarregarDoArquivoJson()
        {
            JsonSerializerOptions config = ObterConfiguracoes();

            if (File.Exists(NOME_ARQUIVO))
            {
                string registrosJson = File.ReadAllText(NOME_ARQUIVO);

                if (registrosJson.Length > 0)
                {
                    ContextoDados ctx = JsonSerializer.Deserialize<ContextoDados>(registrosJson, config);

                    this.clientes = ctx.clientes;
 
                    this.aluguel = ctx.aluguel;
                    this.tema2 = ctx.tema2; 
                  
                }
            }
        }

        private static JsonSerializerOptions ObterConfiguracoes()
        {
            JsonSerializerOptions opcoes = new JsonSerializerOptions();
            opcoes.IncludeFields = true;
            opcoes.WriteIndented = true;
            opcoes.ReferenceHandler = ReferenceHandler.Preserve;

            return opcoes;
        }
    }
}
