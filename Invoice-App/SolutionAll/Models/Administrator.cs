using System.Collections.Generic;

namespace Models
{
    public class Administrator : Person
    {
        public List<Invoice> Invoice { get; set; }
        public CompanyEnum Company { get; set; }
        
        public Administrator(string firstName, string lastName, string userName, string password, CompanyEnum company, RoleEnum role)
            : base (firstName, lastName, userName, password, role)
            
        {
            Company = company;
            Invoice = new List<Invoice>();
        }
    }
}
