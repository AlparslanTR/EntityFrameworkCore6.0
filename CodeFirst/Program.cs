// See https://aka.ms/new-console-template for more information
using AutoMapper.QueryableExtensions;
using CodeFirst;
using CodeFirst.Data;
using CodeFirst.Dto;
using CodeFirst.Mappers;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Linq;

Initializer.Build();

using (var _context = new AppDbContext())
{
    //var products = await _context.Products.Select(x=>new ProductDTO
    //{
    //    Id=x.Id,
    //    Name=x.Name,
    //    Price=x.Price,
    //    Stock=x.Stock
    //}).ToListAsync();

    //var getAllProducs= await _context.Products.ToListAsync();
    //var productDto=CustomMapper.mapper.Map<List<ProductDTO>>(getAllProducs);
    var projectto= await _context.Products.ProjectTo<ProductDTO>(CustomMapper.mapper.ConfigurationProvider).ToListAsync();
    Console.WriteLine("Başarılı");






    //var addProduct = new Product()
    //{
    //    Name = "Iphone 14 Pro",
    //    Price = 45000,
    //    Stock = 100,
    //    CategoryId = 1,
    //};
    //var newId = new SqlParameter("@newId", SqlDbType.Int);
    //newId.Direction = ParameterDirection.Output;
    //_context.Database.ExecuteSqlInterpolated($"exec addProduct {addProduct.Name},{addProduct.Price},{addProduct.Stock},{addProduct.CategoryId},{newId} out");





    //****Güncelleme İŞLEMİ******
    //var updateProductFirstValue = await _context.Products.FindAsync(2);
    //updateProductFirstValue.Name = "Kalem";
    //await _context.SaveChangesAsync();
    //Console.WriteLine(updateProductFirstValue);



    //****EKLEME İŞLEMİ******
    //var newProduct = new Product { Name = "Kalem 200", Price = 200, Stock = 100 };
    //await _context.AddAsync(newProduct);
    //await _context.SaveChangesAsync();
    //Console.WriteLine(newProduct);
    //**** //**** //**** //****


    //var product = await _context.Products.AsNoTracking().ToListAsync();
    //foreach (var x in product)
    //{
    //    //var state = _context.Entry(x).State;

    //    x.Stock += 400;

    //    //Console.WriteLine($"{x.Id} : {x.Name} Fiyatı:{x.Price} TL. Stokta:{x.Stock} Adet Vardır. State: {state}");
    //}


    //_context.ChangeTracker.Entries().ToList().ForEach(x => {
    //    if (x.Entity is Product y)
    //    {
    //        y.Stock += 500;
    //        Console.WriteLine($"{y.Id} : {y.Name} Fiyatı:{y.Price} TL. Stokta:{y.Stock} Adet Vardır.");
    //    }
    //});
    //_context.SaveChanges();
}