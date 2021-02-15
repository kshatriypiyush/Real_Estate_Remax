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
    public partial class frmHouses : Form
    {
        public frmHouses()
        {
            InitializeComponent();
        }
        clsHouse Home = new clsHouse();


        private void btn_AddHouse_Click(object sender, EventArgs e)
        {
            clsGLobalVariables.method = "add";
            this.Close();
            frmHouseAdd frmHouseAdd = new frmHouseAdd();
            frmHouseAdd.Show();
            
        }

        private void frmHouses_Load(object sender, EventArgs e)
        {
            dataHouses.DataSource = Home.House_List();
        }

        private void dataHouses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_EditHouse_Click(object sender, EventArgs e)
        {
            clsGLobalVariables.method = "edit";
            
            try
            {
                clsGLobalVariables.Id = dataHouses.SelectedRows[0].Cells[0].Value.ToString();
                frmHouseAdd frmHouseAdd = new frmHouseAdd();
                frmHouseAdd.Show();
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Please Select the Row of House you want to edit","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
        
            }
            
        }

        private void btn_DeleteHouse_Click(object sender, EventArgs e)
        {
            try
            {
                clsGLobalVariables.Id = dataHouses.SelectedRows[0].Cells[0].Value.ToString();
                Home.House_Remove();
                this.Close();
                MessageBox.Show("The Houses has been deleted!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmHouses house = new frmHouses();
                house.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Select appropriate row","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
