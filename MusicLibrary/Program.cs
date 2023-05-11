using System;
using MusicLibrary;


namespace MusicLibrary
{
     class Program
     {
          static void Main(string[] args)
          {
               IUser user = new User { IsAuthorized = true };
               MusicLibrary musicLibrary = new MusicLibrary();
               MusicLibraryProxy musicLibraryProxy = new MusicLibraryProxy(musicLibrary, user);

               Song song1 = new Song { Title = "Bohemian Rhapsody", Artist = "Queen", Album = "A Night at the Opera", Duration = TimeSpan.FromSeconds(5.55) };
               Song song2 = new Song { Title = "Stairway to Heaven", Artist = "Led Zeppelin", Album = "Led Zeppelin IV", Duration = TimeSpan.FromSeconds(8.03) };
               Song song3 = new Song { Title = "November Rain", Artist = "Guns N' Roses", Album = "Use Your Illusion I", Duration = TimeSpan.FromSeconds(8.57) };


               musicLibraryProxy.AddSong(song1);
               musicLibraryProxy.AddSong(song2);
               musicLibraryProxy.AddSong(song3);

               Console.WriteLine("All songs:");
               var songs = musicLibraryProxy.GetAllSongs();
               foreach (var song in songs)
               {
                    Console.WriteLine(song.Title + " - " + song.Artist + " - " + song.Album);
               }

               Console.WriteLine("\nSearch results for 'heaven':");
               songs = musicLibraryProxy.Search(null, null, "heaven");
               foreach (var song in songs)
               {
                    Console.WriteLine(song.Title + " - " + song.Artist + " - " + song.Album);
               }

               Console.ReadKey();
          }
     }
}