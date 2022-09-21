using System.ComponentModel.DataAnnotations;

namespace Taskeroni.Models
{
    public class NewTasks
    {
        [Required]
        public int id { get; set; }

        public string TaskName { get; set; }

        public int TaskStatus{ get; set; }
    }
}
