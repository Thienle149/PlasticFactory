using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PlasticsFactory.UserControls.Main_Content.MCChamcong;

namespace PlasticsFactory.UserControls.PreferenceMenu
{
    public partial class PMChamcong : UserControl
    {
        public PMChamcong()
        {
            InitializeComponent();
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            Management management = new Management();
            frmLayout.panelContents.Controls.Clear();
            frmLayout.panelContents.Controls.Add(management);
        }

        private void btnTimekeeping_Click(object sender, EventArgs e)
        {
            MCAll mcAll = new MCAll();
            frmLayout.panelContents.Controls.Clear();
            frmLayout.panelContents.Controls.Add(mcAll);
        }
    }
}
