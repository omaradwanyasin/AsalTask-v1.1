using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace Domain.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsCompleted { get; set; }
        public int CategoryId { get; set; } // Foreign key for TaskCategory
        public List<TaskAssignment> Assignments { get; set; }
        public List<TaskComment> Comments { get; set; }

        public Task()
        {
            Assignments = new List<TaskAssignment>();
            Comments = new List<TaskComment>();
        }
    }
}
