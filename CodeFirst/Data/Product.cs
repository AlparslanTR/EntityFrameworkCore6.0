using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Data
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Decimal Price { get; set; }
        public int Stock { get; set; }
        public bool IsDeleted { get; set; }
        public int CategoryId { get; set; }

        //Navigation Property
        public Category Categories { get; set; }
        public ProductFeature ProductFeatures { get; set; }
    }
}
