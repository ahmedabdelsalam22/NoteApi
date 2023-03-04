using System.ComponentModel.DataAnnotations;

namespace NoteApi.Dtos
{
    public class NoteDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Time { get; set; }
        public string Date { get; set; }

    }
}
