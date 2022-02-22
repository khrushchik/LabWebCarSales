using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;

namespace LabWebCars.Models
{
    public class Corporation
    {
        public Corporation()
        {
            Producers = new List<Producer>();
        }
        public int Id { get; set; }
        [Display(Name = "Концерн")]
        [Required(ErrorMessage = "Поле не повинно бути порожнім")]
        public string Name { get; set; }
        [Display(Name = "Логотип")]
        public string Label { get; set; }
        [Display(Name = "Інформація")]
        public string Info { get; set; }
        public virtual ICollection<Producer> Producers { get; set; }
        [NotMapped]
        [DisplayName("Upload File")]
        public IFormFile ImageFile { get; set; }

    }
}
