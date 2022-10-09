using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityLayer.Concrete
{
    public class About
    {
        [Key]
        public int About_ID { get; set; }

        [StringLength(100)]
        public string Title { get; set; }

        [StringLength(2000)]
        public string Text { get; set; }

        [StringLength(200)]
        public string Image { get; set; }

        [DisplayName("Sayfa Açıklaması")]
        [StringLength(200)]
        public string Seo_Description { get; set; }

        [DisplayName("Sayfa Anahtar Kelimeleri")]
        [StringLength(200)]
        public string Seo_Keywords { get; set; }
    }
}
