using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using static LizBrunner.Business.Models.Util.Enums;

namespace LizBrunner.App.ViewModels
{
    public class AdressViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [DisplayName("Logradouro")]
        [Required(ErrorMessage = "O campo é obrigatório")]
        [StringLength(100, ErrorMessage = "Maximo de 100 caracteres")]
        public string Street { get; set; }
        
        [DisplayName("Numero")]
        [Required(ErrorMessage = "O campo é obrigatório")]
        public string Number { get; set; }

        [DisplayName("Complemento")]
        [StringLength(150, ErrorMessage = "Maximo de 150 caracteres")]
        public string Complement { get; set; }

        [DisplayName("CEP")]
        [Required(ErrorMessage = "O campo é obrigatório")]
        public string Zipcode { get; set; }

        [DisplayName("Bairro")]
        [Required(ErrorMessage = "O campo é obrigatório")]
        public string Neighborhood { get; set; }

        [DisplayName("Cidade")]
        [Required(ErrorMessage = "O campo é obrigatório")]
        public string City { get; set; }

        [DisplayName("Estado")]
        [Required(ErrorMessage = "O campo é obrigatório")]
        public State State { get; set; }

        /* RF Relation */
        public ClientViewModel Client { get; set; }
    }
}
