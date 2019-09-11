using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GrinWebApp.Models
{
    public class Member
    {
        public int Id { get; set; }
        public string Login { get; set; }
        [Display(Name = "Number")]
        public string Password { get; set; }
        public string Permission { get; set; }
    }
}
