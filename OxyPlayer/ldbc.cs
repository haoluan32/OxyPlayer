﻿using System;
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

    enum DBRow
    {
        Title,Artist,Album,Id
    }

    class Ldbc
    {
        static public void updatadb(DirectoryInfo updir)
        {
            int id = 1;
            string[] SupportedFormating = MusicSh.GetSupportedFormating();
            
            using (var ldb = new LiteDatabase("songs.db"))
            { 
                ILiteCollection<Song> table = ldb.GetCollection<Song>("songs");
                table.DeleteAll();
                FileInfo[] fi = updir.GetFiles();
                foreach(FileInfo afi in fi)
                {
                    if (Array.IndexOf(SupportedFormating, afi.Extension) == -1)
                        continue;

                    Musicinfo mi = MusicSh.GetMusicInfo(afi.FullName,false,false);
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
        }
        static public Song[] searchDB(DBRow row,string key)
        {
            Song[] re=null;
            using (var ldb = new LiteDatabase("songs.db"))
            {
                ILiteCollection<Song> table = ldb.GetCollection<Song>("songs");
                IEnumerable<Song> i=null;
                switch (row)
                {
                    case DBRow.Title:
                        i = table.Find(x => x.Title.Contains(key));
                        break;
                    case DBRow.Album:
                        i = table.Find(x => x.Album.Contains(key));
                        break;
                    case DBRow.Artist:
                        i = table.Find(x => x.Artist.Contains(key));
                        break;
                    case DBRow.Id:
                        i = table.Find(x => x.Artist.Contains(key));
                        break;
                }
                
                if(i!=null)
                    re = i.ToArray();
            }
                return re;
        }
    }
}
