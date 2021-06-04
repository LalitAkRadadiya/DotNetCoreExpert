using System.ComponentModel.DataAnnotations;

namespace DNC.DAL.Database
{
    public class ToDoList
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public bool IsCompleted { get; set; }
    }
}