﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Win32.SafeHandles;
using Provet.Domain.Interfaces.Generics;
using Provet.Infrastructure.Configuration;
using System.Runtime.InteropServices;

namespace Provet.Infrastructure.Repositories.Generic
{
    public class GenericRepository<T> : IGeneric<T>, IDisposable where T : class
    {

        private readonly DbContextOptions<ContextBase> _dbContextOptions;

        public GenericRepository()
        {
            _dbContextOptions = new DbContextOptions<ContextBase>();
        }

        public async Task<List<T>> GetAll()
        {
            using var data = new ContextBase(_dbContextOptions);
            return await data.Set<T>().ToListAsync();
        }

        public async Task Add(T entity)
        {
            using var data = new ContextBase(_dbContextOptions);
            await data.Set<T>().AddAsync(entity);
            await data.SaveChangesAsync();
        }

        public async Task<T> GetEntityById(int id)
        {
            using var data = new ContextBase(_dbContextOptions);
            return await data.Set<T>().FindAsync(id);
        }

        public async Task Update(T entity)
        {
            using var data = new ContextBase(_dbContextOptions);
            data.Set<T>().Update(entity);
            await data.SaveChangesAsync();
        }

        public async Task Delete(T entity)
        {
            using var data = new ContextBase(_dbContextOptions);
            data.Set<T>().Remove(entity);
            await data.SaveChangesAsync();
        }

        #region Disposed https://docs.microsoft.com/pt-br/dotnet/standard/garbage-collection/implementing-dispose

        // Flag: Has Dispose already been called?
        bool disposed = false;
        // Instantiate a SafeHandle instance.
        SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);



        // Public implementation of Dispose pattern callable by consumers.
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }


        // Protected implementation of Dispose pattern.
        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                handle.Dispose();
                // Free any other managed objects here.
                //
            }

            disposed = true;
        }

        #endregion
    }
}
