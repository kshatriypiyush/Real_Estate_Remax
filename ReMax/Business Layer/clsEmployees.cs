using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace ReMax
{
    public class clsEmployees
    {
        private string name;
        private string phone;
        private string mail;
        private string Addr;
        private string pwd;
        private string post;
        private string gender;

        SqlConnection mycon = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=RemaxDt;Integrated Security=True");

        public DataTable emp_List()
        {
            mycon.Open();

            SqlCommand mycmdAgents = new SqlCommand("SELECT * FROM Employees ", mycon);
            SqlDataAdapter daAgentsView = new SqlDataAdapter(mycmdAgents);
            var dsAgentsView = new DataSet();
            daAgentsView.Fill(dsAgentsView);
            mycon.Close();

            return dsAgentsView.Tables[0];

            
        }

        public void emp_Set(string name, string phone, string mail, string Addr, string pwd, string post, string gender)
        {
            this.name = name;
            this.phone = phone;
            this.mail = mail;
            this.Addr = Addr;
            this.pwd = pwd;
            this.post = post;
            this.gender = gender;
        }

        public void emp_Add()
        {
            SqlCommand mycmdAgents = new SqlCommand("INSERT INTO Employees (Name, Email, Phone, Address, Password, Gender, Position) " +
                        " VALUES('" + name + "','" + mail + "','" + phone + "','" + Addr + "','" + pwd + "','" + gender +
                        "','" + post + "')", mycon);
            SqlDataAdapter da = new SqlDataAdapter(mycmdAgents);
            var dsAgentsAdd = new DataSet();
            da.Fill(dsAgentsAdd);
        }

        public void emp_Update()
        {

            SqlCommand mycmdeditClients = new SqlCommand("UPDATE Employees " +
                       "SET Name ='" + name + "', Email ='" + mail +
                       "', Phone =" + phone + ", Password ='" + pwd +
                       "', Address ='" + Addr + "', Position = '" + post +
                       "', Gender ='" + gender +  "' WHERE Name = '" + clsGLobalVariables.Id + "'"
                       , mycon);
            SqlDataAdapter daeditClients = new SqlDataAdapter(mycmdeditClients);
            var dsClientsEdit = new DataSet();
            daeditClients.Fill(dsClientsEdit);
        }

        public void emp_Remove()
        {
            mycon.Open();
            SqlCommand mycmddeleteAgents = new SqlCommand("DELETE FROM Employees WHERE Name ='" + clsGLobalVariables.Id.ToString() + "'", mycon);
            SqlDataAdapter daAgentsdelete = new SqlDataAdapter(mycmddeleteAgents);
            var dsAgentsdelete = new DataSet();
            daAgentsdelete.Fill(dsAgentsdelete);
            mycon.Close();
        }
    }
}