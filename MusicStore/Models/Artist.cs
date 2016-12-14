using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//using System.ComponentModel.DataAnnotations;
namespace MusicStore.Models
{
    public class Artist
    {   //[Key]
        public virtual int ArtistId { get; set; }
        public virtual string ArtistName { get; set; }
    }
}