using Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Negocio
{
    public class Negocio : IDisposable
    {
        bool Disposed;

        protected virtual void Dispose(bool disposing)
        {
            if (!Disposed)
            {
                if (disposing)
                {
                    var contexto = ContextoBanco.Get;
                    contexto.SaveChanges();
                }
                
            }
            //dispose unmanaged resources
            Disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}