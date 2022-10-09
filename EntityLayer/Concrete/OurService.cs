using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityLayer.Concrete
{
    public class OurService
    {
        [Key]
        public int OurService_ID { get; set; }

        [MaxLength(100)]
        public string Title { get; set; }

        [MaxLength(1500)]
        public string Text { get; set; }

        [MaxLength(200)]
        public string Image { get; set; }

        [DisplayName("Hizmet Açıklaması")]
        [MaxLength(200)]
        public string Seo_Description { get; set; }

        [DisplayName("Hizmet Anahtar Kelimeleri")]
        [MaxLength(200)]
        public string Seo_Keywords { get; set; }
    }
}
