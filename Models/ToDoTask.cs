using System.ComponentModel.DataAnnotations;

namespace BlazorDeepDive.Models
{
    public class ToDoTask
    {

        public int TaskId { get; set; }

        private bool _isCompleted;
        public bool IsCompleted
        { 
            
            get => _isCompleted; 
            
            set
            { 
                
                _isCompleted = value; 
                
                if (value)
                {
                    CompletedDate = DateOnly.FromDateTime(DateTime.Now);
                } 
            } 

        }

        [Required]
        public string? Name { get; set; }

        public DateOnly CompletedDate { get; set; }

    }
}
