using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicSingles
{

    public delegate void ChangedStyleEventHandler(object sender, EventArgs e);

    public partial class MusicStyleControler : UserControl
    {
        private MusicStyle style;
        private Image rockImage;
        private Image hipHopImage;
        private Image popImage;
        private event ChangedStyleEventHandler changed;

        [EditorAttribute(typeof(MusicStyleEditor),
        typeof(System.Drawing.Design.UITypeEditor))]
        [Category("MusicStyle control")]
        [BrowsableAttribute(true)]
        public MusicStyle Style
        {
            get { return style; }
            set 
            { 
                style = value;
                onChanged(null, EventArgs.Empty);
            }
        }

        public MusicStyleControler()
        {
            rockImage = MusicSingles.Properties.Resources.rock;
            hipHopImage = MusicSingles.Properties.Resources.hipHop;
            popImage = MusicSingles.Properties.Resources.pop;
            this.changed += new ChangedStyleEventHandler(onChanged);
            this.Click += new EventHandler(musicStyleControler_Click);
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Point startPoint = new Point(0,0);
            switch(style)
            {
                case MusicStyle.Rock:
                    e.Graphics.DrawImage(rockImage, startPoint);
                    break;
                case MusicStyle.HipHop:
                    e.Graphics.DrawImage(hipHopImage, startPoint);
                    break;
                case MusicStyle.Pop:
                    e.Graphics.DrawImage(popImage, startPoint);
                    break;
            }
        }

        private void musicStyleControler_Click(Object sender, EventArgs e)
        {
            switch (style)
            {
                case MusicStyle.Rock:
                    style = MusicStyle.HipHop;
                    break;
                case MusicStyle.HipHop:
                    style = MusicStyle.Pop;
                    break;
                case MusicStyle.Pop:
                    style = MusicStyle.Rock;
                    break;
            }
            onChanged(this, EventArgs.Empty);
        }

        private void onChanged(Object sender, EventArgs e)
        {
            this.Invalidate();
        }
    }
}
