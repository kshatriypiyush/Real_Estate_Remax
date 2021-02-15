using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReMax
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }



        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Logout code
            clsGLobalVariables.User.Text = "";
            clsGLobalVariables.dashboard.Visible = false;
            clsGLobalVariables.logout.Visible = false;
            clsGLobalVariables.login.Visible = true;
        }

        private void exitMenu_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit ??", "Exit", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        public void btnFunc(bool Login, bool Logout)
        {
            loginMenu.Visible = Login;
            logoutMenu.Visible = Logout;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            clsGLobalVariables.login = loginMenu;
            clsGLobalVariables.logout = logoutMenu;
            clsGLobalVariables.dashboard = dashboardMenu;
            clsGLobalVariables.User = lblUser;
            clsGLobalVariables.Agents = agentsMenu;
            dashboardMenu.Visible = false;
            agentsMenu.Visible = false;
            logoutMenu.Visible = false;
            
        }

        private void loginMenu_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
        }

        private void viewAgentsMenu_Click(object sender, EventArgs e)
        {
            frmAgentsView frmAgentsView = new frmAgentsView();
            frmAgentsView.Show();
        }

        private void clientsMenu_Click(object sender, EventArgs e)
        {

        }

        private void viewClients_Click(object sender, EventArgs e)
        {
            frmClientsView frmClientsView = new frmClientsView();
            frmClientsView.Show();
        }

        private void viewHousesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHouses frmHouses = new frmHouses();
            frmHouses.Show();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSearch frmSearch = new frmSearch();
            frmSearch.Show();
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void lblUser_Click(object sender, EventArgs e)
        {

        }
    }
}
