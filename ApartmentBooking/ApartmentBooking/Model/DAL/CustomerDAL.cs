using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace ApartmentBooking.Model.DAL
{
    public class CustomerDAL
    {
        private static readonly string _connectionString;

        //Konstruktor
        //Hämtar anslutningssträng från web.config
        static CustomerDAL()
        {
            _connectionString = WebConfigurationManager.ConnectionStrings["ApartmentBookingConnectionString"].ConnectionString; 
        }

        private static SqlConnection CreateConnection()
        {
            return new SqlConnection(_connectionString);
        }

        public IEnumerable<Customer> GetCustomers()
        {
           
            using (var connection = CreateConnection())
            {
                var customers = new List<Customer>(75);

                var command= new SqlCommand("appSchema.usp_getCustomers", connection);
                command.CommandType = CommandType.StoredProcedure;

                connection.Open();

                using(var reader = command.ExecuteReader())
                {
                    var customerIdIndex = reader.GetOrdinal("CustomerId");
                    var firstNameIndex = reader.GetOrdinal("FirstName");
                    var lastNameIndex = reader.GetOrdinal("LastName");
                    var addressIndex = reader.GetOrdinal("Address");
                    var postalCodeIndex = reader.GetOrdinal("PostalCode");
                    var cityIndex = reader.GetOrdinal("City");

                    while (reader.Read())
                    {
                        customers.Add(new Customer
                            {
                                CustomerId = reader.GetInt32(customerIdIndex),
                                FirstName = reader.GetString(firstNameIndex),
                                LastName = reader.GetString(lastNameIndex),
                                Address = reader.GetString(addressIndex),
                                PostalCode = reader.GetString(postalCodeIndex),
                                City = reader.GetString(cityIndex),
                            });
                    }

                }

                customers.TrimExcess();

                return customers;
            }
        }
    }
}