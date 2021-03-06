﻿using System;
using System.Collections.Generic;
using ShopModel;
using Microsoft.Extensions.DependencyInjection;
namespace Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            var products = new List<Product>
            {
                new Product() { ProductID = 1, Name = "computer", Category = "electronics", Description = "powerful PC", Price = 133.33m },
                new Product() { ProductID = 2, Name = "T-Shirt", Category = "clothes", Description = "blue T-shirt", Price = 1.22m }
            };
            var serviceProviser = RegisterServices();
            var factory = serviceProviser.GetService<ICalculatorFactory>();
            var calculator = factory.GetCalculator();
            var cart=new ShoppingCart(calculator);
            cart.FillShoppingCart(products);
            Product ball = new Product() { ProductID = 3, Name = "Ball", Category = "sport", Description = "football ball", Price = 5.8m };
            cart.AddProduct(ball);
            Console.WriteLine(cart.CalculateProductTotal());
        }
        private static ServiceProvider RegisterServices()
        {
            var services=new ServiceCollection();
            services.AddTransient<ICalculatorFactory, CalculatorWithReducedCostFactory>(s =>new CalculatorWithReducedCostFactory(3));
            return services.BuildServiceProvider();

        }
    }
}
