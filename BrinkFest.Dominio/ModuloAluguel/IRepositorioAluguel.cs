using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrinkFest.Dominio.ModuloAluguel
{
    public interface IRepositorioAluguel
    {
        void Inserir(Aluguel aluguel);
        void Editar(int id, Aluguel aluguel);
        void Excluir(Aluguel aluguelSelecionado);
        List<Aluguel>? SelecionarAluguelFuturos(DateTime dataInicio, DateTime dataFinal);
        List<Aluguel>? SelecionarAluguelPassados(DateTime now);
        List<Aluguel>? SelecionarTodos();
        Aluguel SelecionarPorId(int id);
    }
}
