using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;
using System.Drawing;
using System.IO;
using System.Deployment.Application;

namespace OxyPlayer
{
    public class Song
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
        public string Path { get; set; }
        public bool enabled { get; set; }
    }

    enum SongsRow
    {
        Title, Artist, Album, Id
    }

    class Ldbc
    {
        static public void updataSongsTable()
        {
            DoingSth ds = new DoingSth("更新数据库", "更新数据库中...");
            ds.Show();
            int id = 1;
            string[] SupportedFormating = MusicSh.GetSupportedFormating();
            Floder[] folders = Ldbc.getAllMusicFloders();
            using (var ldb = new LiteDatabase("songs.db"))
            {
                ILiteCollection<Song> table = ldb.GetCollection<Song>("songs");
                table.DeleteAll();
                
                foreach (Floder folder in folders)
                {
                    if (folder.enabled == false) { continue; }
                    DirectoryInfo updir = new DirectoryInfo(folder.Path);
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
                        MusicSh.Delay(1);
                    }
                }
            }
            ds.Close();
        }  //更新歌曲信息数据库

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
                        i = table.Find(x => x.Id == int.Parse(key));
                        break;
                }

                if (i != null)
                    re = i.ToArray();
            }
            return re;
        }   //在歌曲信息数据库中检索(指定列)

        static public Song[] searchDBMerged(string key) //在歌曲信息数据库中检索(聚合搜索)
        {
            List<Song> re = new List<Song>();
            using (var ldb = new LiteDatabase("songs.db"))
            {
                ILiteCollection<Song> table = ldb.GetCollection<Song>("songs");
                List<Song> temp = new List<Song>();
                temp.AddRange(table.Find(x => x.Title.Contains(key)));
                temp.AddRange(table.Find(x => x.Album.Contains(key)));
                temp.AddRange(table.Find(x => x.Artist.Contains(key)));
                foreach (Song song in temp)
                {
                    if(re.FindIndex(new Predicate<Song>(x=>x.Id==song.Id))<0)
                    {
                        re.Add(song);
                    }
                }
            }
            return re.ToArray();
        }   //在歌曲信息数据库中检索

        static public int GetItemsCount()
        {
            int fileCount = -1;
            using (var ldb = new LiteDatabase("songs.db"))
            {
                ILiteCollection<Song> table = ldb.GetCollection<Song>("songs");
                fileCount = table.Count();
            }
            return fileCount;
        }   //获取歌曲信息数据库条目计数

        static public Song[] GetAllSongsInfo()
        {
            Song[] songTable; 
            using (var ldb = new LiteDatabase("songs.db"))
            {
                ILiteCollection<Song> table = ldb.GetCollection<Song>("songs");
                songTable= table.FindAll().ToArray();
            }
            return songTable;
        }   //获取歌曲信息数据库中全部歌曲信息

        static public void addMusicFlodersTable(string dir)
        {
            using (var ldb = new LiteDatabase("songs.db"))
            {
                ILiteCollection<Floder> table = ldb.GetCollection<Floder>("floders");
                Floder nf = new Floder { Path = dir, enabled = true };
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

        static public Floder[] getAllMusicFloders()
        {
            Floder[] fs=null;
            using (var ldb = new LiteDatabase("songs.db"))
            {
                ILiteCollection<Floder> table = ldb.GetCollection<Floder>("floders");
                fs = table.FindAll().ToArray();
            }
            return fs;
        }

        static public void setMusicFloderEnable(string dir,bool enabled)
        {
            using (var ldb = new LiteDatabase("songs.db"))
            {
                ILiteCollection<Floder> table = ldb.GetCollection<Floder>("floders");
                Floder floder = table.FindOne(x => x.Path == dir);
                floder.enabled = enabled;
                table.Update(floder);
            }
        }
    }
}

