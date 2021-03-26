using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using System;

namespace GameStore.Domain.Entities
{
    public class Сounterpartys
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

        [RegularExpression(@"[0-9]", ErrorMessage = "ИНН должен состоять из цифр")]
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

        [RegularExpression(@"[a-zA-Z@a-zA-Z.]", ErrorMessage = "Введите корректный email")]
        [Display(Name = "email")]
        public string email { get; set; }


    }
}

