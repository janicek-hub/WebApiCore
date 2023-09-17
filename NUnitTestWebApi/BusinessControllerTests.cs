using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using NUnit.Framework;
using System;
using WebApi.BusinessControllers;
using WebApi.BusinessControllers.Interfaces;
using WebApi.Controllers;
using WebApi.DTO;
using WebApi.Extensions;
using WebApi.Model;
using WebApi.Model.Entities;
using WebApi.Repository;
using WebApi.Repository.Interfaces;

namespace NUnitTestWebApi
{
    public class BusinessControllerTests
    {
        private readonly string ConfigFile = "appsettings-unittest.json";
        private IConfiguration configuration;
        private WebApiContext context;
        private IProductBusinessController productBusinessController;
        private IProductRepository productRepository;
        private ILoggerFactory loggerFactory;

        public BusinessControllerTests()
        {
              configuration = new ConfigurationBuilder()
                .AddJsonFile(ConfigFile)
                .Build();

            loggerFactory = LoggerFactory.Create(builder => builder.AddConsole());
        }

        [SetUp]
        public void Setup()
        {
            var optionsBuilder = new DbContextOptionsBuilder<WebApiContext>();
            optionsBuilder.OnConfigure(configuration, "WebApiDB");
            context = new WebApiContext(optionsBuilder.Options);
            context.EnsureCreated();

            productRepository = new ProductRepository(context);
            productBusinessController = new ProductBusinessController(productRepository, loggerFactory.CreateLogger<ProductBusinessController>());
        }

        /// <summary>
        /// Test product update description
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task ProductPatchTest()
        {
            //product
            var product = new ProductDTO
            {
                Name = "Test",
                ImgUri = "test URL",
                Price = 1000
            };
            //Create
            product = await productBusinessController.CreateAsync(product);
            Assert.True(product.Id > 0);
            //Patch
            var productPatch = new ProductPatchDTO
            {
                Description = "Test description"
            };
            product = await productBusinessController.PatchProductAsync(product.Id, productPatch);
            product = await productBusinessController.GetProductAsync(product.Id);
            Assert.That(productPatch.Description, Is.EqualTo(product.Description));
        }

        /// <summary>
        /// Test for return product by id
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task GetProductByIdTest()
        {
            //product
            var product = new ProductDTO
            {
                Name = "Test",
                ImgUri = "test URL",
                Price = 1000
            };
            //Create
            product = await productBusinessController.CreateAsync(product);
            Assert.True(product.Id > 0);
            //Get            
            var productGet = await productBusinessController.GetProductAsync(product.Id);
            Assert.IsNotNull(productGet);
        }

        /// <summary>
        /// Test for return all products
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task GetAllTest()
        {
            //generate products
            var products = GetMockProductList(20);
            //Create
            foreach (var product in products)
            {
                _ = await productBusinessController.CreateAsync(product);
            }
            //Get            
            var productGet = await productBusinessController.GetAllAsync();
            Assert.That(productGet.Count(), Is.EqualTo(20));
        }

        /// <summary>
        /// Test for return paginated product list
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task GetPaginationTest()
        {
            //generate products
            var products = GetMockProductList(20);
            //Create
            foreach (var product in products)
            {
                _ = await productBusinessController.CreateAsync(product);
            }
            //Get            
            var productGet = await productBusinessController.GetAsync(0, 10);
            Assert.That(productGet.Rows.Count(), Is.EqualTo(10));
        }

        /// <summary>
        /// Generated mock data
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        private List<ProductDTO> GetMockProductList(int count)
        {
            var list = new List<ProductDTO>();
            //generate products
            for (int i = 0; i < count; i++)
            {
                list.Add(new ProductDTO
                {
                    Name = "Product" + i,
                    ImgUri = "test URL",
                    Price = 1000
                });
            } 
            return list;
        }
    }
}