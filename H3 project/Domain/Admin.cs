using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace H3_project.Domain
{
    public class Admin : Super
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public bool AdminUser { get; set; }
    }
}
