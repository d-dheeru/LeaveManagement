using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveManagement.Web.Data
{
    public class LeaveAllocation: BaseEntity
    {
        
        public int NumberofDays { get; set; }

        [ForeignKey("LeaveTypdeId")]
        public LeaveType LeaveType { get; set; }

        public int LeaveTypeId { get; set; }

        public string EmployeeId { get; set; }


    }
}
