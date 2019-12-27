using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace Vet_System2
{
    public partial class frmErrorHandel : Form
    {
        private string errorMessage;

        public frmErrorHandel()
        {
            InitializeComponent();
        }

        public frmErrorHandel(string errorMessage)
        {
            this.errorMessage = errorMessage;
            InitializeComponent();

        }

        private void frmErrorHandel_Load(object sender, EventArgs e)
        {
            File.AppendAllText(Directory.GetCurrentDirectory()  +"\\Error Report.txt", errorMessage);
            txtError.Text = errorMessage;
            flatAlertBox1.Show();
            
        }

        private void flatStickyButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
