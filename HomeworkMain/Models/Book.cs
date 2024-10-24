using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HomeworkMain.Models
{
	public class Book
	{
		[Key]
		public int Id { get; set; }
		public string Title { get; set; }
		public Genre Genre { get; set; }
		public string Author { get; set; }

		public Book() { }
	}
}
