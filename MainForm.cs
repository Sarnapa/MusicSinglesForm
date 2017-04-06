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

        public MainForm()
        {
            
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SinglesForm form1 = new SinglesForm(model);
            form1.MdiParent = this;
            form1.Show();

            SinglesForm form2 = new SinglesForm(model);
            form2.MdiParent = this;
            form2.Show();

            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void addViewMenuItem_Click(object sender, EventArgs e)
        {
            SinglesForm form = new SinglesForm(model);
            form.MdiParent = this;
            form.Show();
        }

    }
}
