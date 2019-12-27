using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using Vet_System2;
namespace VetSystem
{
    static class DbHelper
    {
        static string ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\vetdb.accdb";
        public static DataTable getDataTable(string query)
        {

            OleDbConnection connection = new OleDbConnection(ConnectionString);
            connection.Open();
            DataTable table = new DataTable();
            try
            {
                OleDbDataAdapter adpter = new OleDbDataAdapter(query, connection);
                adpter.Fill(table);
                adpter.Dispose();
                connection.Close();
            }
            catch (Exception ex)
            {
                connection.Close();
                new frmErrorHandel(ex.Message + Environment.NewLine + "======" + Environment.NewLine + ex.StackTrace).ShowDialog();
            }



            return table;
        }
        public static void executeSQL(string query)
        {
            OleDbConnection connection = new OleDbConnection(ConnectionString);
            connection.Open();
            try
            {
                OleDbCommand cmd = new OleDbCommand(query, connection);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                connection.Close();
            }
            catch (Exception ex)
            {
                connection.Close();
                new frmErrorHandel(ex.Message + Environment.NewLine + "======" + Environment.NewLine + ex.StackTrace).ShowDialog();
            }

        }
        public static DataTable getAllClients()
        {
            return getDataTable("SELECT ClientID,ClientName,Phone FROM Client;");
        }
        public static DataTable getClientByID(string ClientID)
        {
            return getDataTable("SELECT * FROM Client WHERE ClientID =" + ClientID + ";");
        }
        public static void addClient(string ClientName, string ClientPhone, string Notes, string Payments)
        {
            string Query1 = "INSERT INTO Client (ClientName,Phone,Notes,Payments) VALUES('%clientname%','%phone%','%notes%',%payments%);";
            Query1 = Query1.Replace("%clientname%", ClientName).Replace("%phone%", ClientPhone).Replace("%notes%", Notes).Replace("%payments%", Payments);
            DbHelper.executeSQL(Query1);
        }
        public static void updateClient(string ClientID, string ClientName, string ClientPhone, string Notes, string Payments, string Paid, string Remain)
        {

            string Query = "update Client SET ClientName='%clientname%',Phone='%phone%',Notes='%notes%'," +
              "Payments=%payments%,Paid=%paid%,Remain=%remain% where ClientID=" + ClientID + ";";
            Query = Query
              .Replace("%clientname%", ClientName)
              .Replace("%phone%", ClientPhone)
              .Replace("%notes%", Notes)
              .Replace("%payments%", Payments)
              .Replace("%paid%", Paid)
              .Replace("%remain%", Remain);
            executeSQL(Query);
        }
        public static void deleteClient(string ClientID)
        {


            string query = "DELETE * FROM Client WHERE  ClientID=" + ClientID + ";";
            executeSQL(query);
        }
    }
}
