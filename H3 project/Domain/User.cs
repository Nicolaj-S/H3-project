using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace H3_project.Domain
{
    public class User : Super
    {
        public string Username { get; set; }
        public string UserPassword { get; set; }
        [ForeignKey("Ticket.TicketUserId")]
        public int UsersTicket { get; set; }
    }
}
