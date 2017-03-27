using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicSingles
{
    public delegate void ChangedEventHandler(object sender, EventArgs e);

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
        }

        private void onAdded(EventArgs e)
        {
            if (added != null)
                added(this, e);
        }

        private void onEdited(EventArgs e)
        {
            if (edited != null)
                edited(this, e);
        }

        private void onDeleted(EventArgs e)
        {
            if (deleted != null)
                deleted(this, e);
        }
           
        public void addSingle(MusicSingle single)
        {
            singlesList.Add(single);
            onAdded(EventArgs.Empty);
        }

        public void editSingle(MusicSingle single, String title, String author, DateTime trackDate, MusicStyle style)
        {
            /*int idx = singlesList.IndexOf(single);
            if(idx != -1)
                singlesList[idx] = single;*/
            single.Title = title;
            single.Author = author;
            single.TrackDate = trackDate;
            single.Style = style;
            int idx = singlesList.IndexOf(single);
            //To possess last edited single on last index
            mySwap(idx, singlesList.Count - 1);
            onEdited(EventArgs.Empty);
        }

        public void removeSingle(MusicSingle single)
        {
            int idx = singlesList.FindIndex(s => s.Title == single.Title &&
                      s.Author == single.Author && s.TrackDate == single.TrackDate);
            if (idx != -1)
                singlesList.RemoveAt(idx);
            onDeleted(EventArgs.Empty);
        }

        private void mySwap(int index1, int index2)
        {
            MusicSingle temp = singlesList[index1];
            singlesList[index1] = singlesList[index2];
            singlesList[index2] = temp;
        }
        
    }
}
