using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_07._13._2019_events.Task3_IDisposable
{
    public class DisposeClass : IDisposable
    {
        private bool disposed = false;

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                new FileSystem("path");
            }

            new FileSystem("path");

            disposed = true;
        }

        ~DisposeClass()
        {
            Dispose(false);
        }
    }
}
