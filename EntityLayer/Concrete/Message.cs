using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityLayer.Concrete
{
    public class Message
    {

        [Key]
        public int Message_ID { get; set; }

        [StringLength(120)]
        public string Subject { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(60)]
        public string Mail { get; set; }

        [StringLength(400)]
        public string Text { get; set; }


    }
}
