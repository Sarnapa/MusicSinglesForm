using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicSingles
{
    public delegate void ChangedEventHandler(object sender, MyEventArgs e);
    
    public class MyEventArgs: EventArgs
    {
        private MusicSingle single;
        private bool newer;
        private bool changedGeneration;

        public MyEventArgs() { }

        public MyEventArgs(MusicSingle single)
        {
            this.single = single;
        }

        public MyEventArgs(MusicSingle single, bool newer, bool changedGeneration)
        {
            this.single = single;
            this.newer = newer;
            this.changedGeneration = changedGeneration;
        }
       
        public MusicSingle getSingle()
        {
            return single;
        }

        public bool getNewer()
        {
            return newer;
        }

        public bool getChangedGeneration()
        {
            return changedGeneration;
        }

    }

    public class SinglesList
    {
        private List<MusicSingle> singlesList;
        //event for changes associated with singlesList
        public event ChangedEventHandler added;
        public event ChangedEventHandler edited;
        public event ChangedEventHandler deleted;

        public List<MusicSingle> getSinglesList()
        {
            return singlesList;
        }

        public MusicSingle getLastSingle()
        {
            return singlesList[singlesList.Count - 1];
        }

        public SinglesList()
        {
            this.singlesList = new List<MusicSingle>();
            // for testing
            Random rnd = new Random();
            for(int i = 0; i < 5; ++i)
            {
                DateTime trackDate = new DateTime(rnd.Next(1995, 2015), rnd.Next(1, 13), rnd.Next(1, 29));
                singlesList.Add(new MusicSingle("Title " + i, "Author " + i, trackDate, MusicStyle.Pop));
            }
        }

        private void onAdded(MyEventArgs e)
        {
            if (added != null)
                added(this, e);
        }

        private void onEdited(MyEventArgs e)
        {
            if (edited != null)
                edited(this, e);
        }

        private void onDeleted(MyEventArgs e)
        {
            if (deleted != null)
                deleted(this, e);
        }
           
        public void addSingle(MusicSingle single)
        {
            singlesList.Add(single);
            onAdded(new MyEventArgs());
        }

        public void editSingle(MusicSingle single, String title, String author, DateTime trackDate, MusicStyle style)
        {
            single.Title = title;
            single.Author = author;
            DateTime oldDate = single.TrackDate;
            single.TrackDate = trackDate;
            single.Style = style;
            bool changedGeneration = isChangedGeneration(oldDate, trackDate);  
            onEdited(new MyEventArgs(single, isNewer(single), changedGeneration));
        }

        public void removeSingle(MusicSingle single)
        {
            int idx = singlesList.FindIndex(s => s.Title == single.Title &&
            s.Author == single.Author && s.TrackDate == single.TrackDate);
            if (idx != -1)
                singlesList.RemoveAt(idx);
            onDeleted(new MyEventArgs(single, isNewer(single), false));
        }

        private static bool isNewer(MusicSingle single)
        {
            return single.TrackDate.Year >= 2000;
        }

        private static bool isChangedGeneration(DateTime oldDate, DateTime newDate)
        {
            if(oldDate.Year >= 2000)
            {
                if (newDate.Year >= 2000)
                    return false;
                else
                    return true;
            }
            else
            {
                if (newDate.Year < 2000)
                    return false;
                else
                    return true;
            }
        }
    }
}
