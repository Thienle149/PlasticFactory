using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PlasticsFactory.UserControls.Main_Content.MCCustomer;

namespace PlasticsFactory.UserControls.PreferenceMenu
{
    public partial class PMCustomer : UserControl
    {
        public MCADDKhachhang mcADDBanhang;
        public MCThanhtoan mcThanhtoan;
        public MCCustomerMG mcCustomerMG;
        public PMCustomer()
        {
            InitializeComponent();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            mcThanhtoan = new MCThanhtoan();
            frmLayout.panelContents.Controls.Clear();
            frmLayout.panelContents.Controls.Add(mcThanhtoan);
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            mcADDBanhang = new MCADDKhachhang();
            frmLayout.panelContents.Controls.Clear();
            frmLayout.panelContents.Controls.Add(mcADDBanhang);
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            mcCustomerMG = new MCCustomerMG();
            frmLayout.panelContents.Controls.Clear();
            frmLayout.panelContents.Controls.Add(mcCustomerMG);
        }
    }
}
