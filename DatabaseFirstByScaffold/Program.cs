using DatabaseFirstByScaffold.Models;
using Microsoft.EntityFrameworkCore;

using (var _context= new DatabaseFirstContext())
{
    var product = await _context.Products.ToListAsync();
    foreach (var x in product)
    {
        Console.WriteLine($"{x.Id} : {x.Name} Fiyatı:{x.Price} TL. Stokta:{x.Stock} Adet Vardır.");
    }
}