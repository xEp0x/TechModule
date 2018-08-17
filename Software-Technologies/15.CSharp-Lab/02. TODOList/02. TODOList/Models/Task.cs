using System.ComponentModel.DataAnnotations;

namespace _02.TODOList.Models
{
    public class Task
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }
    }
}