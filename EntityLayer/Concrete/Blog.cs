using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityLayer.Concrete
{
    public class Blog
    {
        [Key]
        public int Blog_ID { get; set; }

        [StringLength(200)]
        public string Title { get; set; }

        public string Text { get; set; }

        [StringLength(200)]
        public string Image { get; set; }

        [StringLength(100)]
        public string Author { get; set; }

        [StringLength(75)]
        public string Subject { get; set; }

        [DisplayName("Blog İçeriği")]
        [StringLength(200)]
        public string Seo_Description { get; set; }

        [DisplayName("Blog Anahtar Kelimeleri")]
        [StringLength(200)]
        public string Seo_Keywords { get; set; }
    }
}
