using Pattern.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

namespace Infrastructure.Repository {
    public abstract class RepositoryBase<Entity> : IRepositoryBase<Entity> where Entity : class {

        private static NorthwindContext _context;

        public static NorthwindContext DbContext {
            get {
                _context = _context ?? new NorthwindContext();
                return _context;
            }
            set { _context = value; }
        }

        public bool Delete(Entity entity) {
            DbContext.Set<Entity>().Remove(entity);
            return DbContext.SaveChanges() > 0;
        }

        public List<Entity> GetAll() {
            return DbContext.Set<Entity>().ToList();
        }

        public bool Insert(Entity entity) {
            DbContext.Set<Entity>().Add(entity);
            return DbContext.SaveChanges() > 0;
        }

        public bool Update(Entity entity) {
            //DbContext.Entry(entity).State = EntityState.Modified;
            DbContext.Set<Entity>().AddOrUpdate(entity);
            return DbContext.SaveChanges() > 0;
        }

        public abstract Entity GetById(int id);
    }
}
