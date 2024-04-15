using System.Collections.Generic;
using Domain.Models;

namespace Domain.Services
{
    public interface ITaskCommentService
    {
        TaskComment GetTaskCommentById(int commentId);
        void AddCommentToTask(int taskId, TaskComment comment);
        TaskComment[] GetCommentsForTask(int taskId);
        void DeleteComment(int commentId);
    }
}
