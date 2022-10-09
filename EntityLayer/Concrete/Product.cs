using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityLayer.Concrete
{
    public class Product
    {
        [Key]
        public int Product_ID { get; set; }

        [StringLength(200)]
        public string Title { get; set; }

        [StringLength(200)]
        public string Brand { get; set; }

        [StringLength(200)]
        public string SubBrand { get; set; }

        [StringLength(1200)]
        public string Text { get; set; }

        [StringLength(1000)]
        public string Feature { get; set; }

        [StringLength(75)]
        public string Stock { get; set; }

        [StringLength(200)]
        public string Image { get; set; }

        [DisplayName("Ürün Açıklaması")]
        [StringLength(200)]
        public string Seo_Description { get; set; }

        [DisplayName("Ürün Anahtar Kelimeleri")]
        [StringLength(200)]
        public string Seo_Keywords { get; set; }
    }
}
