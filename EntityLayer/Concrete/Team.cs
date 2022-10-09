using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityLayer.Concrete
{
    public class Team
    {
        [Key]
        public int Team_ID { get; set; }

        [StringLength(100)]
        public string PersonName { get; set; }

        [StringLength(100)]
        public string Mission { get; set; }

        [StringLength(500)]
        public string ShortBio { get; set; }

        [StringLength(150)]
        public string Image { get; set; }
    }
}
