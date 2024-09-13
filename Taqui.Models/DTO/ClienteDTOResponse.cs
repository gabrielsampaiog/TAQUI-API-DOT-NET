using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taqui.Models.DTO
{
    public class ClienteDTOResponse
    {
        //DTO criado excluindo a senha e o CPF por conta da sensibilidade dos dados.
        public int IdUsuario { get; set; }

        public string DsUser { get; set; }

        public string DsEmail { get; set; }
    }
}
