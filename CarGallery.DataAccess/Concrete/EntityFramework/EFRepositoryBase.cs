using CarGallery.DataAccess.Abstract;
using CarGallery.Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace CarGallery.DataAccess.Concrete.EntityFramework
{
    public class EFRepositoryBase<Tentity, Tcontext> :
        IEntityRepository<Tentity>
        where Tentity : class, IEntity, new()
        where Tcontext : DbContext, new()
    {
        public void Add(Tentity entity)
        {
            using (Tcontext context = new Tcontext())
            {
                context.Entry(entity).State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Tentity entity)
        {
            using (Tcontext context = new Tcontext())
            {
                context.Entry(entity).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Tentity Get(Expression<Func<Tentity, bool>> filter)
        {
            using (Tcontext context = new Tcontext())
            {
                return context.Set<Tentity>().SingleOrDefault(filter);
            }
        }

        public List<Tentity> GetAll(Expression<Func<Tentity, bool>> filter = null)
        {
            using (Tcontext context = new Tcontext())
            {
                return context.Set<Tentity>().ToList();
            }
        }

        public void Update(Tentity entity)
        {
            using (Tcontext context = new Tcontext())
            {
                context.Entry(entity).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
