using System;
using System.Collections.Generic;

namespace BookStoreApplication
{
    class BookManagementImp: BookManagement
    {
        static List<Book> bookList = new List<Book>();

        public void addBook()
        {
            Book book = new Book();
            book.bookId = bookList.Count + 1;
            Console.Write("\nEnter Book Name: ");
            book.bookName = Console.ReadLine();
            Console.Write("Enter Book Category: ");
            book.bookCategory = Console.ReadLine();
            bookList.Add(book);

            Console.WriteLine("\nAdded Book Details:");
            Console.WriteLine("Book Id: " + book.bookId);
            Console.WriteLine("Book Name: " + book.bookName);
            Console.WriteLine("Book Category: " + book.bookCategory);
        }

        public void searchBook()
        {
            Console.WriteLine("\nEnter the Book Id to Search: ");
            int searchId = int.Parse(Console.ReadLine());
            if (bookList.Exists(book => book.bookId == searchId))
            {
                Console.WriteLine("\nHere are the book details:");
                foreach (Book books in bookList)
                {
                    if (books.bookId == searchId)
                    {
                        Console.WriteLine("\nBook Id: " + books.bookId + "\n" +
                            "Book Name: " + books.bookName + "\n" +
                            "Book Category: " + books.bookCategory);
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Book with book id " + searchId + " is not available on search");
            }
        }

        public void searchBook(string searchBy, string searchText)
        {
            if (searchBy == "name" && bookList.Exists(book => book.bookName == searchText))
            {
                Console.WriteLine("\nHere are the book details:");
                foreach (Book books in bookList)
                {
                    if (books.bookName == searchText)
                    {
                        Console.WriteLine("\nBook Id: " + books.bookId + "\n" +
                            "Book Name: " + books.bookName + "\n" +
                            "Book Category: " + books.bookCategory);
                        //break;
                    }
                }
            }
            else if(searchBy == "category" && bookList.Exists(book => book.bookCategory == searchText))
            {
                Console.WriteLine("\nHere are the book details:");
                foreach (Book books in bookList)
                {
                    if (books.bookCategory == searchText)
                    {
                        Console.WriteLine("\nBook Id: " + books.bookId + "\n" +
                            "Book Name: " + books.bookName + "\n" +
                            "Book Category: " + books.bookCategory);
                        //break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Book is not available on search");
            }
        }

        public void updateBook()
        {
            Console.Write("\nEnter Book Id to be updated: ");
            int toUpdateId = int.Parse(Console.ReadLine());
            if (bookList.Exists(book => book.bookId == toUpdateId))
            {
                foreach (Book books in bookList)
                {
                    if (books.bookId == toUpdateId)
                    {
                        int updateIndex = bookList.IndexOf(books);
                        Console.Write("Enter the new book name: ");
                        string updateName = Console.ReadLine();
                        Console.Write("Enter the new book category: ");
                        string updateCategory = Console.ReadLine();
                        bookList.Insert(updateIndex, new Book(toUpdateId, updateName, updateCategory));
                        bookList.RemoveAt(updateIndex + 1);
                        Console.Write("\nBook with book id " + toUpdateId + " is Successfully Updated");
                        break;
                    }
                }
            }
            else
            {
                Console.Write("Book with book id " + toUpdateId + " is not available to update");
            }
        }

        public void deleteBook()
        {
            Console.Write("\nEnter Book Id to be Deleted: ");
            int toDeleteId = int.Parse(Console.ReadLine());
            if (bookList.Exists(book => book.bookId == toDeleteId))
            {
                foreach (Book books in bookList)
                {
                    if (books.bookId == toDeleteId)
                    {
                        bookList.RemoveAt(bookList.IndexOf(books));
                        break;
                    }
                }
                Console.Write("Book with book id " + toDeleteId + " is Successfully Deleted");
            }
            else
            {
                Console.Write("Book with book id " + toDeleteId + " is not available to delete");
            }
        }

        public void viewBooks()
        {
            Console.WriteLine("\nAll Available Books:");
            if (bookList.Count != 0)
            {
                Console.WriteLine(String.Format("{0,-8} {1,-10} {2,-10}", "Book Id", "Book Name", "Book Category"));

                foreach (Book books in bookList)
                {
                    Console.WriteLine(String.Format("{0,-8} {1,-10} {2,-10}", books.bookId, books.bookName, books.bookCategory));
                }
            }
            else
            {
                Console.Write("No Books are available to display");
            }
        }
    }
}
