﻿//---Context---//
//---Packages---//
using AutoMapper;
using DocumentStorage.Data.Models;
//---Models---//
using DocumentStorage.Models;

namespace DocumentStorage.Services
{
	public class AutoMapperService
	{
		public static MapperConfiguration GetModelsMapping() => AutoMapperBase.getModelMapping();
	}
	public static class AutoMapperServiceExtesions
	{
		public static Author AutoMapService(this AuthorModel source) =>
			AutoMapperBase.getModelMapping().CreateMapper().Map<AuthorModel, Author>(source);

		public static Achievement AutoMapService(this AchievementModel source) =>
			AutoMapperBase.getModelMapping().CreateMapper().Map<AchievementModel, Achievement>(source);

		public static AchievementModel AutoMapService(this Achievement source) =>
			AutoMapperBase.getModelMapping().CreateMapper().Map<Achievement, AchievementModel>(source);

		//public static Author AutoMapService<T>(this T source) =>
		//	AutoMapperBase.getModelMapping().CreateMapper().Map<T, Achievement>(source);
	}
	public static class AutoMapperBase
	{
		public static MapperConfiguration getModelMapping() =>
			new MapperConfiguration(cfg =>
			{
				cfg.CreateMap<AuthorModel, Author>()
				   .ForMember(prop => prop.Achievements, mc => mc.Ignore())
				   .ForMember(prop => prop.AuthorId, mc => mc.Ignore());

				cfg.CreateMap<AchievementModel, Achievement>()
				   .ForMember(prop => prop.Authors, mc => mc.Ignore())
				   .ForMember(prop => prop.AchievementId, mc => mc.Ignore())
				   .ForMember(prop => prop.Documents, mc => mc.Ignore())
				   .ForMember(prop => prop.Links, mc => mc.Ignore())
				   .ReverseMap();
			});
	}
}
