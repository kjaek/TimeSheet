using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSheet.Model
{
    public class StaffProject
    {
        public int StaffProjectID { get; set; }
        public string Role { get; set; }
        public decimal ChargeRate { get; set; }
        public decimal CostRate { get; set; }
    }
}
