﻿using ApartmentBooking.Model.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApartmentBooking.Model
{
    public class Service
    {
        private CustomerDAL _customerDAL;

        private CustomerDAL CustomerDAL
        {
            get { return _customerDAL ?? (_customerDAL = new CustomerDAL()); }
        }

        public IEnumerable<Customer> GetCustomers()
        {
            return CustomerDAL.GetCustomers();
        }

    }
}