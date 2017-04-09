using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            get { return myMusicStyleControler.Style; }
        }
        
        public AddEditForm(MusicSingle single)
        {
            this.single = single;
            this.Load += new System.EventHandler(addEditForm_Load);
            InitializeComponent();
        }

        private void addEditForm_Load(object sender, EventArgs e)
        {
            if(single != null)
            {
                this.titleTextBox.Text = single.Title;
                this.authorTextBox.Text = single.Author;
                this.dateTimePicker.Value = single.TrackDate;
                this.myMusicStyleControler.Style = single.Style;
            }
            this.titleTextBox.Validating += new CancelEventHandler(titleTextBox_Validating);
            this.authorTextBox.Validating += new CancelEventHandler(authorTextBox_Validating);
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
                DialogResult = DialogResult.OK;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {

        }

        //to validate inserting text in textBoxes
        private void titleTextBox_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex("[<^>^,^;]");
            MatchCollection matches = regex.Matches(titleTextBox.Text);
            if(matches.Count > 0)
            {
                e.Cancel = true;
                titleErrorProvider.SetError(titleTextBox, "Wprowadzono nieprawidłowe znaki");
            }
            else
            {
                titleErrorProvider.Clear();
            }
        }

        private void authorTextBox_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex("[<^>^,^;]");
            MatchCollection matches = regex.Matches(authorTextBox.Text);
            if (matches.Count > 0)
            {
                e.Cancel = true;
                authorErrorProvider.SetError(authorTextBox, "Wprowadzono nieprawidłowe znaki");
            }
            else
            {
                authorErrorProvider.Clear();
            }
        }

    }   
}
