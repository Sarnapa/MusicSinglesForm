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
    public partial class AddEditForm : Form
    {
        private MusicSingle single;

        public String SingleTitle
        {
            get { return titleTextBox.Text; }
        }

        public String SingleAuthor
        {
            get { return authorTextBox.Text; }
        }

        public DateTime SingleTrackDate
        {
            get { return dateTimePicker.Value; }
        }

        public MusicStyle SingleStyle
        {
            get {
                try
                {
                    return (MusicStyle)Enum.Parse(typeof(MusicStyle), styleTextBox.Text);
                }
                catch (ArgumentException ex)
                {
                    return MusicStyle.Pop;
                }
            }
        }
        
        public AddEditForm(MusicSingle single)
        {
            this.single = single;
            InitializeComponent();
        }

        private void addEditForm_Load(object sender, EventArgs e)
        {
            if(single != null)
            {
                this.titleTextBox.Text = single.Title;
                this.authorTextBox.Text = single.Author;
                this.dateTimePicker.Value = single.TrackDate;
                this.styleTextBox.Text = single.Style.ToString();
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
                DialogResult = DialogResult.OK;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {

        }

    }
}
