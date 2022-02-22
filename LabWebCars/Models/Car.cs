using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;


namespace LabWebCars.Models
{
    public class Car
    {
        public int Id { get; set; }
        [Display(Name= "Марка")]
        [Required(ErrorMessage = "Поле не повинно бути порожнім")]
        public string Name { get; set; }
        [Display(Name = "Кузов")]
        [Required(ErrorMessage = "Поле не повинно бути порожнім")]
        public string Body { get; set; }
        [Display(Name = "Колір")]
        [Required(ErrorMessage = "Поле не повинно бути порожнім")]
        public string Color { get; set; }
        [Display(Name = "Рік")]
        [Required(ErrorMessage = "Поле не повинно бути порожнім")]
        public int Year { get; set; }
        [Display(Name = "Коробка передач")]
        [Required(ErrorMessage = "Поле не повинно бути порожнім")]
        public string Transmission { get; set; }
        [Display(Name = "Дилер")]
        public int ProducerId { get; set; }
        [Display(Name = "Інформація")]
        public string Info { get; set; }
        [Display(Name = "Фото")]
        public string Photo { get; set; }
        [NotMapped]
        [DisplayName("Upload File")]
        public IFormFile ImageFile { get; set; }
        public virtual Producer Producer { get; set; }
    }
}
