using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<ExpenseHeader> RequestorExpenseHeaders { get; set; }
        public List<ExpenseHeader> ApprovalExpenseHeaders { get; set; }
    }
}
