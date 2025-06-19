using System.Collections.Generic; 
using System.Linq; 
using NTierTodoApp.Models;

namespace NTierTodoApp.DataAccess
{
    /// <summary> 
    /// ةركاذلا يف ةمئاق مادختساب ماهملا ةرادلإ تانايبلا عدوتسم. 
    /// </summary> 
    public class TaskRepository
    {
        private List<TaskItem> tasks = new List<TaskItem>
        {
            new TaskItem { Id = 1, Title = "ىلوأ ةمهم", IsComplete = false },
            new TaskItem { Id = 2, Title = "ةيناث ةمهم", IsComplete = false }
        };

        public List<TaskItem> GetAll() => tasks;
        public void Add(TaskItem task)
        {
            tasks.Add(task);
        }

        public TaskItem GetById(int id)
        {
            return tasks.FirstOrDefault(t => t.Id == id);
        }

        // TODO:  ةمهملا فذح ةلاد ذيفنت 
        public void Delete(int id)
        {
            var task = tasks.FirstOrDefault(t => t.Id == id);
            if (task != null)
                tasks.Remove(task);
        }
       }
    }
