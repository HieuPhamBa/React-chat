using ReactChat.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReactChat.Data
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private readonly MongoContext _context;
        public EFUnitOfWork(MongoContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
        //public void Commit()
        //{
        //    _context.SaveChanges();
        //}

        //public void Dispose()
        //{
        //    _context.Dispose();
        //}
    }
}
