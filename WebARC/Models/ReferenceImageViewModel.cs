using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebARC.Models
{
    public class ReferenceImageViewModel
    {

        public int Reference_ID { get; set; }

        public string CompanyName { get; set; }

        public string PersonName { get; set; }

        public string Project { get; set; }

        public string Comment { get; set; }

        public IFormFile Image { get; set; }
    }
}
