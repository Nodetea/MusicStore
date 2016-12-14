using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//using System.ComponentModel.DataAnnotations;
namespace MusicStore.Models
{
    public class Genre
    {   //[Key]
        public virtual int GenreId { get; set; }
        public virtual string GenreName { get; set; }
        public virtual string Description { get; set; }
        public virtual List<Album> Albums { get; set; }
    }
}