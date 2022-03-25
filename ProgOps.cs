using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HighSchoolGroupProject
{
    class ProgOps
    {
        //conection string
        private const string CONNECT_STRING = @"Server=cstnt.tstc.edu;Database=  inew2330sp22;User Id= group4fa212330;password= 4659565";
        //build a connection to our database
        private static SqlConnection _cntDatabase = new SqlConnection(CONNECT_STRING);

        public static void OpenDatabase()
        {
            _cntDatabase.Open();
            //message stating connection was success
            MessageBox.Show("Connection to db was opened successfully", "Database Connection", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void CloseDisposeDatabase()
        {
            _cntDatabase.Close();
            MessageBox.Show("Connection to db was closed successfully", "Database Connection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //dispose of db
            _cntDatabase.Dispose();
        }

        public static bool Login(string username, string password)
        {
            bool login = false;
            string loginCommand = "SELECT LogonName, Password FROM MortonJ22Sp2332.Logon " +
                "WHERE LogonName = '" + username + "' AND Password = '" + password + "';";

            SqlCommand _logonCommand = new SqlCommand(loginCommand, _cntDatabase);
            SqlDataAdapter _logonAdapter = new SqlDataAdapter();
            DataTable _logonTable = new DataTable();
            _logonAdapter.SelectCommand = _logonCommand;
            _logonAdapter.Fill(_logonTable);

            if (_logonTable.Rows.Count > 0)
            {
                login = true;
            }
            else
            {
                login = false;
            }

            if (login)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
