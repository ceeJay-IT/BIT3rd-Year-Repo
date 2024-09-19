using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDIFormsApplication_Pellosis_BIT31.ChildFormWindow
{
    class ChildWindowCode
    {
        public static void LoadChildForm(Form form)
        {
            foreach (Form1 frm in Form1.ActiveForm.MdiChildren)
            {
                if (frm.GetType() == form.GetType())
                {
                    frm.Focus();
                    return;
                }
            }
            form.MdiParent = Form1.ActiveForm;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
        }
    }
}
