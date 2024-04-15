using System.Collections.Generic;
using Domain.Models;

namespace Domain.Services
{
    public interface ITaskCategoryService
    {
        TaskCategory GetTaskCategoryById(int categoryId);
        void CreateTaskCategory(TaskCategory category);
        void UpdateTaskCategory(TaskCategory category);
        void DeleteTaskCategory(int categoryId);
    }
}
