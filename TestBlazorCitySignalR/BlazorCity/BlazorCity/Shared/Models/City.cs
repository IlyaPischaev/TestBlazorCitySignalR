using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlazorCity.Shared.Models
{
    public class City
    {
        [Key]
        public int CityId { get; set; }

        [Required(ErrorMessage = "Введите название города")]
        public string CityName { get; set; }

        [Range(1, 1000000000, ErrorMessage = "Невозможные данные данные по населению (в пределах от 1 человека до 1 миллиарда людей)")]
        public int CityPopulation { get; set; }

        [Range(-5000, 2000, ErrorMessage = "Год основания невозможен (должен быть в пределах от -5000 до 2000)")]
        public int CityFoundationYear { get; set; }

        [Range(1, 12, ErrorMessage = "Выберите месяц основания города")]
        public int CityDoundationMonth { get; set; }

        [Range(1, 31, ErrorMessage = "День основания невозможен (должен быть в пределах от 1 до 31)")]
        public int CityDoundationDay { get; set; }
    }
}
