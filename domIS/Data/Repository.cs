﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public abstract class Repository<T> : IRepository<T>
        where T : class
    {
        private readonly UcastniciContext _context;


        public Repository() 
        { 
            _context = new UcastniciContext();
        }
        
        public Repository(UcastniciUnitOfWork uow)
        {
            _context = uow.Context;
        }

        public IQueryable<T> GetAll()
        {
 	        throw new NotImplementedException();
        }

        public IQueryable<T> FindBy(System.Linq.Expressions.Expression<Func<T,bool>> predicate)
        {
 	        throw new NotImplementedException();
        }

        public virtual void Add(T entity)
        {
               _context.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
 	        throw new NotImplementedException();
        }

        public void Edit(T entity)
        {
 	        throw new NotImplementedException();
        }
    }
}


//public abstract class GenericRepository<C, T> :
//    IGenericRepository<T>
//    where T : class
//    where C : DbContext, new()
//{

//    private C _entities = new C();
//    public C Context
//    {

//        get { return _entities; }
//        set { _entities = value; }
//    }

//    public virtual IQueryable<T> GetAll()
//    {

//        IQueryable<T> query = _entities.Set<T>();
//        return query;
//    }

//    public IQueryable<T> FindBy(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
//    {

//        IQueryable<T> query = _entities.Set<T>().Where(predicate);
//        return query;
//    }

//    public virtual void Add(T entity)
//    {
//        _entities.Set<T>().Add(entity);
//    }

//    public virtual void Delete(T entity)
//    {
//        _entities.Set<T>().Remove(entity);
//    }

//    public virtual void Edit(T entity)
//    {
//        _entities.Entry(entity).State = System.Data.EntityState.Modified;
//    }

//    public virtual void Save()
//    {
//        _entities.SaveChanges();
//    }
//}