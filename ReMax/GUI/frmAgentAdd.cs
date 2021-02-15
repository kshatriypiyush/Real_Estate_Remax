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
    public partial class frmAgentAdd : Form
    {
        public frmAgentAdd()
        {
            InitializeComponent();
        }

        SqlConnection mycon = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=RemaxDt;Integrated Security=True");

        clsEmployees Emp = new clsEmployees();
        private void btn_AddAgent_Click(object sender, EventArgs e)
        {

            try
            {
                mycon.Open();

                //Inserting data in to table
                DataSet dsCl = new DataSet();


                string gender = "";
                //String refEmployeeName = cbAgentName.SelectedItem.ToString();

                if (radioButtonMale.Checked == true)
                {
                    gender = radioButtonMale.Text;
                }
                else
                {
                    gender = radioButtonFemale.Text;
                }

                if (clsGLobalVariables.method == "add")
                {
                    try {
                        Emp.emp_Set(txt_name.Text, txt_phone.Text, txt_mail.Text, txt_Addr.Text, txt_pwd.Text, txt_post.Text, gender);
                        Emp.emp_Add();
                        MessageBox.Show("Agent added successfully !!!", "Agent Added", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Please Insert the details before adding data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (clsGLobalVariables.method == "edit")
                {
                    try
                    {
                        Emp.emp_Set(txt_name.Text, txt_phone.Text, txt_mail.Text, txt_Addr.Text, txt_pwd.Text, txt_post.Text, gender);
                        Emp.emp_Update();

                        MessageBox.Show("Agents Detail has been Updated!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Please Insert the details before adding data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                mycon.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error due to "+ex.Message,"Error");
            }
            this.Close();
            frmAgentsView agentsView = new frmAgentsView();
            agentsView.Show();
        }

        private void frmAgentAdd_Load(object sender, EventArgs e)
        {
            btn_AddAgent.Text = "Add Agent";
            mycon.Open();

            string cmd = "SELECT Name FROM Employees WHERE Position = 'Admin'";
            SqlDataAdapter daAGENTFETCH = new SqlDataAdapter(cmd, mycon);

            DataTable admintNames = new DataTable();
            daAGENTFETCH.Fill(admintNames);

            for (int i = 0; i < admintNames.Rows.Count; i++)
            {
                cbAdminName.Items.Add(admintNames.Rows[i]["Name"].ToString());
            }
            mycon.Close();
            if (clsGLobalVariables.method == "edit")
            {
                mycon.Open();
                btn_AddAgent.Text = "Edit Agent";

                string cmdAgent = "SELECT * FROM Employees WHERE Name = '" + clsGLobalVariables.Id + "'";
                SqlDataAdapter daAgent = new SqlDataAdapter(cmdAgent, mycon);

                DataTable Agentdetails = new DataTable();
                daAgent.Fill(Agentdetails);


                txt_name.Text = Agentdetails.Rows[0]["Name"].ToString();
                txt_phone.Text = Agentdetails.Rows[0]["Phone"].ToString();
                txt_mail.Text = Agentdetails.Rows[0]["Email"].ToString();
                txt_Addr.Text = Agentdetails.Rows[0]["Address"].ToString();
                txt_pwd.Text = Agentdetails.Rows[0]["Password"].ToString();
                txt_post.Text = Agentdetails.Rows[0]["Position"].ToString();
                if (Agentdetails.Rows[0]["Gender"].ToString() == "Female")
                {
                    radioButtonFemale.Checked = true;
                }
                else
                {
                    radioButtonMale.Checked = true;
                }
                mycon.Close();
            }
        }

        private void btn_ClearAgent_Click(object sender, EventArgs e)
        {
            txt_Addr.Text = "";
            txt_mail.Text = "";
            txt_name.Text = "";
            txt_phone.Text = "";
            txt_Addr.Text = "";
            cbAdminName.Text = "";
            radioButtonFemale.Checked = false;
            radioButtonMale.Checked = false;
            
        }
    }
}
