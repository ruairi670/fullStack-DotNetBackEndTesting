using System.ComponentModel.DataAnnotations;

namespace TodoJsAspire.ApiService.Models
{
    public class Todo
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; } = default!;
        public bool IsComplete { get; set; } = false;

        /// <summary>
        /// Used to keep track of the Todo item in the list, so it can be moved up and down
        /// </summary>
        [Required]
        public int Position { get; set; } = 0;
    }
}
