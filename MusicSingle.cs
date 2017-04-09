using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum MusicStyle
{
    Rock,
    Pop,
    HipHop
}

namespace MusicSingles
{
    public class MusicSingle
    {
        /*private String name, author;
        private DateTime trackDate;
        private MusicStyle style;*/

        public String Title
        {
            get;
            set;
        }

        public String Author
        {
            get;
            set;
        }

        public DateTime TrackDate
        {
            get;
            set;
        }

        public MusicStyle Style
        {
            get;
            set;
        }

        public MusicSingle(String title, String author, DateTime trackDate)
        {
            Title = title;
            Author = author;
            TrackDate = trackDate;
        }

        public MusicSingle(String title, String author, DateTime trackDate, MusicStyle style)
        {
            Title = title;
            Author = author;
            TrackDate = trackDate;
            Style = style;
        }
    }
}
