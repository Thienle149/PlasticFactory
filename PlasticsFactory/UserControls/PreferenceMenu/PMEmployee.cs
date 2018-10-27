using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PlasticsFactory.UserControls.Main_Content.MCEmployee;

namespace PlasticsFactory.UserControls.PreferenceMenu
{
    public partial class PMEmployee : UserControl
    {
        private MCEAdd mceAdd = new MCEAdd();
        private MCEmployeeManagement mceManage = new MCEmployeeManagement();
        public PMEmployee()
        {
            InitializeComponent();
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            frmLayout.panelContents.Controls.Clear();
            frmLayout.panelContents.Controls.Add(mceManage);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmLayout.panelContents.Controls.Clear();
            frmLayout.panelContents.Controls.Add(mceAdd);
        }
    }
}
