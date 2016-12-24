using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSheet.Model
{
    public class Staff
    {
        public int StaffID { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public decimal ChargeRate { get; set; }
        public decimal CostRate { get; set; }
        public string Notes { get; set; }
    }
}
