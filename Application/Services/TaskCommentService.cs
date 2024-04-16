using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;
using Domain.Services;

namespace Application.Services
{
    public class TaskCommentService : ITaskCommentService
    {
        private readonly Dictionary<int, List<TaskComment>> _taskCommentsMap;
        public void AddCommentToTask(int taskId, TaskComment comment)
        {
            if(!_taskCommentsMap.ContainsKey(taskId))
            {
                _taskCommentsMap[taskId] = new List<TaskComment>();
            }
            _taskCommentsMap[taskId].Add(comment);
        }
        //application busniss data //dto//not exist norable //entities => table in database//mapping  // 3 layers
        //controlesrs statless
        public void DeleteComment(int commentId)
        {
            foreach (var taskComments in _taskCommentsMap.Values)
            {
                var commentToRemove = taskComments.Find(comment => comment.Id == commentId);
                if (commentToRemove != null)
                {
                    taskComments.Remove(commentToRemove);
                    return;
                }
            }

            throw new ArgumentException($"Comment with ID {commentId} not found.");
        }
      

        public List<TaskComment> GetCommentsForTask(int taskId)
        {
            if (_taskCommentsMap.ContainsKey(taskId))
            {
                return _taskCommentsMap[taskId];
            }

            return new List<TaskComment>();
        }

      
        public void RemoveComment(int commentId)
        {
            foreach (var taskComments in _taskCommentsMap.Values)
            {
                var commentToRemove = taskComments.Find(comment => comment.Id == commentId);
                if (commentToRemove != null)
                {
                    taskComments.Remove(commentToRemove);
                    return;
                }
            }

            throw new ArgumentException($"Comment with ID {commentId} not found.");
        }
    }
}
