using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taqui.Models.DTO
{
    public class ClienteDTORequest
    {
        //DTO criado excluindo o ID por ser um campo auto gerado.

        [MinLength(20, ErrorMessage = "O nome do usuário deve conter no minimo 20 caracteres.")]
        [MaxLength(200, ErrorMessage = "O nome do usuário deve conter no máximo 200 caracteres.")]
        [Required(ErrorMessage = "O nome do usuário é obrigatório.")]
        public string DsUser { get; set; }

        [MinLength(20, ErrorMessage = "A senha deve conter no minimo 20 caracteres.")]
        [MaxLength(100, ErrorMessage = "A senha deve conter no máximo 100 caracteres.")]
        [Required(ErrorMessage = "A senha é obrigatória.")]
        public string DsSenha { get; set; }

        [MinLength(20, ErrorMessage = "O email deve conter no minimo 20 caracteres.")]
        [MaxLength(100, ErrorMessage = "O email deve conter no máximo 200 caracteres.")]
        [EmailAddress]
        [Required(ErrorMessage = "O email é obrigatório.")]
        public string DsEmail { get; set; }

        [RegularExpression("^[0-9]{11}$", ErrorMessage = "O CPF deve conter exatamente 11 dígitos numéricos.")]
        [Required(ErrorMessage = "O CPF é obrigatório.")]
        public string DsCPF { get; set; }
    }
}
