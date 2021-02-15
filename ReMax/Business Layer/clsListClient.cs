using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReMax
{
    class clsListClient
    {
        private Dictionary<string, clsClient> myList;
        public clsListClient()
        {
            myList = new Dictionary<string, clsClient>();
        }

        public int Quantity
        {
            get => myList.Count;

        }

        public Dictionary<string, clsClient>.ValueCollection Elements
        {
            get => myList.Values;

        }

        public bool Add(clsClient client)
        {
            if (Exist(client.clientID) == false)
            {
                myList.Add(client.clientID, client);
                return true;
            }
            else { return false; }
        }

        public bool Delete(string number)
        {
            return myList.Remove(number);
        }

        public clsClient Find(string number)
        {
            if (Exist(number) == true)
            {
                return myList[number];
            }
            else { return null; }

        }

        public bool Exist(string number)
        {
            return myList.ContainsKey(number);
        }


    }
}
