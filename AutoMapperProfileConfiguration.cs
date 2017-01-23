using AutoMapper;
using AutoMapperDI.Models;
using AutoMapperDI.ViewModels;

namespace AutoMapperDI
{
    public class AutoMapperProfileConfiguration : Profile
    {
        protected override void Configure()
        {
            CreateMap<Blob, BlobViewModel>().ReverseMap();
        }
    }
}