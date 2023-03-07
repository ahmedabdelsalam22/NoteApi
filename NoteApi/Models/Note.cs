using System.ComponentModel.DataAnnotations;

namespace NoteApi.Models
{
    public class Note
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public string Title { get; set; }
        [MaxLength(2500)]
        public string Content { get; set; }

        public string Date { get; set; }

    }
}
