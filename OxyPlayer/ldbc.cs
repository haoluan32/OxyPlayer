using LiteDB;
using System;
using System.Collections.Generic;
using System.Deployment.Application;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OxyPlayer
{
    public class Song
    {
        [BsonId]
        public int _id { get; set; }
        public int Number { get; set; }
        public string Title { get; set; }
        public string Album { get; set; }
        public string Artist { get; set; }
        public string Address { get; set; }
        public bool Exist { get; set; }
    }
    class Floder
    {
     
        public string Path { get; set; }
        public bool enabled { get; set; }
    }

    enum SongsRow
    {
        Title, Artist, Album, Id
    }

    class Ldbc
    {

        static private bool DBLock = false;
        static private void WaitForUnlock()
        {
            while (DBLock)
                Delay(25);
        }
        static public void updataSongsTable()//更新歌曲信息数据库
        {
            
            string[] SupportedFormating = MusicSh.GetSupportedFormating();
            Floder[] folders = Ldbc.getAllMusicFloders();
            WaitForUnlock();
            DBLock = true;
            using (var ldb = new LiteDatabase("songs.db"))
            {
                ILiteCollection<Song> table = ldb.GetCollection<Song>("songs");
                List<string> addresses = new List<string>();
                Song[] songTable = table.FindAll().ToArray();

                foreach (var song in songTable)
                {
                    song.Exist = false;
                    addresses.Add(song.Address);
                    table.Update(song);
                    
                }
                foreach (Floder folder in folders)
                {
                    if (folder.enabled == false) { continue; }
                    DirectoryInfo updir = new DirectoryInfo(folder.Path);
                    FileInfo[] fi = updir.GetFiles();
                    foreach (FileInfo afi in fi)
                    {
                        if (Array.IndexOf(SupportedFormating, afi.Extension) == -1)
                            continue;
                        if (addresses.IndexOf(afi.FullName) > -1)
                        {
                            Song s = table.FindOne(x => x.Address == afi.FullName);
                            s.Exist = true;
                            table.Update(s);
                            continue;
                        }

                        Song song = MusicSh.GetSongInfo(afi.FullName);
                        song.Exist = true;
                        table.Insert(song);                            
                    }
                }            
                table.DeleteMany(x => x.Exist == false);
                songTable = table.FindAll().ToArray();
                int id = 1;
                foreach (var song in songTable)
                {
                    song.Number = id;
                    table.Update(song);
                    id++;
                }
            }
            DBLock = false;
        }

        #region update_Async
        public static Task UpdateSongsTableAsync(CancellationToken ct = default)
        {
            var tcs = new TaskCompletionSource<object>();

            // 创建并启动一个 STA 线程
            var thread = new Thread(() =>
            {
                try
                {
                    // 在这里执行你的同步逻辑，其中包含 Shell32 调用
                    DoUpdateSongsTable(ct);
                    tcs.SetResult(null);
                }
                catch (OperationCanceledException)
                {
                    tcs.SetCanceled();
                }
                catch (Exception ex)
                {
                    tcs.SetException(ex);
                }
            });

            thread.SetApartmentState(ApartmentState.STA); // 关键：设置为 STA
            thread.IsBackground = true; // 设为后台线程，不阻止程序退出
            thread.Start();

            return tcs.Task;
        }

        private static void DoUpdateSongsTable(CancellationToken ct)
        {
            string[] supportedFormating = MusicSh.GetSupportedFormating();
            Floder[] folders = Ldbc.getAllMusicFloders();

            while (DBLock)
            {
                ct.ThrowIfCancellationRequested();
                Delay(25);
            }

            DBLock = true;
            using (var ldb = new LiteDatabase("songs.db"))
            {
                ILiteCollection<Song> table = ldb.GetCollection<Song>("songs");
                List<string> addresses = new List<string>();
                Song[] songTable = table.FindAll().ToArray();

                // 先将所有已有记录标记为不存在
                foreach (var song in songTable)
                {
                    ct.ThrowIfCancellationRequested();
                    song.Exist = false;
                    addresses.Add(song.Address);
                    table.Update(song);
                }

                foreach (Floder folder in folders)
                {
                    ct.ThrowIfCancellationRequested();
                    if (!folder.enabled) continue;

                    var updir = new DirectoryInfo(folder.Path);
                    foreach (FileInfo afi in updir.EnumerateFiles())
                    {
                        ct.ThrowIfCancellationRequested();
                        if (Array.IndexOf(supportedFormating, afi.Extension) == -1)
                            continue;

                        if (addresses.IndexOf(afi.FullName) > -1)
                        {
                            Song s = table.FindOne(x => x.Address == afi.FullName);
                            if (s != null)
                            {
                                s.Exist = true;
                                table.Update(s);
                            }
                            continue;
                        }

                        Song song = MusicSh.GetSongInfo(afi.FullName); // 此处包含 Shell32 调用
                        song.Exist = true;
                        table.Insert(song);
                    }
                }

                // 删除磁盘上已不存在的记录
                table.DeleteMany(x => x.Exist == false);

                // 重新编号
                songTable = table.FindAll().ToArray();
                int id = 1;
                foreach (var song in songTable)
                {
                    ct.ThrowIfCancellationRequested();
                    song.Number = id;
                    table.Update(song);
                    id++;
                }
            }
            DBLock = false;
        }
        #endregion

        static public void DeleteSongsTable()
        {
            WaitForUnlock();
            DBLock = true;
            using (var ldb = new LiteDatabase("songs.db"))
            {
                ILiteCollection<Song> table = ldb.GetCollection<Song>("songs");
                table.DeleteAll();
            }
            DBLock = false;
        }

        static public Song[] searchDB(SongsRow row, string key)
        {
            Song[] re = null;
            WaitForUnlock();
            DBLock = true;
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
                        i = table.Find(x => x.Number == int.Parse(key));
                        break;
                }

                if (i != null)
                    re = i.ToArray();
            }
            DBLock=false;
            return re;
        }   //在歌曲信息数据库中检索(指定列)

        static public Song[] searchDBMerged(string key) //在歌曲信息数据库中检索(聚合搜索)
        {
            List<Song> re = new List<Song>();
            WaitForUnlock();
            DBLock = true;
            using (var ldb = new LiteDatabase("songs.db"))
            {
                ILiteCollection<Song> table = ldb.GetCollection<Song>("songs");
                List<Song> temp = new List<Song>();
                temp.AddRange(table.Find(x => x.Title.Contains(key)));
                temp.AddRange(table.Find(x => x.Album.Contains(key)));
                temp.AddRange(table.Find(x => x.Artist.Contains(key)));
                foreach (Song song in temp)
                {
                    if(re.FindIndex(new Predicate<Song>(x=>x.Number==song.Number))<0)
                    {
                        re.Add(song);
                    }
                }
            }
            DBLock = false;
            return re.ToArray();
        }   //在歌曲信息数据库中检索

        static public int GetItemsCount()
        {
            int fileCount = -1;
            WaitForUnlock();
            DBLock=true;
            using (var ldb = new LiteDatabase("songs.db"))
            {
                ILiteCollection<Song> table = ldb.GetCollection<Song>("songs");
                fileCount = table.Count();
            }
            DBLock=false;
            return fileCount;
        }   //获取歌曲信息数据库条目计数

        static public Song[] GetAllSongsInfo()
        {
            Song[] songTable;
            WaitForUnlock();
            DBLock = true;
            using (var ldb = new LiteDatabase("songs.db"))
            {
                ILiteCollection<Song> table = ldb.GetCollection<Song>("songs");
                songTable= table.FindAll().ToArray();
            }
            DBLock = false;
            return songTable;
        }   //获取歌曲信息数据库中全部歌曲信息

        static public void addMusicFlodersTable(string dir)
        {
            WaitForUnlock();
            DBLock = true;
            using (var ldb = new LiteDatabase("songs.db"))
            {
                ILiteCollection<Floder> table = ldb.GetCollection<Floder>("floders");
                Floder nf = new Floder { Path = dir, enabled = true };
                table.Insert(nf);
            }
            DBLock=false;
        }

        static public void delMusicFlodersTable(string dir)
        {
            WaitForUnlock();
            DBLock = true;
            using (var ldb = new LiteDatabase("songs.db"))
            {
                ILiteCollection<Floder> table = ldb.GetCollection<Floder>("floders");
                table.DeleteMany(x => x.Path == dir);
            }
            DBLock = false;
        }

        static public Floder[] getAllMusicFloders()
        {
            Floder[] fs=null;
            WaitForUnlock();
            DBLock = true;
            using (var ldb = new LiteDatabase("songs.db"))
            {
                ILiteCollection<Floder> table = ldb.GetCollection<Floder>("floders");
                fs = table.FindAll().ToArray();
            }
            DBLock = false;
            return fs;
        }

        static public void setMusicFloderEnable(string dir,bool enabled)
        {
            WaitForUnlock();
            DBLock = true;
            using (var ldb = new LiteDatabase("songs.db"))
            {
                ILiteCollection<Floder> table = ldb.GetCollection<Floder>("floders");
                Floder floder = table.FindOne(x => x.Path == dir);
                floder.enabled = enabled;
                table.Update(floder);
            }
            DBLock = false;
        }

        [DllImport("kernel32.dll")]
        public static extern uint GetTickCount();
        static private void Delay(uint ms)
        {
            uint start = GetTickCount();
            while (GetTickCount() - start < ms)
            {
                System.Windows.Forms.Application.DoEvents();
            }
        }
    }
}

