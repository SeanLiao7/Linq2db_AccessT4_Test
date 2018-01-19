using System;
using System.Linq;
using System.Linq.Expressions;
using LinqToDB;
using LinqToDB.Data;
using LinqToDB.DataProvider.Access;
using LinqToDB.Linq;

namespace AccessConsole.Repository
{
    public class AccessGenericRepository<TEntity> : IDisposable
        where TEntity : class
    {
        private readonly string _connectionString;
        private readonly DataConnection _dataConnection;
        private readonly ITable<TEntity> _dbSet;

        public AccessGenericRepository( string connectionString )
        {
            _dataConnection = AccessTools.CreateDataConnection( connectionString );
            _dbSet = _dataConnection.GetTable<TEntity>( );
            _connectionString = connectionString;
        }

        public void Create( TEntity entity )
        {
            _dataConnection.Insert( entity );
        }

        public void Delete( TEntity entity )
        {
            _dataConnection.Delete( entity );
        }

        public void Dispose( )
        {
            _dataConnection?.Dispose( );
        }

        public IQueryable<TEntity> Read( Expression<Func<TEntity, bool>> predicate )
        {
            return _dbSet.Where( predicate );
        }

        public IQueryable<TEntity> ReadAll( )
        {
            return _dbSet.AsQueryable( );
        }

        public void Update( TEntity entity )
        {
            _dataConnection.Update( entity );
        }

        public void Update( IUpdatable<TEntity> updatableQuery )
        {
            updatableQuery.Update( );
        }
    }
}