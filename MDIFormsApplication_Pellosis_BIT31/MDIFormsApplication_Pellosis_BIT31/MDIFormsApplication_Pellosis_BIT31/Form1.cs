using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDIFormsApplication_Pellosis_BIT31
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addNewRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 newRecord = new Form2();
            ChildFormWindow.ChildWindowCode.LoadChildForm(newRecord);
        }
    }
}
