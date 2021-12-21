using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{   //core katmanında evrensel kodları yazacağız.
    //core katmanı diğer katmanları referans almaz.
    public interface IEntityRepository<T> where T : class,IEntity,new() //class:referans tip olabilir, IEntity:IEntity veya IEntity implemente eden bir class olabilir,new():newlenebilir olsun.
    {
        //interface methodları default publictir.
        List<T> GetAll(Expression<Func<T,bool>> filter=null); //filtre vermeyebilirsin.
        T Get(Expression<Func<T, bool>> filter);//filtre zorunlu.
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
