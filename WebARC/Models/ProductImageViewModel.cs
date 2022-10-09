using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebARC.Models
{
    public class ProductImageViewModel
    {

        public int Product_ID { get; set; }

        public string Title { get; set; }

        public string Brand { get; set; }

        public string SubBrand { get; set; }

        public string Text { get; set; }

        public string Feature { get; set; }

        public string Stock { get; set; }

        public IFormFile Image { get; set; }

        public string Seo_Description { get; set; }

        public string Seo_Keywords { get; set; }

    }
}
