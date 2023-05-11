using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary
{
     public class Playlist : IMusicComponent
     {
          private readonly List<IMusicComponent> _components = new List<IMusicComponent>();

          public void Add(IMusicComponent component)
          {
               _components.Add(component);
          }

          public void Remove(IMusicComponent component)
          {
               _components.Remove(component);
          }

          public void Play()
          {
               foreach (var component in _components)
               {
                    component.Play();
               }
          }
     }
}
