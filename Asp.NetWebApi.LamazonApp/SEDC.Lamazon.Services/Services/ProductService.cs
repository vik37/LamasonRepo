using AutoMapper;
using SEDC.Lamazon.Domain.DomainModels;
using SEDC.Lamazon.Services.Interfaces;
using SEDC.Lamazon.WebModels.ViewModels;
using SEDC.LAMAZON.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.Lamazon.Services.Services
{
    public class ProductService : IProductService
    {
        protected readonly IRepository<Product> _productRepository;
        protected readonly IMapper _mapper;
        public ProductService(IRepository<Product> productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }
        public IEnumerable<ProductVM> GetAllProducts()
        {
            List<Product> products = _productRepository.GetAll().ToList();
            return _mapper.Map<List<Product>, List<ProductVM>>(products);
        }

        public ProductVM GetProductById(int id)
        {
            Product product = _productRepository.GetById(id);

            ProductVM model = _mapper.Map<ProductVM>(product);

            if (model != null)
            {
                return model;
            }
            else
            {
                throw new Exception($"Product with id: {id} does not exist!");
            }
        }
    }
}
