using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GetHelp.Models
{
    public class UnitOfWork
    {
        private DataBase db = new DataBase();
        private QueriesRepository queriesRepository;
    
        public QueriesRepository Queries
        {
            get
            {
                if (queriesRepository == null)
                    queriesRepository = new QueriesRepository(db);
                return queriesRepository;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
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