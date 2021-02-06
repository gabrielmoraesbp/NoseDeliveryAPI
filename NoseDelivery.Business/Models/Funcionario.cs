using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace NoseDelivery.Business.Models
{
    public class Funcionario : IdentityUser
    {
        public string Cargo { get; set; }
        public string PapelDoCargo { get; set; }
        public bool Status { get; set; }
    }
}
