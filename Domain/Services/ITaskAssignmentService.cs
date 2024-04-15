using System.Collections.Generic;
using Domain.Models;

namespace Domain.Services
{
    public interface ITaskAssignmentService
    {
        TaskAssignment GetTaskAssignmentById(int assignmentId);
        void AssignTask(int taskId, int userId);
        TaskAssignment[] GetAssignmentsForTask(int taskId);
        TaskAssignment[] GetAssignmentsByUser(int userId);
        void RemoveAssignment(int assignmentId);
    }
}
