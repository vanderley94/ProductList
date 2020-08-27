using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListagemProduto.Models
{
    public class ProductPhoto
    {
        public Guid Id { get; set; }

        public string UrlPhoto { get; set;}

        public virtual Product Products { get; set; }
        public Guid IdProduct { get; set; }
    }
}
