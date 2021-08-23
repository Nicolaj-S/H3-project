using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace H3_project.Domain
{
    public class Ticket : Super
    {
        [ForeignKey("Movie.Title")]
        public string TicketName { get; set; }
        public int TicketUserId { get; set; }
    }
}
