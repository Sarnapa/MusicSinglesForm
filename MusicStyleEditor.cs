using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Design;
using System.Windows.Forms.Design;

namespace MusicSingles
{
    public class MusicStyleEditor : System.Drawing.Design.UITypeEditor
    {
        public override System.Drawing.Design.UITypeEditorEditStyle GetEditStyle(System.ComponentModel.ITypeDescriptorContext context)
        {
            return UITypeEditorEditStyle.DropDown;
        }

        public override object EditValue(System.ComponentModel.ITypeDescriptorContext context, 
            System.IServiceProvider provider, object value)
        {
            IWindowsFormsEditorService edSvc = (IWindowsFormsEditorService) provider.GetService(typeof(IWindowsFormsEditorService));
            if(edSvc != null)
            {
                MusicStyleControler musicStyleControler = new MusicStyleControler();
                edSvc.DropDownControl(musicStyleControler);
                return musicStyleControler.Style;
            }
            return value;
        }
    }
}
