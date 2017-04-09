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
    public class BaseSinglesForm : Form
    {
        protected SinglesList model;

        protected void addSingleToModel(String singleTitle, String singleAuthor, DateTime singleTrackDate, MusicStyle singleStyle)
        {
            MusicSingle newSingle = new MusicSingle(singleTitle, singleAuthor, singleTrackDate, singleStyle);
            model.addSingle(newSingle);
        }

        protected void editSingleInModel(MusicSingle single, String singleTitle, String singleAuthor, DateTime singleTrackDate, MusicStyle singleStyle)
        {
            model.editSingle(single, singleTitle, singleAuthor, singleTrackDate, singleStyle);
        }

        protected void removeSingleInModel(MusicSingle single)
        {
            model.removeSingle(single);
        }
    }
}
