namespace NTierTodoApp.Models 
{ 
    /// <summary> 
    /// ةمهملا جذومن لثمي. 
    /// </summary> 
    public class TaskItem 
    { 
        public int Id { get; set; } 
        public string Title { get; set; } 
        public bool IsComplete { get; set; } 
    } 
} 