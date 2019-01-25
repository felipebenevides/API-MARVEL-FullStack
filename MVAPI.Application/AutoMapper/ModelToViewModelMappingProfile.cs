using AutoMapper;
using MVAPI.Application.ViewModels;
using MVAPI.Models;

namespace MVAPI.Application.AutoMapper
{
    public class ModelToViewModelMappingProfile : Profile
    {
        public ModelToViewModelMappingProfile()
        {
            CreateMap<Result, ResultViewModel>();
            CreateMap<Data, DataViewModel>();
        }
    }
}