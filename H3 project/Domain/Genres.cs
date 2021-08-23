using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace H3_project.Domain
{
    public class Genres : Super
    {
        public string GenreTypes { get; set; }
        [ForeignKey("Genre.id")]
        public int GenreId { get; set; }
    }
}
