using System.Collections.Generic;

namespace MusicLibrary
{
     public class MusicLibraryProxy
     {
          private readonly MusicLibrary _musicLibrary;
          private readonly IUser _user;

          public MusicLibraryProxy(MusicLibrary musicLibrary, IUser user)
          {
               _musicLibrary = musicLibrary;
               _user = user;
          }

          public void AddSong(Song song)
          {
               if (_user.IsAuthorized)
               {
                    _musicLibrary.AddSong(song);
               }
          }

          public void RemoveSong(Song song)
          {
               if (_user.IsAuthorized)
               {
                    _musicLibrary.RemoveSong(song);
               }
          }

          public void UpdateSong(Song song)
          {
               if (_user.IsAuthorized)
               {
                    _musicLibrary.UpdateSong(song);
               }
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
