using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.Windows.Media;
using System.IO;
using System.Runtime;
using Windows;
using Microsoft;
using Shell32;

namespace OxyPlayer
{
    struct Musicinfo
    {
        public string Title;
        public string TimeLength;
        public int TimeLength_Second;
        public string Artist;
        public string Album;
    }

    class MusicSh
    {
        static public Musicinfo GetMusicInfo(string MusicPath)
        {
            Musicinfo mi = new Musicinfo();
            string file = MusicPath;
            ShellClass sh = new ShellClass();
            Folder dir = sh.NameSpace(Path.GetDirectoryName(file));
            FolderItem item = dir.ParseName(Path.GetFileName(file));
            string Length = dir.GetDetailsOf(item, 27); // 获取歌曲时长。
            mi.TimeLength = Length;
            mi.TimeLength_Second = HHMMSS2Second(Length);
            if (dir.GetDetailsOf(item, 21) != "")
                mi.Title = dir.GetDetailsOf(item, 21);
            else
                mi.Title = dir.GetDetailsOf(item, 0);
            mi.Album = dir.GetDetailsOf(item, 14);
            mi.Artist = dir.GetDetailsOf(item, 13);
            return mi;
            
        }

        static public int HHMMSS2Second(String time)
        {
            int second = 0;
            string[] TimeSplited = time.Split(':');
            second += int.Parse(TimeSplited[0])*3600;
            second += int.Parse(TimeSplited[1]) * 60;
            second += int.Parse(TimeSplited[2]);
            return second;
        }

        static public string[] GetSupportedFormating()
        {
            StreamReader SFsr = new StreamReader("SupportedFormating.txt");
            string[] SupportedFormating = SFsr.ReadToEnd().Split(',', '\r');
            SFsr.Close();
            return SupportedFormating;
        }
        #region Seconds/TimeSpan To MM:SS
        static public string Second2MMSS(TimeSpan time)
        {
            string returning = "";
            returning += ((int)time.TotalMinutes).ToString("00");
            returning += ":";
            returning += (((int)time.TotalSeconds) % 60).ToString("00");
            return returning;
        }

        static public string Second2MMSS(int seconds)
        {
            string returning = "";
            returning += ((int)seconds / 60).ToString("00");
            returning += ":";
            returning += (seconds % 60).ToString("00");
            return returning;
        }
        #endregion
    }
}






/*
 * iCol 对应文件详细属性汇总

ID  => DETAIL-NAME

0   => Name

1   => Size     // MP3 文件大小

2   => Type

3   => Date modified

4   => Date created

5   => Date accessed

6   => Attributes

7   => Offline status

8   => Offline availability

9   => Perceived type

10  => Owner

11  => Kinds

12  => Date taken

13  => Artists   // MP3 歌手

14  => Album     // MP3 专辑

15  => Year

16  => Genre

17  => Conductors

18  => Tags

19  => Rating

20  => Authors

21  => Title     // MP3 歌曲名

22  => Subject

23  => Categories

24  => Comments

25  => Copyright

26  => #

27  => Length    // MP3 时长

28  => Bit rate

29  => Protected

30  => Camera model

31  => Dimensions

32  => Camera maker

33  => Company

34  => File description

35  => Program name

36  => Duration

37  => Is online

38  => Is recurring

39  => Location

40  => Optional attendee addresses

41  => Optional attendees

42  => Organizer address

43  => Organizer name

44  => Reminder time

45  => Required attendee addresses

46  => Required attendees

47  => Resources

48  => Free/busy status

49  => Total size

50  => Account name

51  => Computer

52  => Anniversary

53  => Assistant's name

54  => Assistant's phone

55  => Birthday

56  => Business address

57  => Business city

58  => Business country/region

59  => Business P.O. box

60  => Business postal code

61  => Business state or province

62  => Business street

63  => Business fax

64  => Business home page

65  => Business phone

66  => Callback number

67  => Car phone

68  => Children

69  => Company main phone

70  => Department

71  => E-mail Address

72  => E-mail2

73  => E-mail3

74  => E-mail list

75  => E-mail display name

76  => File as

77  => First name

78  => Full name

79  => Gender

80  => Given name

81  => Hobbies

82  => Home address

83  => Home city

84  => Home country/region

85  => Home P.O. box

86  => Home postal code
 */
