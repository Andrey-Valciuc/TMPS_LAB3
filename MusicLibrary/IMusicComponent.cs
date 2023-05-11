using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary
{
     public interface IMusicComponent
     {
          void Add(IMusicComponent component);
          void Remove(IMusicComponent component);
          void Play();
     }
}
