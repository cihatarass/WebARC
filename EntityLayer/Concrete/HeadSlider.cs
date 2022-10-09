using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityLayer.Concrete
{
    public class HeadSlider
    {
        [Key]
        public int Slider_ID { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        [StringLength(150)]
        public string SubTitle { get; set; }

        [StringLength(1500)]
        public string Text { get; set; }

        [StringLength(200)]
        public string Image { get; set; }
    }
}
