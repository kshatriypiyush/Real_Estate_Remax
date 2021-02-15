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
    public partial class frmClientsView : Form
    {
        public frmClientsView()
        {
            InitializeComponent();
        }
        SqlConnection mycon = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=RemaxDt;Integrated Security=True");
        clsClient Client = new clsClient();
        private void frmClientsView_Load(object sender, EventArgs e)
        {
            dataResultClient.DataSource= Client.Client_List();
        }

        private void btn_AddClient_Click(object sender, EventArgs e)
        {
            clsGLobalVariables.method = "add";
            frmClient frmClientAdd = new frmClient();
            frmClientAdd.Show();
            this.Close();
        }

        private void dataResultClient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_EditClient_Click(object sender, EventArgs e)
        {
            try
            {
                clsGLobalVariables.method = "edit";
                clsGLobalVariables.Id = dataResultClient.SelectedRows[0].Cells[0].Value.ToString();
                frmClient frmClientAdd = new frmClient();
                frmClientAdd.Show();
            }
            catch
            {
                MessageBox.Show("Please Select the Row of Client you want to edit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            this.Close();
        }

        private void btn_DeleteClient_Click(object sender, EventArgs e)
        {
            clsGLobalVariables.Id = dataResultClient.SelectedRows[0].Cells[0].Value.ToString();

            Client.Client_Remove();
            this.Close();
            MessageBox.Show("The Client has been deleted!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frmClientsView client = new frmClientsView();
            client.Show();
            
        }
    }
}
