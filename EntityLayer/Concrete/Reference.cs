using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityLayer.Concrete
{
    public class Reference
    {
        [Key]
        public int Reference_ID { get; set; }

        [DisplayName("Şirket Adı")]
        [StringLength(150)]
        public string CompanyName { get; set; }

        [DisplayName("Referans verenin Ünvanı ve Adı Soyadı ")]
        [StringLength(100)]
        public string  PersonName { get; set; }

        [DisplayName("Referans Verilen Proje Adı")]
        [StringLength(200)]
        public string Project { get; set; }

        [DisplayName("İşletmemiz Hakkında Yorumu")]
        [StringLength(1000)]
        public string Comment { get; set; }

        [StringLength(150)]
        public string Image { get; set; }

    }
}

