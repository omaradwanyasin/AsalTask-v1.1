using System.Collections.Generic;
using Domain.Models;

namespace Domain.Services
{
    public interface ITaskCategoryService
    {
        TaskCategory GetTaskCategoryById(int categoryId);
        void CreateTaskCategory(TaskCategory category);
        void CreateTaskInCategory(Domain.Models.Task task, int categoryId);
        void UpdateTaskCategory(TaskCategory category);
        void DeleteTaskCategory(int categoryId);
    }
}
