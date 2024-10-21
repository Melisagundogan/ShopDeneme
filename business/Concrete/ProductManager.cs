using System.Collections.Generic;
using shopapp.business.Abstract;
using shopapp.data.Abstract;
using shopapp.data.Concrete;
using shopapp.entity;

namespace shopapp.business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductRepository productRepository;
        private IProductRepository _productRepository;

        public ProductManager(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public void Create(Product entity)
        {
            //iş kurallarını uygula
            productRepository.Create(entity);
        }

        public void Delete(Product entity)
        {
            //iş kurallarını uygula
            productRepository.Delete(entity);
        }

        public List<Product> GetAll()
        {
            return _productRepository.GetAll();
        }

        public Product GetById(int id)
        {
           return _productRepository.GetById(id);
        }
        public Product GetProductDetails(int id)
        {
            return _productRepository.GetProductDetails(id);
        }
        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
