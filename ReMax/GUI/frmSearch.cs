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
    public partial class frmSearch : Form
    {
        public frmSearch()
        {
            InitializeComponent();
        }

        SqlConnection mycon = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=RemaxDt;Integrated Security=True");

        
        private void frmSearch_Load(object sender, EventArgs e)
        {
           
        }

        private void dataResultSearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void rdHouses_CheckedChanged(object sender, EventArgs e)
        {
            mycon.Open();

          
            //dtClients = clsGLobalVariables.myset.Tables["Clients"];

            SqlCommand mycmdHouseFetch = new SqlCommand("SELECT * FROM Houses ", mycon);
            SqlDataAdapter daHouseFetch = new SqlDataAdapter(mycmdHouseFetch);
            var dsHouse = new DataSet();
            daHouseFetch.Fill(dsHouse);

            dataResultSearch.DataSource = dsHouse.Tables[0];
            mycon.Close();
        }

        private void rdAgents_CheckedChanged(object sender, EventArgs e)
        {
            mycon.Open();

          
            //dtClients = clsGLobalVariables.myset.Tables["Clients"];

            SqlCommand mycmdHouseFetch = new SqlCommand("SELECT * FROM Employees ", mycon);
            SqlDataAdapter daHouseFetch = new SqlDataAdapter(mycmdHouseFetch);
            var dsHouse = new DataSet();
            daHouseFetch.Fill(dsHouse);

            dataResultSearch.DataSource = dsHouse.Tables[0];
            mycon.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

          

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            mycon.Open();

            try
            {
                if (rdHouses.Checked == true)
                {
                    SqlCommand mycmdHouseFetch = new SqlCommand("SELECT * FROM Houses WHERE HouseID =" + Convert.ToInt32(txtSearch.Text), mycon);
                    SqlDataAdapter daHouseFetch = new SqlDataAdapter(mycmdHouseFetch);
                    var dsHouse = new DataSet();
                    daHouseFetch.Fill(dsHouse);

                    dataResultSearch.DataSource = dsHouse.Tables[0];
                }

                if (rdAgents.Checked == true)
                {
                    SqlCommand mycmdHouseFetch = new SqlCommand("SELECT * FROM Employees WHERE Name ='" + txtSearch.Text + "'", mycon);
                    SqlDataAdapter daHouseFetch = new SqlDataAdapter(mycmdHouseFetch);
                    var dsHouse = new DataSet();
                    daHouseFetch.Fill(dsHouse);

                    dataResultSearch.DataSource = dsHouse.Tables[0];
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            mycon.Close();
        }
    }
}
