// See https://aka.ms/new-console-template for more information

using DatabaseFirst.Dal;
using Microsoft.EntityFrameworkCore;

DbContextInitializer.Build();
using (var _context = new AppDbContext())
{
    var product=await _context.Product.ToListAsync();
    foreach (var x in product)
    {
        Console.WriteLine($"{x.Id} : {x.Name} Fiyatı:{x.Price} TL. Stokta:{x.Stock} Adet Vardır.");
    }
}
