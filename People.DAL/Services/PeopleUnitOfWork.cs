using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using People.DAL.Entities;

namespace People.DAL.Services
{
    public class PeopleUnitOfWork : IPeopleUnitOfWork, IDisposable
    {
        DbContext _context = new PeopleContext();

        IPeopleRepository<Person> _folksRepo;
        public IPeopleRepository<Person> FolksRepo
        {
            get
            {
                if (_folksRepo == null)
                    _folksRepo = new PeopleRepository<Person>(_context.Set<Person>());
                return _folksRepo;
            }
        }

        public void Complete()
        {
            _context.SaveChanges();
        }

        bool disposed = false;
        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
