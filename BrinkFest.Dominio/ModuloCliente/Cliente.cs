namespace BrinkFest.Dominio.ModuloCliente
{
    [Serializable]
    public class Cliente : EntidadeBase<Cliente> 
    {
        public string nome { get; set; }
        public string endereco;
        public string telefone;

        public Cliente()
        {

        }
        public Cliente(string nome, string endereco, string telefone)
        {
            this.nome = nome;
            this.endereco = endereco;
            this.telefone = telefone;
        }

        public override void AtualizarInformacoes(Cliente registroAtualizado)
        {
            this.nome = registroAtualizado.nome;
            this.endereco = registroAtualizado.endereco;
            this.telefone = registroAtualizado.telefone;
        }
        public override string ToString()
        {
            return "Id: " + id + ", " + nome + ", Endereço: " + endereco;
        }
        public override string[] Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(nome))
                erros.Add("O campo 'nome' é obrigatório");

            if (string.IsNullOrEmpty(telefone))
                erros.Add("O campo 'telefone' é obrigatório");

            if (string.IsNullOrEmpty(endereco))
                erros.Add("O campo 'endereço' é obrigátório");

            return erros.ToArray();

        }
        public override bool Equals(object? obj)
        {
            return obj is Cliente cliente &&
                    id == cliente.id &&
                    nome == cliente.nome &&
                    telefone == cliente.telefone &&
                    endereco == cliente.endereco;

        }
    }
}
