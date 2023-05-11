using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary
{
     public class MusicLibrary
     {
          private readonly List<Song> _songs = new List<Song>();

          public void AddSong(Song song)
          {
               _songs.Add(song);
          }

          public void RemoveSong(Song song)
          {
               _songs.Remove(song);
          }

          public void UpdateSong(Song song)
          {
               // Code to update the song
          }

          public List<Song> Search(string title, string artist, string album)
          {
               // Code to search for songs
               return new List<Song>();
          }

          public List<Song> GetAllSongs()
          {
               return _songs;
          }
     }

}
