# TMPS_LAB3

# Structural design patterns:
Modelele structurale explică modul de asamblare a obiectelor și claselor în structuri mai mari, menținând în același timp aceste structuri flexibile și eficiente. În cadrul acestui proiect au fost implementate următoarele modele:

1. Decorator
2. Facade
3. Composite
4. Proxy

# 1. Decorator
Decorator este un model structural care permite adăugarea unei funcționalități noi la un obiect dinamic, fără a modifica structura originală a acestuia. În secvența de mai jos, folosim modelul Decorator pentru a adăuga un comportament nou la un obiect Song, fără a modifica comportamentul original. Acest lucru se realizează prin crearea unei clase SongDecorator care învelește un obiect Song și adaugă o funcționalitate nouă acestuia.

```
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
     }
```
# 2. Facade
 Facade este un model structural care oferă o interfață simplificată pentru un sistem complex. În cod, folosim modelul Facade pentru a oferi o interfață simplă utilizatorului pentru a interacționa cu sistemul bibliotecii de muzică. Acest lucru se realizează prin crearea unei clase MusicLibrary care încapsulează complexitatea sistemului și expune o interfață simplă pentru utilizator.
 
```
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
      }
```
# 3. Composite
Composite este un model structural care permite compunerea obiectelor în structuri arborescente și apoi lucrul cu aceste structuri ca și cum ar fi obiecte individuale. În acest cod, clasa Playlist și clasa Song implementează interfața IMusicComponent, care definește comportamentul unui component de muzică. Clasa Playlist utilizează o listă de obiecte IMusicComponent pentru a stoca componentele sale și oferă metode pentru a adăuga, elimina și reda aceste componente.
```
public interface IMusicComponent
{
     void Add(IMusicComponent component);
     void Remove(IMusicComponent component);
     void Play();
}

public class Song : IMusicComponent
{
     // Song properties and methods
     // ...

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
```
# 4. Proxy
Proxy este un model structural care permite crearea unui obiect intermediar care acționează ca un substitut pentru alt obiect. În secvența de cod de mai jos, folosim modelul Proxy pentru a crea un obiect MusicLibraryProxy care acționează ca un substitut pentru obiectul MusicLibrary. Acest lucru ne permite să adăugăm verificarea autorizării pentru utilizator înainte de a permite adăugarea, ștergerea sau actualizarea cântecelor în biblioteca de muzică.
```
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
       }  
```
