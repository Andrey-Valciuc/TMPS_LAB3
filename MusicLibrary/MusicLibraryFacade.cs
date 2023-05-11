using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary
{
     public class MusicLibraryFacade
     {
          private readonly MusicLibrary _musicLibrary;
          public MusicLibraryFacade(MusicLibrary musicLibrary)
          {
               _musicLibrary = musicLibrary;
          }

          public void AddSong(Song song)
          {
               _musicLibrary.AddSong(song);
          }

          public void RemoveSong(Song song)
          {
               _musicLibrary.RemoveSong(song);
          }

          public void UpdateSong(Song song)
          {
               _musicLibrary.UpdateSong(song);
          }

          public List<Song> Search(string title, string artist, string album)
          {
               return _musicLibrary.Search(title, artist, album);
          }

          public List<Song> GetAllSongs()
          {
               return _musicLibrary.GetAllSongs();
          }

          public void Play(Song song)
          {
               // Code to play the song
          }
     }
}
