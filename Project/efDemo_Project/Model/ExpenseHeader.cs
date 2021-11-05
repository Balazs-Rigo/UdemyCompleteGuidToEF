using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    public class ExpenseHeader
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="{0} is required")]
        [MaxLength(100,ErrorMessage ="{0} can not be more then 100 characters")]
        [MinLength(10)]
        public string Desription { get; set; }
        public DateTime? ExpenseDate { get; set; }
        [ForeignKey("Requestor")]
        public int RequestorId { get; set; }
        [InverseProperty("RequestorExpenseHeaders")]
        public User Requestor { get; set; }
        [ForeignKey("Approver")]
        public int ApproverId { get; set; }
        [InverseProperty("ApprovalExpenseHeaders")]
        public User Approver { get; set; }
        public List<ExpenseLine> ExpenseLines { get; set; }

    }
}
