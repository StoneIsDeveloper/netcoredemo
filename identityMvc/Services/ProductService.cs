using identityMvc.Data;
using identityMvc.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace identityMvc.Services
{
    public interface IProductService
    {
        Task<int> AddProduct(Product entity);
        bool DeltProduct(string id);
        List<Product> GetProduct(Expression<Func<Product, bool>> fun);
    }

    public class ProductService : IProductService
    {
        private readonly ApplicationDbContext _context;

        public Task<int> AddProduct(Product entity)
        {
            throw new NotImplementedException();
        }

        public bool DeltProduct(string id)
        {
            var product = _context.Products.SingleOrDefault(m => m.Id == id);
            if(product != null)
            {
                _context.Products.Remove(product);
                _context.SaveChangesAsync();
                return true ;
            }
            else
            {
                return false;
            }
            //throw new NotImplementedException();
        }

        public List<Product> GetProduct(Expression<Func<Product, bool>> fun)
        {
            return _context.Products.ToList();
            // throw new NotImplementedException();
        }
    }
}
