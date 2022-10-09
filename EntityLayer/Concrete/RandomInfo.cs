using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityLayer.Concrete
{
    public class RandomInfo
    {
        [Key]
        public int Info_ID { get; set; }

        public string Text { get; set; }
    }
}
