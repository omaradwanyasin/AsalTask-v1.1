using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;
using Domain.Services;

namespace Application.Services
{
    public class TaskService : ITaskService
    {
        private readonly List<Domain.Models.Task> _tasks;

        public TaskService()
        {
            _tasks = new List<Domain.Models.Task>(); 
        }

        public Domain.Models.Task GetTaskById(int taskId)
        {
            return _tasks.Find(task => task.Id == taskId);
        }

        public void CreateTask(Domain.Models.Task task)
        {
            // Generate a new ID for the task 
            task.Id = _tasks.Count > 0 ? _tasks[_tasks.Count - 1].Id + 1 : 1;
            _tasks.Add(task);
        }

        public void UpdateTask(Domain.Models.Task task)
        {
            int index = _tasks.FindIndex(t => t.Id == task.Id);
            if (index != -1)
            {
                _tasks[index] = task;
            }
        }

        public void DeleteTask(int taskId)
        {
            _tasks.RemoveAll(task => task.Id == taskId);
        }

    }
}
