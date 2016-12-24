using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSheet.Model
{
    public class Project
    {
        public int ProjectID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public decimal BudgetAmount { get; set; }
        public bool Chargeable { get; set; }
        public string Notes { get; set; }

        // Related objects
        public virtual List<ProjectTask> ProjectTasks { get; set; }
    }
}
