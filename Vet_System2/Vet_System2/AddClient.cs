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
    public partial class AddClient : Form
    {
        public AddClient()
        {
            InitializeComponent();
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            try
            {
                string ClientName = txtClientName.Text;
                string ClientPhone = txtPhone.Text;
                string Notes = txtNotes.Text;
                string Payments = txtPayments.Text;
                if (string.IsNullOrWhiteSpace(ClientName))
                {
                    flatAlertBox1.ShowControl(FlatUI.FlatAlertBox._Kind.Error, "يرجي إدخال اسم العميل", 5000);

                    return;
                }
                if (string.IsNullOrWhiteSpace(ClientPhone)) ClientPhone = "غير محدد";
                if (string.IsNullOrWhiteSpace(Payments)) Payments = "0";

                DbHelper.addClient(ClientName, ClientPhone, Notes, Payments);
                MessageBox.Show("تم إضافة عميل","إضافة عميل",MessageBoxButtons.OK,MessageBoxIcon.Information);
                Close();
            }catch (Exception ex) { new frmErrorHandel(ex.Message + "\n======\n" + ex.StackTrace).ShowDialog(); }
        }

        private void flatStickyButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

    
 

    }
}
