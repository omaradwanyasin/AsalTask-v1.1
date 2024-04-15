using System.Collections.Generic;
using Domain.Models;

namespace Domain.Services
{
    public interface ITaskCommentService
    {
        
        void AddCommentToTask(int taskId, TaskComment comment);
        List<TaskComment> GetCommentsForTask(int taskId);
        void DeleteComment(int commentId);
    }
}
