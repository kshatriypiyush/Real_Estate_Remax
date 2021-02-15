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
    public partial class frmHouseAdd : Form
    {
        public frmHouseAdd()
        {
            InitializeComponent();
        }
        clsHouse Home = new clsHouse();
        SqlConnection mycon = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=RemaxDt;Integrated Security=True");
       
        private void btn_AddNewHouse_Click(object sender, EventArgs e)
        {
            mycon.Open();
            if (clsGLobalVariables.method == "add")
            {
                try
                {
                    Home.House_Set(cbAgentName.SelectedItem.ToString(),Convert.ToInt32(cb_Bathrooms.SelectedItem),
                    Convert.ToInt32(cb_Bedrooms.SelectedItem.ToString()),cb_ClientName.SelectedItem.ToString(), 
                    cb_HouseType.Text,cb_ListingFor.Text,Convert.ToInt32(cb_Parking.SelectedItem.ToString()),
                    Convert.ToInt32(cb_TotalRooms.SelectedItem.ToString()),txtReviews.Text, txt_Address.Text, txt_LivingArea.Text,
                    txt_Price.Text,BuildDate.Value);

                    Home.House_Add();
                    MessageBox.Show("House is Added Successfully!", "Data Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Please Insert the details before adding data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (clsGLobalVariables.method == "edit")
            {
                try
                {
                    Home.House_Set(cbAgentName.SelectedItem.ToString(), Convert.ToInt32(cb_Bathrooms.SelectedItem),
                   Convert.ToInt32(cb_Bedrooms.SelectedItem.ToString()), cb_ClientName.SelectedItem.ToString(),
                   cb_HouseType.Text, cb_ListingFor.Text, Convert.ToInt32(cb_Parking.SelectedItem.ToString()),
                   Convert.ToInt32(cb_TotalRooms.SelectedItem.ToString()), txtReviews.Text, txt_Address.Text, txt_LivingArea.Text,
                   txt_Price.Text, BuildDate.Value);

                    Home.House_Update();

                    MessageBox.Show("House Detail has been Updated!", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
               
                
            }
            mycon.Close();
            frmHouses houses = new frmHouses();
            houses.Show();
            this.Close();
        }

        private void frmHouseAdd_Load(object sender, EventArgs e)
        {

            //Assigning Agent Names
          
                string cmd = "SELECT Name FROM Employees WHERE Position = 'Agent'";
                SqlDataAdapter daAgentFetch = new SqlDataAdapter(cmd, mycon);

                DataTable agnetNames = new DataTable();
                daAgentFetch.Fill(agnetNames);

                for (int i = 0; i < agnetNames.Rows.Count; i++)
                {
                    cbAgentName.Items.Add(agnetNames.Rows[i]["Name"].ToString());
                }

                //Assigning Client Names
                string cmdClientNames = "SELECT Name FROM Clients";
                SqlDataAdapter daClientsFetch = new SqlDataAdapter(cmdClientNames, mycon);

                DataTable clientNames = new DataTable();
                daClientsFetch.Fill(clientNames);

                for (int i = 0; i < clientNames.Rows.Count; i++)
                {
                    cb_ClientName.Items.Add(clientNames.Rows[i]["Name"].ToString());
                }

                //Assigning Listing
                string cmdListing = "SELECT ListingStatus FROM Listing";
                SqlDataAdapter daListing = new SqlDataAdapter(cmdListing, mycon);

                DataTable dtListing = new DataTable();
                daListing.Fill(dtListing);

                for (int i = 0; i < dtListing.Rows.Count; i++)
                {
                    cb_ListingFor.Items.Add(dtListing.Rows[i]["ListingStatus"].ToString());
                }

                //Assigning House Type
                string cmdHouseType = "SELECT TypeName FROM HouseType";
                SqlDataAdapter daHouseType = new SqlDataAdapter(cmdHouseType, mycon);

                DataTable dtHouseType = new DataTable();
                daHouseType.Fill(dtHouseType);

                for (int i = 0; i < dtHouseType.Rows.Count; i++)
                {
                    cb_HouseType.Items.Add(dtHouseType.Rows[i]["TypeName"].ToString());
                }



                for (int i = 0; i < 5; i++)
                {
                    cb_Bathrooms.Items.Add(i);
                    cb_Bedrooms.Items.Add(i);
                    cb_Parking.Items.Add(i);
                    cb_TotalRooms.Items.Add(i);
                }
            
            if(clsGLobalVariables.method == "edit")
            {
                btn_AddNewHouse.Text = "Edit House Details";
              
                string cmdEditHouse = "SELECT * FROM Houses WHERE HouseID ='"+Convert.ToInt32(clsGLobalVariables.Id)+"'";
                SqlDataAdapter daEditHouse = new SqlDataAdapter(cmdEditHouse, mycon);

                DataTable EditHouse = new DataTable();
                daEditHouse.Fill(EditHouse);
             
                cbAgentName.SelectedItem = EditHouse.Rows[0]["refEmployee"].ToString();
                cb_Bathrooms.SelectedItem = Convert.ToInt32(EditHouse.Rows[0]["Bathroom"].ToString());
                cb_Bedrooms.SelectedItem = Convert.ToInt32(EditHouse.Rows[0]["Bedrooms"].ToString());
                cb_ClientName.SelectedItem = EditHouse.Rows[0]["ClientName"].ToString();
                cb_HouseType.Text = EditHouse.Rows[0]["HouseType"].ToString();
                cb_ListingFor.Text = EditHouse.Rows[0]["Listing"].ToString();
                cb_Parking.SelectedItem = Convert.ToInt32(EditHouse.Rows[0]["Parking"].ToString());
                cb_TotalRooms.SelectedItem = Convert.ToInt32(EditHouse.Rows[0]["Total_rooms"].ToString());
                txtReviews.Text = EditHouse.Rows[0]["Reviews"].ToString();
                txt_Address.Text = EditHouse.Rows[0]["Address"].ToString();
                txt_LivingArea.Text = EditHouse.Rows[0]["Living_Area"].ToString();
                txt_Price.Text = EditHouse.Rows[0]["Price"].ToString();
                BuildDate.Value = Convert.ToDateTime(EditHouse.Rows[0]["Built_Date"].ToString());
                
            }
            mycon.Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void lst_HomeAddons_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_DeleteHouse_Click(object sender, EventArgs e)
        {
            cbAgentName.SelectedItem = "";
            cb_Bathrooms.SelectedItem = "";
            cb_Bedrooms.SelectedItem = "";
            cb_ClientName.SelectedItem = "";
            cb_HouseType.SelectedItem = "";
            cb_ListingFor.SelectedItem = "";
            cb_Parking.SelectedItem = "";
            cb_TotalRooms.SelectedItem = "";
            BuildDate.Value = DateTime.Now;
            txtReviews.Text = "";
            txt_Address.Text = "";
            txt_LivingArea.Text = "";
            txt_Price.Text = "";
            
        }
    }
}
