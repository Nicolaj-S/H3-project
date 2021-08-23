using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace H3_project.Domain
{
    public class Actors : Super
    {
        public string Name { get; set; }
        [ForeignKey("Actor.Id")]
        public int ActorId { get; set; }
    }
}
