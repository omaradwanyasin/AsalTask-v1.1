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
        public int TaskId { get; set; } 
        public int UserId { get; set; } 
        public string CommentText { get; set; }
        public DateTime CommentDate { get; set; }
       
        public TaskComment()
        {
            CommentDate = DateTime.Now; 
        }
    }
}
