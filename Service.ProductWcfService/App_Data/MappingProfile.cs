using AutoMapper;
using AutoMapper.Configuration;
using JustLearn.DTO;
using Pattern.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Service.ProductWcfService {
    public sealed class MappingProfile : Profile {

        public IMapper Mapper { get; private set; }

        public MappingProfile() {
            this.CreateMap<Product, ProductDTO>().ForMember(p => p.CategoryName, x => x.MapFrom(dto => dto.Category.CategoryName));
            this.CreateMap<ProductDTO, Product>();
            var exp = new MapperConfigurationExpression();
            exp.AddProfile(this);
            MapperConfiguration config = new MapperConfiguration(exp);
            this.Mapper = config.CreateMapper();
        }
    }
}