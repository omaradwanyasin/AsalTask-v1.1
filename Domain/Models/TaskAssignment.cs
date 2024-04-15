using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    // in this class will hold the information about the user and the task that assigned to him
    public class TaskAssignment
    {
        public int Id { get; set; }
        public int TaskId { get; set; } 
        public int UserId { get; set; } 
        public DateTime AssignmentDate { get; set; }
        public TaskAssignment()
        {
            AssignmentDate = DateTime.Now;
        }

    }
}
