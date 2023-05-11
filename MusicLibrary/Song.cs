using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary
{
     public class Song : IMusicComponent
     {
          public virtual string Title { get; set; }
          public virtual string Artist { get; set; }
          public virtual string Album { get; set; }
          public virtual TimeSpan Duration { get; set; }
          public virtual int Year { get; set; }

          public void Add(IMusicComponent component)
          {
               throw new NotSupportedException("Cannot add a component to a Song");
          }

          public void Remove(IMusicComponent component)
          {
               throw new NotSupportedException("Cannot remove a component from a Song");
          }

          public void Play()
          {
               // Code to play the song
          }
     }

}
