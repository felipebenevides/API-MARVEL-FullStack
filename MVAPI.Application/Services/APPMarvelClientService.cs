using AutoMapper;
using MVAPI.Application.Interfaces;
using MVAPI.Application.ViewModels;
using MVAPI.Contracts;
using MVAPI.Models;
using System.Collections.Generic;

namespace MVAPI.Application.Services
{
    public class APPMarvelClientService : IAPPMarvelClient
    {
        private readonly IAPIMarvelClient _AppServiceMarvel;
        private readonly IMapper _mapper;

        public APPMarvelClientService(IAPIMarvelClient AppServiceMarvel,IMapper mapper)
        {
            _AppServiceMarvel = AppServiceMarvel;
            _mapper = mapper;
        }

        public ResultViewModel RetornaPersonagensMarvel()
        {
            var model = _mapper.Map<ResultViewModel>(_AppServiceMarvel.ObterDadosPersonagem());

            return model;
        }

        public DataViewModel ListaPersonagens()
        {
            var model = _mapper.Map<DataViewModel>(_AppServiceMarvel.ListaPersonagens());

            return model;

        }

        public ResultViewModel BuscaPersonagemPorID(int id)
        {
            var model = _mapper.Map<ResultViewModel>(_AppServiceMarvel.BuscarPersonagemPorID(id));

            return model;
        }

        public DataViewModel ListaQuadrinhos()
        {
            var model = _mapper.Map<DataViewModel>(_AppServiceMarvel.ListaQuadrinhos());

            return model;
        }

    }
}
