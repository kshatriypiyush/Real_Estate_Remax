using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace ReMax
{
    public class clsClient
    {
        private string name;
        private string phone;
        private string mail;
        private string Addr;
        private string pwd;
        private string notes;
        private string gender;
        private string AgentName;


        SqlConnection mycon = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=RemaxDt;Integrated Security=True");

       public void Client_Set(string name,string phone,string mail,string Addr,string pwd,string notes,string AgentName,string gender)
        {
        this.name = name;
        this.phone= phone;
        this.mail=mail;
        this.Addr=Addr;
        this.pwd=pwd;
        this.notes=notes;
        this.AgentName=AgentName;
            this.gender = gender;
    }

        public void Client_Add()
        {
            SqlCommand mycmdClients = new SqlCommand("INSERT INTO Clients (Name, Email, Phone, Address, Password, Gender, Notes, refEmployee) " +
                       " VALUES('" + name + "','" + mail + "','" + phone + "','" + Addr + "','" + pwd + "','" + gender +
                       "','" + notes + "','" + AgentName + "')", mycon);
            SqlDataAdapter da = new SqlDataAdapter(mycmdClients);
            var dsClientsAdd = new DataSet();
            da.Fill(dsClientsAdd);
        }

        public void Client_Remove()
        {
            mycon.Open();
            SqlCommand mycmddeleteClients = new SqlCommand("DELETE FROM Clients WHERE Name ='" + clsGLobalVariables.Id.ToString() + "'", mycon);
            SqlDataAdapter daClientsdelete = new SqlDataAdapter(mycmddeleteClients);
            var dsClientsdelete = new DataSet();
            daClientsdelete.Fill(dsClientsdelete);
            mycon.Close();
        }

        public void Client_Update()
        {
            SqlCommand mycmdeditClients = new SqlCommand("UPDATE Clients " +
                       "SET Name ='" + name + "', Email ='" + mail +
                       "', Phone =" + phone + ", Password ='" + pwd +
                       "', Address ='" + Addr + "', Notes = '" + notes +
                       "', Gender ='" + gender + "', refEmployee ='" + AgentName + "' WHERE Name = '" + clsGLobalVariables.Id + "'"
                       , mycon);
            SqlDataAdapter daeditClients = new SqlDataAdapter(mycmdeditClients);
            var dsClientsEdit = new DataSet();
            daeditClients.Fill(dsClientsEdit);
        }

        public DataTable Client_List()
        {
            if (clsGLobalVariables.post.Substring(0, 5) != "Admin")
            {

                SqlCommand mycmd4 = new SqlCommand("SELECT * FROM Clients WHERE refEmployee='" + clsGLobalVariables.ClientName + "'", mycon);
                SqlDataAdapter da = new SqlDataAdapter(mycmd4);
                var dsClients = new DataSet();
                da.Fill(dsClients);

                return dsClients.Tables[0];
            }
            else
            {
                SqlCommand mycmd4 = new SqlCommand("SELECT * FROM Clients ", mycon);
                SqlDataAdapter da = new SqlDataAdapter(mycmd4);
                var dsClients = new DataSet();
                da.Fill(dsClients);

                return dsClients.Tables[0];
            }
        }
    }
}   