using AutoMapper;

namespace WebApi.Mapper;

public class MapProfile : Profile
{
	public MapProfile()
	{
		CreateMap<Models.Category, DTO.CategoryDTO>().ReverseMap();
		
	}
}
