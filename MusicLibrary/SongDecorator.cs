using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary
{
     public abstract class SongDecorator : Song
     {
          protected Song _song;

          public SongDecorator(Song song)
          {
               _song = song;
          }

          public override string Title
          {
               get => _song.Title;
               set => _song.Title = value;
          }

          public override string Artist
          {
               get => _song.Artist;
               set => _song.Artist = value;
          }

          public override string Album
          {
               get => _song.Album;
               set => _song.Album = value;
          }

          public override int Year
          {
               get => _song.Year;
               set => _song.Year = value;
          }

          public abstract double Rating { get; set; }
     }

     public class SongWithRating : SongDecorator
     {
          private double _rating;

          public SongWithRating(Song song) : base(song)
          {
          }

          public override double Rating
          {
               get => _rating;
               set => _rating = value;
          }
     }

}
