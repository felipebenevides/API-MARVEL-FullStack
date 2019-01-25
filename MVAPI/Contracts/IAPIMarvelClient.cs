using Microsoft.Extensions.Configuration;
using MVAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace MVAPI.Contracts
{
    public interface IAPIMarvelClient
    {
        Result ObterDadosPersonagem();
        Data ListaPersonagens();
        Result BuscarPersonagemPorID(int id);
        Data ListaQuadrinhos();
    }
}
