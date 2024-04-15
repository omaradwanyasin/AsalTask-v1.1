using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class TaskComment
    {
        public int Id { get; set; }
        public int TaskId { get; set; } // Foreign key for Task
        public int UserId { get; set; } // Foreign key for User
        public string CommentText { get; set; }
        public DateTime CommentDate { get; set; }
       
        public TaskComment()
        {
            CommentDate = DateTime.Now; // Set the comment date to the current date and time by default
        }
    }
}
