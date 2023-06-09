//---Context---//
using DocumentStorage.Data.Models;
//---Models---//
using DocumentStorage.Controllers.Models;
//---Packages---//
using AutoMapper;

namespace DocumentStorage.Services
{
	public static class AutoMapperServiceExtesions
	{
		public static Author AutoMapService<T>(this T source) =>
			AutoMapperBase.getModelMapping().CreateMapper().Map<T, Author>(source);
	}
	public static class AutoMapperBase
	{
		public static MapperConfiguration getModelMapping() =>
			new MapperConfiguration(cfg =>
			{
				cfg.CreateMap<AuthorModel, Author>()
				   .ForMember(prop => prop.Achievements, mc => mc.Ignore())
				   .ForMember(prop => prop.AuthorId, mc => mc.Ignore());
			});
	}
}
