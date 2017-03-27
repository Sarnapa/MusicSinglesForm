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
    public partial class MainForm : Form
    {
        private SinglesList model = new SinglesList();
        private SinglesForm form1, form2;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            form1 = new SinglesForm(model, false);
            form1.MdiParent = this;
            //form1.Activated += new System.EventHandler(singlesForms_Activated);
            form1.Show();

            form2 = new SinglesForm(model, true);
            form2.MdiParent = this;
            //form2.Activated += new System.EventHandler(singlesForms_Activated);
            form2.Show();

            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void singlesForms_Activated(object sender, EventArgs e)
        {
            if (sender == form1)
                statusStripLabel.Text = "Liczba elementów: " + form1.getSinglesListViewCount();
            else if (sender == form2)
                statusStripLabel.Text = "Liczba elementów: " + form2.getSinglesListViewCount();
        }

    }
}
