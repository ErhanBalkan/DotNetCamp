using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
// CORE KATMANI DİĞER KATMANLARI REFERANS ALMAZ !
public interface IEntityRepository<T> where T: class,IEntity,new()
// class : referans tip
// T yerine sadece bir referans tip verilebilir ve türü IEntity olabilir...
// Sondaki new() newlenebilir olmalı anlamında yani örneğin interface verilemez...
{
    void Add(T entity);
    void Delete(T entity);
    void Update(T entity);
    List<T> GetAll(Expression<Func<T,bool>> filter=null);
    T Get(Expression<Func<T,bool>> filter);
}