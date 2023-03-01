using System;
namespace book_store.Model
{
	public class Book
	{
        public long bookID { get; set; }
        public string? bookTitle { get; set; }
        public string? description { get; set; }
        public string? author { get; set; }
        public int quantity { get; set; }
        public int price { get; set; }
    }
}

