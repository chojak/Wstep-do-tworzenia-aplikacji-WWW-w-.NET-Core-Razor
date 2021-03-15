using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace AddressBook.Models
{
    public class Address
    {
        [Display(Name = "Twoja ulica:")]
        [StringLength(60, MinimumLength = 3)]
        [Required(ErrorMessage = "Pole 'Twoja ulica' jest obowiązkowe.")]
        public string Street { get; set; }
        [Display(Name = "Kod pocztowy:")]
        [Required(ErrorMessage = "Pole 'Kod pocztowy' jest obowiazkowe.")]
        public string ZipCode { get; set; }
        [Display(Name = "Miasto: ")]
        [Required(ErrorMessage ="Pole 'Miasto' jest obowiazkowe.")]
        public string City { get; set; }
        [Display(Name = "Numer mieszkania: ")]
        [Required(ErrorMessage = "Pole 'Numer mieszkania' jest obowiazkowe.")]
        public int Number { get; set; }
    }

}
