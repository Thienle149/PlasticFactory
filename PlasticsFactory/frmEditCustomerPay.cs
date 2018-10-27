using BUS.Business;
using PlasticsFactory.Data;
using System;
using System.Windows.Forms;

namespace PlasticsFactory
{
    public partial class frmEditCustomerPay : Form
    {
        //Khai báo delegate
        public delegate void Rotate(string MSTT, string Date, string MSHD, string MSKH, string CustomerName, string ProductNames, int ProductWeigth, int Amount, int Payed);

        public Rotate Sender;

        public frmEditCustomerPay()
        {
            InitializeComponent();
            //Tạo con trỏ tới hàm GetMessage
            Sender = new Rotate(loadDataByCustomerPay);
        }

        private void loadDataByCustomerPay(string MSTT, string Date, string MSHD, string MSKH, string CustomerName, string ProductNames, int ProductWeigth, int Amount, int Payed)
        {
            txtMSTT.Text = MSTT;
            txtMSHD.Text = MSHD;
            txtDate.Text = Date;
            txtMSKH.Text = MSKH;
            txtName.Text = CustomerName;
            txtProductNames.Text = ProductNames;
            txtProductWeight.Text = ProductWeigth.ToString();
            txtAmount.Text = Amount.ToString();
            txtPayed.Text = Payed.ToString();
        }

        private void frmEditCustomerPay_Load(object sender, EventArgs e)
        {
        }

        private void txtPayed_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar)&&!Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtPayed.Text != string.Empty && txtPayed.Text != "0")
            {
                string Type = txtMSTT.Text.Trim().Substring(0, 2);
                if (Type == "NH")
                {
                    PaymentInputBO paymentInputBO = new PaymentInputBO();
                    PaymentInput payment = new PaymentInput();
                    payment.ID = int.Parse(txtMSTT.Text.Substring(2));
                    payment.Date = DateTime.Parse(txtDate.Text);
                    payment.MSDH = int.Parse(txtMSHD.Text.Trim().Substring(2));
                    payment.isDelete = false;
                    payment.Payment = int.Parse(txtPayed.Text);
                    paymentInputBO.Update(payment);
                }
                else
                {
                    PaymentOutputBO paymentOutputBO = new PaymentOutputBO();
                    PaymentOutput payment = new PaymentOutput();
                    payment.ID = int.Parse(txtMSTT.Text.Substring(2));
                    payment.Date = DateTime.Parse(txtDate.Text);
                    payment.MSDH = int.Parse(txtMSHD.Text.Trim().Substring(2));
                    payment.isDelete = false;
                    payment.Payment = int.Parse(txtPayed.Text);
                    paymentOutputBO.Update(payment);
                }
            }
            this.Close();
        }
    }
}