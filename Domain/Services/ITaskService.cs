using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;

namespace Domain.Services
{
    public interface ITaskService
    {
        Domain.Models.Task GetTaskById(int taskId);
        void CreateTask(Domain.Models.Task task);
        void UpdateTask(Domain.Models.Task task);
        void DeleteTask(int taskId);
        void AssignTask(int taskId, int userId);
        void AddCommentToTask(int taskId, TaskComment comment);
        Domain.Models.Task[] GetTasksByCategory(int categoryId);
        Domain.Models.Task[] GetTasksAssignedToUser(int userId);
    }
}
