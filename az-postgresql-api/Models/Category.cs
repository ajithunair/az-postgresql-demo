using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace az_postgresql_api.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public virtual List<Product>? Products { get; set; }
    }
}