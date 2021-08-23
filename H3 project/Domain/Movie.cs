using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace H3_project.Domain
{
    public class Movie : Super
    {
        public string Title { get; set; }
        public DateTime Published { get; set; }
        [ForeignKey("Instructor.Id")]
        public string InstructorName { get; set; }
        [ForeignKey("Actors.ActorId")]
        public string ActorsInMovie { get; set; }
        [ForeignKey("Genres.GenreId")]
        public string GenresType { get; set; }
        [ForeignKey("Playtime.Id")]
        public int PlaytimeId { get; set; }
        [ForeignKey("Rating.Id")]
        public int RatingId { get; set; }
        public int Ticket { get; set; }

    }
}
