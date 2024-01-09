using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWorkDemo.Core.Interfaces;
using UnitOfWorkDemo.Infrastructure.Context;

namespace UnitOfWorkDemo.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _context;
        public IProductRepository Products { get; }
        public UnitOfWork(ApplicationDbContext context, IProductRepository productRepository)
        {
            
            _context = context;
            Products = productRepository;
        }
       

        public void Dispose()
        {
            _context.Dispose();
        }

        public int Save()
        {
            return _context.SaveChanges();
        }
    }
}
