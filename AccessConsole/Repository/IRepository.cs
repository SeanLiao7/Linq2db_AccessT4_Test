using System;
using System.Linq;
using System.Linq.Expressions;

namespace AccessConsole.Repository
{
    public interface IRepository<TEntity>
    {
        void Create( TEntity entity );

        void Delete( TEntity entity );

        IQueryable<TEntity> Read( Expression<Func<TEntity, bool>> predicate );

        IQueryable<TEntity> ReadAll( );

        void SaveChanges( );

        void Update( TEntity entity );
    }
}