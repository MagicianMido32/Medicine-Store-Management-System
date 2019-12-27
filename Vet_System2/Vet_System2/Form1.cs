using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Vet_System2;

namespace VetSystem
{
    public partial class frmMain : Form
    {
        private DataTable _tableAll;
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

            try
            {
                if (File.Exists("\\DBsm.laccdb")) File.Delete("\\DBsm.laccdb");
                displayAll();
                flatAlertBox1.ShowControl(FlatUI.FlatAlertBox._Kind.Info, "السلام عليكم ورحمة الله وبركاته , نتمنى أن تكون بصحة وعافية", 5000);
            }
            catch (Exception ex) { new frmErrorHandel(ex.Message + Environment.NewLine + "======" + Environment.NewLine + ex.StackTrace).ShowDialog(); }
        }

        void initializeTable()
        {
            _tableAll = DbHelper.getAllClients();
        }
        void displayAll()
        {
            txtSearch.Text = "";
            gridClients.AutoGenerateColumns = false;
            gridClients.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            gridClients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            gridClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            initializeTable();
            gridClients.DataSource = _tableAll;
            gridClients.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            // gridClients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            gridClients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridClients.Update();
            gridClients.Refresh();

        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string txtValue = txtSearch.Text;
            if (txtValue == "")
            {
                displayAll();
                return;
            }

            gridClients.AutoGenerateColumns = false;
            gridClients.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            gridClients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            gridClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            ///

            DataTable table = new DataTable();
            if (_tableAll.Select("ClientName LIKE '%" + txtValue + "%' OR Phone LIKE '%" + txtValue + "%'").Any())
            {
                table = _tableAll.Select("ClientName LIKE '%" + txtValue + "%' OR Phone LIKE '%" + txtValue + "%'")
                    .CopyToDataTable();
            }
            gridClients.AutoGenerateColumns = false;
            gridClients.DataSource = table;
            gridClients.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            // gridClients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            gridClients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            gridClients.Update();
            gridClients.Refresh();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new AddClient().ShowDialog();
            displayAll();
        }

        private void btnClientPage_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedCellClientId = "";
                try
                {
                    selectedCellClientId = gridClients.SelectedCells[0].OwningRow.Cells["ClientID"].Value.ToString();
                }
                catch
                {
                    selectedCellClientId = gridClients.SelectedRows[0].Cells["ClientID"].Value.ToString();
                }
                frmClientPage frmClientPage = new frmClientPage(selectedCellClientId);
                frmClientPage.ShowDialog();
                // if (_autoUpdate) InitializeTable();
                displayAll();
            }
            catch (Exception ex)
            {//here we don't throw critical error
                flatAlertBox1.ShowControl(FlatUI.FlatAlertBox._Kind.Error, "خطأ ", 5000);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            displayAll();
        }

        private void lblAbout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new frmAbout().ShowDialog();
        }



    }
}
