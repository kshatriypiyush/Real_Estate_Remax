using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace ReMax
{
    public class clsHouse
    {
        private string AgentName;
        private int Bathrooms;
        private int Bedrooms;
        private string ClientName;
        private string HouseType;
        private string ListingFor;
        private int Parking;
        private int TotalRooms;
        private string Reviews;
        private string Address;
        private string LivingArea;
        private string Price;
        private DateTime BuildDate;

        SqlConnection mycon = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=RemaxDt;Integrated Security=True");
        public void House_Set(string AgentName,int Bathrooms,int Bedrooms,string ClientName,string HouseType,string ListingFor,
        int Parking,int TotalRooms,string Reviews,string Address,string LivingArea,string Price,DateTime BuildDate)
        {
       this.AgentName=AgentName;
       this.Bathrooms=Bathrooms;
       this.Bedrooms=Bedrooms;
       this.ClientName=ClientName;
       this.HouseType=HouseType;
       this.ListingFor=ListingFor;
       this.Parking=Parking;
       this.TotalRooms=TotalRooms;
       this.Reviews=Reviews;
       this.Address=Address;
       this.LivingArea=LivingArea;
       this.Price=Price;
       this.BuildDate=BuildDate;
    }
        public void House_Add()
        {
            SqlCommand mycmdHouses = new SqlCommand("INSERT INTO Houses (Bathroom, Bedrooms, Total_rooms, Living_Area, Parking, Built_Date, Price, Address," +
                       "Reviews,refEmployee,ClientName,Listing,HouseType)" +
                       " VALUES('" + Bathrooms + "','" + Bedrooms + "','" + TotalRooms + "','" + LivingArea + "'," +
                       "'" + Parking + "','" + BuildDate.ToString("dd-MMM-yyyy") +
                       "','" + Price + "','" + Address + "','" + Reviews + "','" + AgentName + "','" + ClientName +
                       "','" + ListingFor + "','" + HouseType + "')", mycon);
            SqlDataAdapter daAddHouses = new SqlDataAdapter(mycmdHouses);
            var dsHousesAdd = new DataSet();
            daAddHouses.Fill(dsHousesAdd);
        }

        public void House_Update()
        {
            string cmd = "UPDATE Houses SET Bathroom ='" + Bathrooms + "', Total_rooms ='" + TotalRooms +
                      "', Living_Area ='" + LivingArea + "', Parking ='" + Parking +
                      "', Address ='" + Address + "', Built_Date = '" + BuildDate.ToString("dd-MMM-yyyy") +
                      "', Price ='" + Price + "', Reviews = '" + Reviews +
                      "', ClientName ='" + ClientName + "', Listing = '" + ListingFor + "', HouseType = '" + HouseType +
                      "', Bedrooms ='" + Bedrooms + "', refEmployee ='" + AgentName + "' WHERE HouseID = " + Convert.ToInt32(clsGLobalVariables.Id);

            SqlCommand mycmdeditHouses = new SqlCommand(cmd, mycon);
            SqlDataAdapter daeditHouses = new SqlDataAdapter(mycmdeditHouses);
            var dsHousesEdit = new DataSet();
            daeditHouses.Fill(dsHousesEdit);
        }

        public void House_Remove()
        {
            mycon.Open();
            SqlCommand mycmddeleteHouses = new SqlCommand("DELETE FROM Houses WHERE HouseID =" + Convert.ToInt32(clsGLobalVariables.Id.ToString()), mycon);
            SqlDataAdapter daHousesdelete = new SqlDataAdapter(mycmddeleteHouses);
            var dsHousesdelete = new DataSet();
            daHousesdelete.Fill(dsHousesdelete);
            mycon.Close();
        }

        public DataTable House_List()
        {
            mycon.Open();

            DataTable dtHouses = new DataTable();
            //dtClients = clsGLobalVariables.myset.Tables["Clients"];

            SqlCommand mycmdHouseFetch = new SqlCommand("SELECT * FROM Houses ", mycon);
            SqlDataAdapter daHouseFetch = new SqlDataAdapter(mycmdHouseFetch);
            var dsHouse = new DataSet();
            daHouseFetch.Fill(dsHouse);

            mycon.Close();
            return dsHouse.Tables[0];
           
        }
    }
}