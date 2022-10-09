using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityLayer.Concrete
{
    public class SocialLinks
    {
        [Key]
        public int SocialLinks_ID { get; set; }

        [StringLength(70)]
        public string Facebook { get; set; }

        [StringLength(70)]
        public string Twitter { get; set; }

        [StringLength(70)]
        public string Github { get; set; }

        [StringLength(70)]
        public string Instagram { get; set; }

        [StringLength(70)]
        public string Whatsapp { get; set; }

        [StringLength(70)]
        public string Telegram { get; set; }

        [StringLength(100)]
        public string Spotify { get; set; }
    }
}
