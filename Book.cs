
namespace BookStoreApplication
{
    class Book
    {
        public int bookId;
        public string bookName;
        public string bookCategory;

        public Book() { }

        public Book(int bid, string bname, string bcategory)
        {
            bookId = bid;
            bookName = bname;
            bookCategory = bcategory;
        }
    }
}
