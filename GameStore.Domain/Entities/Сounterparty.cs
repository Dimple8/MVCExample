using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace GameStore.Domain.Entities
{
    [Table("Сounterpartys")]
    public class Сounterparty
    {
        [HiddenInput(DisplayValue = false)]
        [Key]
        public int id_counterparty { get; set; }

        [Required]
        [Display(Name = "Номер договора ККМ")]        
        public string nomDogKKM { get; set; }

        [Required]
        [Display(Name = "Наименование")]
        public string name { get; set; }

        [Display(Name = "Тип")]
        public string type { get; set; }

        [RegularExpression(@"^\d{10}(\d{2})?$", ErrorMessage = "ИНН должен состоять из 10(юр. лицо) или 12(физ. лицо) цифр")]
        [Display(Name = "ИНН")]
        public string inn { get; set; }

        [Display(Name = "Номер договора ЕГАИС")]
        public string nomDogEGAIS { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Дата договора ЕГАИС")]
        public DateTime dateDogEGAIS { get; set; }

        [Display(Name = "Номер телефона")]
        public string phoneNumber { get; set; }

        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Введите корректный email")]
        [Display(Name = "email")]
        public string email { get; set; }

        public Сounterparty()
        {
            dateDogEGAIS = DateTime.Today;
        }
    }
}

