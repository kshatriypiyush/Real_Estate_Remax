using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReMax
{
    public static class clsGLobalVariables
    {

        public static DataSet myset;
        public static SqlDataAdapter adpClients;
        public static SqlDataAdapter adpEmployees;
        public static SqlDataAdapter adpHouses;
        public static System.Windows.Forms.ToolStripMenuItem login;
        public static System.Windows.Forms.ToolStripMenuItem logout;
        public static System.Windows.Forms.ToolStripMenuItem dashboard;
        public static System.Windows.Forms.ToolStripMenuItem Agents;
        public static string post;
        public static string method;
        public static string Id;
        public static string ClientName;
        public static string loginID;
        public static System.Windows.Forms.Label User;
    }
}
