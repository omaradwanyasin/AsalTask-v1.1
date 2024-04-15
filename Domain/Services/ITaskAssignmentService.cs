using System.Collections.Generic;
using Domain.Models;

namespace Domain.Services
{
    public interface ITaskAssignmentService
    {
        TaskAssignment GetTaskAssignmentById(int assignmentId);
        void AssignTask(int taskId, int userId);
        void RemoveAssignment(int assignmentId);
        
    }
}
