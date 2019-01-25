using AutoMapper;
using MVAPI.Application.ViewModels;
using MVAPI.Models;

namespace MVAPI.Application.AutoMapper
{
    public class ViewModelToModelMappingProfile : Profile
    {
        public ViewModelToModelMappingProfile()
        {
            CreateMap<ResultViewModel, Result>();
            CreateMap<DataViewModel, Data>();
        }
    }
}