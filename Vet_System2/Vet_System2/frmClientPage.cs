using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Vet_System2;

namespace VetSystem
{
    public partial class frmClientPage : Form
    {
        private string ClientID;
        public frmClientPage()
        {
            InitializeComponent();
        }
        public frmClientPage(string clientID)
        {
            InitializeComponent();
            this.ClientID = clientID;
        }
        private void frmClientPage_Load(object sender, EventArgs e)
        {
            try
            {

                DataTable table = DbHelper.getClientByID(ClientID);

                txtClientName.Text = table.Rows[0]["ClientName"].ToString();

                txtPhone.Text = table.Rows[0]["Phone"].ToString();

                txtNotes.Text = table.Rows[0]["Notes"].ToString();

                txtPayments.Text = table.Rows[0]["Payments"].ToString();

                txtPaid.Text = table.Rows[0]["Paid"].ToString();

                txtRemain.Text = table.Rows[0]["Remain"].ToString();

                txtPayments.TextChanged += txtPaid_TextChanged;

                txtPaid.TextChanged += txtPaid_TextChanged;

                txtRemain.TextChanged += txtRemain_TextChanged;
            }
            catch (Exception ex) { new frmErrorHandel(ex.Message + "\n======\n" + ex.StackTrace).ShowDialog(); }
        }


        #region texts
        private void txtPayments_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal payments = decimal.Parse(txtPayments.Text);
                decimal paid = decimal.Parse(txtPaid.Text);
                decimal remains = payments - paid;
                txtRemain.Text = remains.ToString();
            }
            catch { }
        }

        private void txtPaid_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal payments = decimal.Parse(txtPayments.Text);
                decimal paid = decimal.Parse(txtPaid.Text);
                decimal remains = payments - paid;
                txtRemain.Text = remains.ToString();
            }
            catch { }
        }

        private void txtRemain_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal payments = decimal.Parse(txtPayments.Text);
                decimal remains = decimal.Parse(txtRemain.Text);
                decimal paid = payments - remains;
                txtPaid.Text = paid.ToString();
            }
            catch { }
        }

        #endregion

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                DbHelper.updateClient(ClientID, txtClientName.Text, txtPhone.Text, txtNotes.Text, txtPayments.Text, txtPaid.Text, txtRemain.Text);
                flatAlertBox1.ShowControl(FlatUI.FlatAlertBox._Kind.Success, "تم حفظ بيانات العميل", 5000);
            }
            catch
            {
                flatAlertBox1.ShowControl(FlatUI.FlatAlertBox._Kind.Error, "حدث خطأ يرجى التأكد من البيانات", 5000);
            }
        }

        private void flatStickyButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDelClient_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("هل حقا تود حذف هذا العميل ",
                   "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.No) return;

            DbHelper.deleteClient(ClientID);
            MessageBox.Show("تم حذف العميل", "حذف العميل", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
    }
}
