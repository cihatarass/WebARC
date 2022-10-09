using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityLayer.Concrete
{
    public class Contact
    {
        [Key]
        public int Contact_ID { get; set; }

        [StringLength(200)]
        public string Title { get; set; }

        [StringLength(1000)]
        public string Map { get; set; }

        [StringLength(100)]
        public string Mail { get; set; }

        [StringLength(100)]
        public string Mail1 { get; set; }

        [StringLength(100)]
        public string Gsm { get; set; }

        [StringLength(100)]
        public string Gsm1 { get; set; }

        [StringLength(100)]
        public string Pbx { get; set; }

        [StringLength(1000)]
        public string Adress { get; set; }
    }
}
