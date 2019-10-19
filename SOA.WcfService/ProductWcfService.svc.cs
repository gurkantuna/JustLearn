using AutoMapper;
using JustLearn.DTO;
using Pattern.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SOA.WcfService {
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ProductWcfService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ProductWcfService.svc or ProductWcfService.svc.cs at the Solution Explorer and start debugging.
    public class ProductWcfService : IProductWcfService {
        private static NorthwindContext _context;

        public static NorthwindContext DbContext {
            get {
                _context = _context ?? new NorthwindContext();
                return _context;
            }
            set { _context = value; }
        }

        public List<ProductDTO> GetProducts() {
            IMapper mapper = ProductToDTOMapper();
            var products = DbContext.Products.ToList();//It will be Repository Pattern with DesignPatterns project
            return mapper.Map<List<ProductDTO>>(products);
        }

        public bool Insert(ProductDTO dto) {
            var mapper = DTOToProductMapper();
            Product p = mapper.Map<Product>(dto);
            DbContext.Products.Add(p);
            return DbContext.SaveChanges() > 0;
        }

        private IMapper ProductToDTOMapper() {
            return new MapperConfiguration(cfg => {
                cfg.CreateMap<Product, ProductDTO>().ForMember(
                    dest => dest.CategoryName,
                    from => from.MapFrom(s => s.Category.CategoryName));
            }).CreateMapper();
        }

        private IMapper DTOToProductMapper() {
            return new MapperConfiguration(cfg => {
                cfg.CreateMap<ProductDTO, Product>().ForMember(
                    dest => dest.CategoryID,
                    from => from.MapFrom(s => s.CategoryID));
            }).CreateMapper();
        }
    }
}
