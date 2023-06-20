using BrinkFest.Dominio.ModuloTema;

namespace BrinkFest.Dominio.ModuloTema2
{

    public interface IRepositorioTema


    {
        void Inserir(Tema novoTema2);

        void Editar(int id, Tema tema2);

        void Excluir(Tema tema2Selecionado);

        List<Tema> SelecionarTodos();
      

        Tema SelecionarPorId(int id);
    }
}
