using AutoMapper;
using AutoMapper.Configuration;
using Infrastructure.Repository;
using JustLearn.DTO;
using Pattern.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.ServiceModel;
using System.Web;

namespace Service.ProductWcfService
{
    public abstract class ServiceBase<Repo, Entity, DTO> : IServiceBase<DTO, Entity>
        where Repo : IRepositoryBase<Entity>
    {

        private static Repo _repo;
        public static Repo Repository {
            get {
                //_repo = _repo ?? Activator.CreateInstance<Repo>();
                if (_repo == null) {
                    _repo = Activator.CreateInstance<Repo>();
                }
                return _repo;
            }
            set { _repo = value; }
        }

        public bool Delete(DTO dto) {
            var entity = new MappingProfile().Mapper.Map<Entity>(dto);
            return Repository.Delete(entity);
        }

        public bool Insert(DTO dto) {
            var entity = new MappingProfile().Mapper.Map<Entity>(dto);
            return Repository.Insert(entity);
        }

        public List<DTO> GetAll() {
            var entities = Repository.GetAll();
            return new MappingProfile().Mapper.Map<List<DTO>>(entities);
        }

        public bool Update(DTO dto) {            
            var entity = new MappingProfile().Mapper.Map<Entity>(dto);
            return Repository.Update(entity);
        }

        public bool UpdateEntity(Entity entity) {
            return Repository.Update(entity);
        }

        public List<Entity> GetEntities() {
            return Repository.GetAll();
        }        
    }
}