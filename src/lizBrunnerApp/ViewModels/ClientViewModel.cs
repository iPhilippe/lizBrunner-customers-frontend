using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using static LizBrunner.Business.Models.Util.Enums;

namespace LizBrunner.App.ViewModels
{
    public class ClientViewModel
    {

        [Key]
        public Guid Id { get; set; }

        [DisplayName("Nome")]
        [Required(ErrorMessage = "O campo é obrigatório")]
        [StringLength(150, ErrorMessage = "Maximo de 150 caracteres")]
        public string Name { get; set; }

        [DisplayName("Nascimento")]
        [Required(ErrorMessage = "O campo é obrigatório")]
        public DateTime Birthdate { get; set; }
        
        [DisplayName("Genero")]
        [Required(ErrorMessage = "O campo é obrigatório")]
        public Genders Gender { get; set; }

        [DisplayName("CPF")]
        [Required(ErrorMessage = "O campo é obrigatório")]
        [RegularExpression("([0-9]+)")]
        public string CPF { get; set; }

        [DisplayName("Telefone")]
        [StringLength(20, ErrorMessage = "Maximo de 20 caracteres")]
        [RegularExpression("([0-9]+)")]
        [Required(ErrorMessage = "O campo é obrigatório")]
        public string Phone { get; set; }

        [DisplayName("E-mail")]
        [Required(ErrorMessage = "O campo é obrigatório")]
        public string Email { get; set; }

        [DisplayName("Receber Novidades?")]
        public bool IsReceivingInformation { get; set; } = false;

        [DisplayName("VIP?")]
        public bool IsVip { get; set; } = false;

        [ScaffoldColumn(false)]
        public DateTime RegisterDate { get; set; }
        [HiddenInput]
        public Guid AdressId { get; set; }

        /* RF Relation */
        public AdressViewModel Adress { get; set; }
    }
}
