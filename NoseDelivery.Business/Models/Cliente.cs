using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace NoseDelivery.Business.Models
{

    public class Cliente : IdentityUser
    {
        public string Telefone { get; set; }
        public bool Status { get; set; }
        public string Localizacao { get; set; }

    }
}
