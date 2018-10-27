using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PlasticsFactory.UserControls.Main_Content.MCProduct;

namespace PlasticsFactory.UserControls.PreferenceMenu
{
    public partial class PMProduct : UserControl
    {
        #region Generate Field
        public ProductInput productInput = new ProductInput();
        public ProductOutput productOutput = new ProductOutput();
        private ProductManage productManage;
        #endregion
        public PMProduct()
        {
            InitializeComponent();
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            productInput = productInput ?? new ProductInput();
            frmLayout.panelContents.Controls.Clear();
            frmLayout.panelContents.Controls.Add(productInput);
        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            productOutput = productOutput ?? new ProductOutput();
            frmLayout.panelContents.Controls.Clear();
            frmLayout.panelContents.Controls.Add(productOutput);
        }

        private void btnManagement_Click(object sender, EventArgs e)
        {
            productManage = new ProductManage();
            frmLayout.panelContents.Controls.Clear();
            frmLayout.panelContents.Controls.Add(productManage);
        }
    }
}
