using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSheet.Model
{
    public class ProjectTask
    {
        public int ProjectTaskID { get; set; }
        public string Description { get; set; }
        public decimal BudgetAmount { get; set; }
        public decimal BudgetHours { get; set; }
        public bool Chargeable { get; set; }
        public string Notes { get; set; }

        // Related objects
        public int ProjectID { get; set; }
        public Project Project { get; set; }
    }
}
