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

        [Display(Name = "Номер договора ККМ")]        
        public string nomDogKKM { get; set; }

        [Display(Name = "Наименование")]
        public string name { get; set; }

        [Display(Name = "Тип")]
        public string type { get; set; }

        [Display(Name = "ИНН")]
        public string inn { get; set; }

        [Display(Name = "Номер договора ЕГАИС")]
        public string nomDogEGAIS { get; set; }

        [Display(Name = "Дата договора ЕГАИС")]
        public DateTime dateDogEGAIS { get; set; }

        [Display(Name = "Номер телефона")]
        public string phoneNumber { get; set; }

        [Display(Name = "email")]
        public string email { get; set; }


    }
}

