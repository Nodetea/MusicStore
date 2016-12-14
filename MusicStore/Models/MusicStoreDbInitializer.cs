using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace MusicStore.Models
{
    public class MusicStoreDbInitializer:DropCreateDatabaseAlways<MusicStoreContext>
    {
        protected override void Seed(MusicStoreContext context) {
            context.Artists.Add( new Artist { ArtistName = "Al Di Meola" });
            context.Genres.Add(new Genre { GenreName = "Jazz" });
            context.Albums.Add(new Album { Artist = new Artist { ArtistName = "Rush" },Genre = new Genre { GenreName = "Rock" },Price = 9.99m,Title = "Caravan" });
            context.Artists.Add(new Artist { ArtistName = "Mono" });
            context.Genres.Add(new Genre { GenreName = "Blue" });
            context.Albums.Add(new Album { Artist = new Artist { ArtistName = "Bush" },Genre = new Genre { GenreName = "violine" },Price = 4.76m,Title = "Mono12" });
            base.Seed(context);
        }
    }
}