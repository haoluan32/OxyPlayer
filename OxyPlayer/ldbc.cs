using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;
using System.Drawing;
using System.IO;

namespace OxyPlayer
{
    class Song
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Album { get; set; }
        public string Artist { get; set; }
        public string Address { get; set; }
    }
    class Floder
    {
        [BsonId]
        public int _id { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
    }

    enum SongsRow
    {
        Title, Artist, Album, Id
    }

    class Ldbc
    {
        static public void updataSongsTable(DirectoryInfo updir)
        {
            DoingSth ds = new DoingSth("更新数据库", "更新数据库中...");
            ds.Show();
            int id = 1;
            string[] SupportedFormating = MusicSh.GetSupportedFormating();

            using (var ldb = new LiteDatabase("songs.db"))
            {
                ILiteCollection<Song> table = ldb.GetCollection<Song>("songs");
                table.DeleteAll();
                FileInfo[] fi = updir.GetFiles();
                foreach (FileInfo afi in fi)
                {
                    if (Array.IndexOf(SupportedFormating, afi.Extension) == -1)
                        continue;

                    Musicinfo mi = MusicSh.GetMusicInfo(afi.FullName, false, false);
                    Song s = new Song
                    {
                        Id = id,
                        Title = mi.Title,
                        Album = mi.Album,
                        Artist = mi.Artist,
                        Address = afi.FullName
                    };
                    table.Insert(s);
                    id++;
                }
                OxySettings.Default.FileCount = (id - 1);
                OxySettings.Default.Save();
            }
            ds.Close();
        }

        static public Song[] searchDB(SongsRow row, string key)
        {
            Song[] re = null;
            using (var ldb = new LiteDatabase("songs.db"))
            {
                ILiteCollection<Song> table = ldb.GetCollection<Song>("songs");
                IEnumerable<Song> i = null;
                switch (row)
                {
                    case SongsRow.Title:
                        i = table.Find(x => x.Title.Contains(key));
                        break;
                    case SongsRow.Album:
                        i = table.Find(x => x.Album.Contains(key));
                        break;
                    case SongsRow.Artist:
                        i = table.Find(x => x.Artist.Contains(key));
                        break;
                    case SongsRow.Id:
                        i = table.Find(x => x.Artist.Contains(key));
                        break;
                }

                if (i != null)
                    re = i.ToArray();
            }
            return re;
        }

        static public void addMusicFlodersTable(string dir,string name)
        {
            using (var ldb = new LiteDatabase("songs.db"))
            {
                ILiteCollection<Floder> table = ldb.GetCollection<Floder>("floders");
                Floder nf = new Floder { Path = dir, Name = name };
                table.Insert(nf);
            }
        }

        static public void delMusicFlodersTable(string dir)
        {
            using (var ldb = new LiteDatabase("songs.db"))
            {
                ILiteCollection<Floder> table = ldb.GetCollection<Floder>("floders");
                table.Delete(table.FindOne(x => x.Path == dir)._id);
            }
        }

        static public string[] getAllMusicFloders()
        {
            List<string> list = new List<string>();
            using (var ldb = new LiteDatabase("songs.db"))
            {
                ILiteCollection<Floder> table = ldb.GetCollection<Floder>("floders");
                Floder[] fs = table.FindAll().ToArray();
                foreach (Floder f in fs)
                {
                    list.Add(f.Path);
                }

            }
            return list.ToArray();
        }
    }
}
