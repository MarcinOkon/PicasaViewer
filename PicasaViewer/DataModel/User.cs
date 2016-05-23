using PicasaAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PicasaViewer.DataModel
{
    public class User
    {
        public List<Album> Albums { get; set; }

        public User(string name)
        {
            Name = name;
            Albums = GetAlbums();
        }

        public string Name { get; set; }

        private List<Album> GetAlbums()
        {
            var albums = new List<Album>();
            var entries = RequestManager.GetAlbums(Name);
            foreach (var entry in entries)
            {
                albums.Add(new Album(entry));
            }

            return albums;
        }
    }
}
