using HomeworkMain.Models;
using System.Collections.Generic;

public class BookViewModel
{
    public Book Book { get; set; }
    public List<Review> Reviews { get; set; }
    public int Rating { get; set; }
    public string ReviewText { get; set; }

    public BookViewModel()
    {
        Reviews = new List<Review>();
    }
}
