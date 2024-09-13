using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taqui.Models
{
    public class ClienteDTORequest
    {

        public string DsUser { get; set; }

        public string DsSenha { get; set; }

        public string DsEmail { get; set; }

        public string DsCPF { get; set; }
    }
}
