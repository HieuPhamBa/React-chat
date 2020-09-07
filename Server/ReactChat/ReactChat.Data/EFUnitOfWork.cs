using ReactChat.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReactChat.Data
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private readonly IMongoContext _context;
        public EFUnitOfWork(IMongoContext context)
        {
            _context = context;
        }
        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
