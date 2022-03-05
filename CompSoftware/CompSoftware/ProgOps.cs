using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CompSoftware
{
    class ProgOps
    {
        //conection string
        private const string CONNECT_STRING = @"Server=cstnt.tstc.edu;Database=  inew2330sp22;User Id= group4fa212330;password= 4659565";
        //build a connection to our database
        private static SqlConnection _cntDatabase = new SqlConnection(CONNECT_STRING);

        public static void OpenDataBase()
        {
            _cntDatabase.Open();
            //message stating connection was success
            MessageBox.Show("Connection to db was opened successfully", "Database Connection", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void CloseDataBase()
        {
            _cntDatabase.Close();
            MessageBox.Show("Connection to db was closed successfully", "Database Connection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //dispose of db
            _cntDatabase.Dispose();
        }

        public static void Login(String email, string password)
        {

        }
    }
}
