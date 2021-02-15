using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReMax
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
            //accessing variables
            clsGLobalVariables.myset = new DataSet();
            //creating connenction with database
            SqlConnection mycon = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=RemaxDt;Integrated Security=True");
            mycon.Open();

            //Recuperate the table Employees from the database
            SqlCommand mycmd = new SqlCommand("SELECT * FROM Employees");
            mycmd.Connection = mycon;
            clsGLobalVariables.adpEmployees = new SqlDataAdapter(mycmd);
            // Add the table employees in dataset as a database
            clsGLobalVariables.adpEmployees.Fill(clsGLobalVariables.myset,"Employees");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection mycon = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=RemaxDt;Integrated Security=True");
            mycon.Open();

            string mail = txtEmail.Text;
            string pwd = txtPwd.Text;
            clsGLobalVariables.Agents.Visible = false;

            //Validation of Login
            SqlCommand mycmd = new SqlCommand("SELECT Email,Password FROM Employees WHERE Email = '"+ txtEmail.Text+"'AND Password ='"+txtPwd.Text+"'",mycon);
            SqlDataAdapter da = new SqlDataAdapter(mycmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            //Validation of Admin - Agent
            SqlDataReader myRder = null;
            SqlCommand mycmd1 = new SqlCommand("SELECT Name FROM Employees WHERE Email = '" + txtEmail.Text +"'", mycon);
            SqlDataAdapter da1 = new SqlDataAdapter(mycmd1);
            myRder = mycmd1.ExecuteReader();

            try
            {
                DataTable dt1 = new DataTable();
                dt1 = clsGLobalVariables.myset.Tables["Employees"];

                clsGLobalVariables.loginID = dt1.Rows[0]["refEmployees"].ToString();

                if (dt.Rows.Count > 0)
                {
                    while (myRder.Read())
                    {
                        clsGLobalVariables.ClientName = myRder[0].ToString();
                        clsGLobalVariables.User.Text = "Welcome, " + myRder[0].ToString();
                    }
                    MessageBox.Show("Login Successfull", "Login");
                    //Setting Visibility 
                    clsGLobalVariables.login.Visible = false;
                    clsGLobalVariables.logout.Visible = true;
                    clsGLobalVariables.dashboard.Visible = true;
                    myRder.Close();
                  


                    SqlDataReader myRder1 = null;
                    SqlCommand mycmd2 = new SqlCommand("SELECT Position FROM Employees WHERE Email = '" + txtEmail.Text + "'", mycon);
                    SqlDataAdapter da2 = new SqlDataAdapter(mycmd2);
                    myRder1 = mycmd2.ExecuteReader();

                    while(myRder1.Read())
                    {
                        clsGLobalVariables.post = myRder1[0].ToString();
                    }

                    if (clsGLobalVariables.post.Substring(0,5) == "Admin")
                    {
                        clsGLobalVariables.Agents.Visible = true;
                    }
                    //Close login Frame
                    this.Close();
                    
                }
                else
                {
                    MessageBox.Show("Login Credential are not correct!", "Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }

                myRder.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error due to :" + ex.Message, "Error");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtEmail.Text = "piyush@remax.com";
            txtPwd.Text = "piyush123";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtEmail.Text = "mehul@remax.com";
            txtPwd.Text = "mehul123";
        }
    }
}
