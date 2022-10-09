using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityLayer.Concrete
{
    public class PrivacyPolicy
    {
        [Key]
        public int PrivacyPolicy_ID { get; set; }

        [StringLength(50)]
        public string Title { get; set; }

        [StringLength(2000)]
        public string Text { get; set; }

        [StringLength(150)]
        public string Image { get; set; }

        [StringLength(180)]
        public string SEO_Description { get; set; }

        [StringLength(180)]
        public string SEO_Keywords { get; set; }
    }
}
