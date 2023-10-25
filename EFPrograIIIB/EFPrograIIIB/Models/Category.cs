using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFPrograIIIB.Models
{
    public class Category
    {
        [Key]
        public int CategoryId{ get; set; }
        public string? Name { get; set; }
        public virtual ObservableCollectionListSource<Product> Products { get; set; } = new();
    }
}
