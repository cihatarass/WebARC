using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityLayer.Concrete
{
    public class Settings
    {
        [Key]
        public int Settings_ID { get; set; }

        [StringLength(150)]
        public string SiteTitle { get; set; }

        [StringLength(180)]
        public string SiteDescription { get; set; }

        [StringLength(180)]
        public string SiteKeywords { get; set; }

        [StringLength(150)]
        public string Logo_Img { get; set; }

        [StringLength(300)]
        public string G_Analystics { get; set; }

        public bool   Site_Status { get; set; }
    }
}
