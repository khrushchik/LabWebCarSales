using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace LabWebCars.Models
{
    public class Producer
    {
        public Producer()
        {
            Cars = new List<Car>();
        }
        public int Id { get; set; }
        [Display(Name = "Дилер")]
        [Required(ErrorMessage = "Поле не повинно бути порожнім")]
        public string Name { get; set; }
        [Display(Name = "Адреса")]
        [Required(ErrorMessage = "Поле не повинно бути порожнім")]
        public string Country { get; set; }
        [Display(Name = "Концерн")]
        public int CorporationId { get; set; }
        [Display(Name = "Інформація")]
        public string Info { get; set; }
        [Display(Name = "Фото")]
        public string Icon { get; set; }
        [NotMapped]
        [DisplayName("Upload File")]
        public IFormFile ImageFile { get; set; }
        public virtual ICollection<Car> Cars { get; set; }
        public virtual Corporation Corporation { get; set; }
    }
}
