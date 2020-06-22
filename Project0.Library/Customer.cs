using System;
using System.Collections.Generic;
using System.Text;

namespace Project0.Library
{
    /// <summary>
    /// A customer places orders to a store.
    /// Has a default store if set.
    /// </summary>
    public class Customer
    {
        public int ID { get; }
        public string Firstname { get; }

        public string Lastname { get; }

        public string Name
        { 
            get => $"{Firstname} {Lastname}";
        }

        public int StoreID { get; set; }

        public Customer(int id, string firstname, string lastname)
        {
            ID = id;
            Firstname = firstname;
            Lastname = lastname;
        }
    }
}
