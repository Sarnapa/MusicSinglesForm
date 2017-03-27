using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicSingles
{
    public partial class SinglesForm : Form
    {
        private SinglesList model;
        private ListViewItem lastEditedItem = null;
        private Boolean newer;

        public SinglesForm(SinglesList model, Boolean newer)
        {
            this.model = model;
            this.newer = newer;
            model.added += new ChangedEventHandler(this.addedSingle);
            model.edited += new ChangedEventHandler(this.editedSingle);
            model.deleted += new ChangedEventHandler(this.deletedSingle);
            InitializeComponent();
        }

        public int getSinglesListViewCount()
        {
            return singlesListView.Items.Count;
        }

        private void addedSingle(object sender, EventArgs e)
        {
            MusicSingle lastSingle = model.getLastSingle();
            if ((newer && lastSingle.TrackDate.Year >= 2000) || (!newer && lastSingle.TrackDate.Year < 2000))
            {
                ListViewItem item = new ListViewItem();
                item.Tag = model.getLastSingle();
                updateItem(item);
                singlesListView.Items.Add(item);
            }
        }

        private void editedSingle(object sender, EventArgs e)
        {
            MusicSingle lastSingle = model.getLastSingle();
            if(lastEditedItem == null)
            {
                if ((newer && lastSingle.TrackDate.Year >= 2000) || (!newer && lastSingle.TrackDate.Year < 2000))
                {
                    ListViewItem item = new ListViewItem();
                    item.Tag = model.getLastSingle();
                    updateItem(item);
                    singlesListView.Items.Add(item);
                }
            }
            else
            {
                if ((newer && lastSingle.TrackDate.Year >= 2000) || (!newer && lastSingle.TrackDate.Year < 2000))
                {
                    updateItem(lastEditedItem);
                }
                else if ((newer && lastSingle.TrackDate.Year < 2000) || (!newer && lastSingle.TrackDate.Year >=2000))
                {
                    for(int i = 0; i < singlesListView.Items.Count; ++i)
                    {
                        if (ReferenceEquals(lastEditedItem, singlesListView.Items[i]))
                        {
                            singlesListView.Items[i].Remove();
                            break;
                        }
                    }
                }
            }
            lastEditedItem = null;
        }

        private void deletedSingle(object sender, EventArgs e)
        {
           if(singlesListView.SelectedItems.Count == 1)
           {
               singlesListView.SelectedItems[0].Remove();
           }
        }

        private void addSingleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEditForm dialogForm = new AddEditForm(null);
            if (dialogForm.ShowDialog() == DialogResult.OK)
            {
               MusicSingle newSingle = new MusicSingle(dialogForm.SingleTitle, dialogForm.SingleAuthor, dialogForm.SingleTrackDate, dialogForm.SingleStyle);
               model.addSingle(newSingle);
            }
        }

        private void editSingleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(singlesListView.SelectedItems.Count == 1)
            {
                MusicSingle single = (MusicSingle)singlesListView.SelectedItems[0].Tag;
                AddEditForm dialogForm = new AddEditForm(single);
                lastEditedItem = singlesListView.SelectedItems[0];
                if (dialogForm.ShowDialog() == DialogResult.OK)
                {
                    String title = dialogForm.SingleTitle;
                    String author = dialogForm.SingleAuthor;
                    DateTime trackDate = dialogForm.SingleTrackDate;
                    MusicStyle style = dialogForm.SingleStyle;
                    model.editSingle(single, title, author, trackDate, style);
                }
                else
                    lastEditedItem = null;
            }
        }

        private void deleteSingleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (singlesListView.SelectedItems.Count == 1)
            {
                MusicSingle single = (MusicSingle)singlesListView.SelectedItems[0].Tag;
                model.removeSingle(single);
            }
        }

        private void updateItem(ListViewItem item)
        {
            MusicSingle single = (MusicSingle)item.Tag;
            // 5 due to zeroColumn
            while (item.SubItems.Count < 5)
                item.SubItems.Add(new ListViewItem.ListViewSubItem());
            item.SubItems[1].Text = single.Title;
            item.SubItems[2].Text = single.Author;
            item.SubItems[3].Text = single.TrackDate.ToShortDateString();
            item.SubItems[4].Text = single.Style.ToString();

        }

        private void singlesForm_FormClosed(Object sender, FormClosedEventArgs e)
        {
        }

    }
}
