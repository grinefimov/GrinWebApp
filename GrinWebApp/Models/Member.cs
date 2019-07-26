using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrinWebApp.Models
{
    public class Member
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Permission { get; set; }
    }
}
