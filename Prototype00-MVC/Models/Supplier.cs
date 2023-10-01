using System.Net;

namespace Prototype00_MVC.Models
{
    public class Supplier
    {
        public string? SupplierID { get; set; }
        public string? SupplierName { get; set;}
        public string? Phone { get; set; }
        public string? Username { get; set; }
        public string?  Password { get; set; }

        public Supplier(string? supplierID, string? supplierName, string? phone)
        {
            SupplierID = supplierID;
            SupplierName = supplierName;
            Phone = phone;
            
        }

        public Supplier(string? username, string? password)
        {
            Username = username;
            Password = password;
        }
    }
}
