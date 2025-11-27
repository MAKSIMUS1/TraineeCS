using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Memory
{
    public class SomeGarbageObject : IDisposable
    {
        private byte[] _data;
        private Component component = new Component();
        private bool _disposed;
        public SomeGarbageObject(int sizeMb)
        {
            _data = new byte[sizeMb * 1024 * 1024];
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    component.Dispose();
                }

                _data = null;
                
                _disposed = true;
            }
        }

        ~SomeGarbageObject()
        {
            Dispose(false);
        }
    }
}
