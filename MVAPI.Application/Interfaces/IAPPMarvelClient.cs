using MVAPI.Application.ViewModels;
using MVAPI.Models;
using System.Collections.Generic;

namespace MVAPI.Application.Interfaces
{
    public interface IAPPMarvelClient
    {
        ResultViewModel RetornaPersonagensMarvel();

        DataViewModel ListaPersonagens();

        ResultViewModel BuscaPersonagemPorID(int id);

        DataViewModel ListaQuadrinhos();

    }
}
