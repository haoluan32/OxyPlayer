using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace OxyPlayer_WPF
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        MusicPlayer musicplayer = new MusicPlayer();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            string[] SupportedFormating = MusicSh.GetSupportedFormating();
            if (OxySettings.Default.MusicFolderPath == "")
            {
                OxySettings.Default.MusicFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
                OxySettings.Default.Save();
            }
            DirectoryInfo ld = new DirectoryInfo(OxySettings.Default.MusicFolderPath);

            if (ld.GetFiles().Length == OxySettings.Default.FileCount)
                Ldbc.updataSongsTable(ld);

            foreach (Song songinfo in Ldbc.getAllMusic())
            {
                ListBoxItemWithInfo listboxitem = new ListBoxItemWithInfo();
                listboxitem.SongInfo = songinfo;
                listboxitem.Content = songinfo.Title + " - " + songinfo.Artist;
                
                listBox.Items.Add(listboxitem);
            }

            
        }

        private void listView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Song songinfo = ((ListBoxItemWithInfo)listBox.SelectedItem).SongInfo;
            musicplayer.Play(songinfo.Address);
            artist_album_textblock.Text = songinfo.Artist + " - " + songinfo.Album;
            music_title_textblock.Text = songinfo.Title;
        }

        private void image_MouseUp(object sender, MouseButtonEventArgs e)
        {
           
            
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
