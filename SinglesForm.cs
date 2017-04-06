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
        private CheckBox lastSelectedCheckBox;

        public SinglesForm(SinglesList model)
        {
            this.model = model;
            model.added += new ChangedEventHandler(this.addedSingle);
            model.edited += new ChangedEventHandler(this.editedSingle);
            model.deleted += new ChangedEventHandler(this.deletedSingle);
            this.Activated += new System.EventHandler(singlesForm_Activated);
            this.Deactivate += new System.EventHandler(singlesForm_Deactivate);
            this.FormClosing += new FormClosingEventHandler(singlesForm_FormClosing);
            InitializeComponent();
        }

        private void singleForm_Load(object sender, EventArgs e)
        {
            allCheckBox.Checked = true;
            lastSelectedCheckBox = allCheckBox;
            singlesPrint(2);
        }

        // Methods for updating appropriate form

        private void addedSingle(object sender, MyEventArgs e)
        {
            MusicSingle lastSingle = model.getLastSingle();
            if (allCheckBox.Checked || (newerCheckBox.Checked && lastSingle.TrackDate.Year >= 2000) 
                || (olderCheckBox.Checked && lastSingle.TrackDate.Year < 2000))
            {
                ListViewItem item = new ListViewItem();
                item.Tag = model.getLastSingle();
                updateItem(item);
                singlesListView.Items.Add(item);
            }
        }

        private void editedSingle(object sender, MyEventArgs e)
        {
            MusicSingle single = e.getSingle();
            bool isNewerSingle = e.getNewer();
            bool isChangedGeneration = e.getChangedGeneration();
            if (allCheckBox.Checked)
            {
                updateItem(getItem(single));
            }
            else
            {
                if ((newerCheckBox.Checked && isNewerSingle)
                    || (olderCheckBox.Checked && !isNewerSingle))
                {
                    if(isChangedGeneration)
                    {
                        ListViewItem item = new ListViewItem();
                        item.Tag = single;
                        updateItem(item);
                        singlesListView.Items.Add(item);
                    }
                    else
                        updateItem(getItem(single));
                }
                else
                {
                   if(isChangedGeneration)
                   {
                       if ((newerCheckBox.Checked && !isNewerSingle)
                           || (olderCheckBox.Checked && isNewerSingle))
                       {
                           ListViewItem item = getItem(single);
                           item.Remove();
                       }
                    }
                }
            }            
        }

        private void deletedSingle(object sender, MyEventArgs e)
        {
            MusicSingle single = e.getSingle();
            bool isNewer = e.getNewer();
            if (allCheckBox.Checked || (newerCheckBox.Checked && isNewer) 
                || (olderCheckBox.Checked && !isNewer))
            {
                if (single != null)
                {
                    ListViewItem item = getItem(single);
                    getItem(single).Remove();
                }
            }
        }

        private ListViewItem getItem(MusicSingle single)
        {
            foreach(ListViewItem item in singlesListView.Items)
            {
                if (ReferenceEquals(single, item.Tag))
                    return item;
            }
            return null;
        }

        //EventHandler for proper button click

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
                if (dialogForm.ShowDialog() == DialogResult.OK)
                {
                    String title = dialogForm.SingleTitle;
                    String author = dialogForm.SingleAuthor;
                    DateTime trackDate = dialogForm.SingleTrackDate;
                    MusicStyle style = dialogForm.SingleStyle;
                    model.editSingle(single, title, author, trackDate, style);
                }
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

        //To update item in ListView

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

        //To update labelText in statusStrip in mdiParent
     
        private void singlesForm_Activated(object sender, EventArgs e)
        {
           singlesCountStatusLabel.Text = "Liczba elementów: " + singlesListView.Items.Count;
           this.MdiParent.Controls.Add(singlesCountStrip);
        }

        private void singlesForm_Deactivate(object sender, EventArgs e)
        {
            this.MdiParent.Controls.Remove(singlesCountStrip);
        }

        private void checkBox_Click(object sender, EventArgs e)
        {
            if (!ReferenceEquals(sender, lastSelectedCheckBox))
            {
                lastSelectedCheckBox.Checked = false;
                if (ReferenceEquals(sender, newerCheckBox))
                    singlesPrint(1);
                else if (ReferenceEquals(sender, olderCheckBox))
                    singlesPrint(0);
                else
                    singlesPrint(2);
            }
            else if (ReferenceEquals(sender, lastSelectedCheckBox))
                lastSelectedCheckBox.Checked = true;
            lastSelectedCheckBox = (CheckBox)sender;
        }

        private void singlesPrint(int option)
        {
            singlesListView.Items.Clear();
            switch(option)
            {
                case 0:
                    foreach(MusicSingle single in model.getSinglesList())
                        if(single.TrackDate.Year < 2000)
                        {
                            ListViewItem item = new ListViewItem();
                            item.Tag = single;
                            updateItem(item);
                            singlesListView.Items.Add(item);
                        }
                    break;
                case 1:
                    foreach (MusicSingle single in model.getSinglesList())
                        if (single.TrackDate.Year >= 2000)
                        {
                            ListViewItem item = new ListViewItem();
                            item.Tag = single;
                            updateItem(item);
                            singlesListView.Items.Add(item);
                        }
                    break;
                case 2:
                    foreach (MusicSingle single in model.getSinglesList())
                    {
                        ListViewItem item = new ListViewItem();
                        item.Tag = single;
                        updateItem(item);
                        singlesListView.Items.Add(item);
                    }
                    break;
            }
        }
        
        private void singlesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason != CloseReason.MdiFormClosing)
            {
                if (this.MdiParent.MdiChildren.Length == 1)
                {
                    e.Cancel = true;
                    MessageBox.Show("One child form must remain.");
                }
                else
                {
                    e.Cancel = false;
                }
            }
        }
    }

}
