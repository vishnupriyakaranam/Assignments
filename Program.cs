using System;

namespace BookStoreApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            BookManagementImp bookManagementImp = new BookManagementImp();
            Console.WriteLine("\nWelcome to Books World");
            bool next = true;
            while (next)
            {
                Console.WriteLine("\n--------------------------------------------------------------");
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Search Book");
                Console.WriteLine("3. Update Book");
                Console.WriteLine("4. Delete Book");
                Console.WriteLine("5. View Available Books");
                Console.WriteLine("6. Exit");
                Console.WriteLine("\nChoose your option from the above Menu:");
                String option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        bookManagementImp.addBook();
                        break;
                    case "2":
                        Console.WriteLine("\nSearch Book by :\n1. Book Id\n2. Book Name\n3. Book Category\n\nEnter choice of search:");
                        string opt = Console.ReadLine();
                        switch (opt)
                        {
                            case "1":
                                bookManagementImp.searchBook();
                                break;
                            case "2":
                                Console.WriteLine("\nEnter Book Name to search:");
                                bookManagementImp.searchBook("name",Console.ReadLine());
                                break;
                            case "3":
                                Console.WriteLine("\nEnter Book Category to search:");
                                bookManagementImp.searchBook("category",Console.ReadLine());
                                break;
                            default:
                                break;
                        }
                        
                        break;
                    case "3":
                        bookManagementImp.updateBook();
                        break;
                    case "4":
                        bookManagementImp.deleteBook();
                        break;
                    case "5":
                        bookManagementImp.viewBooks();
                        break;
                    case "6":
                        next = false;
                        Console.Clear();
                        Console.WriteLine("\nThankyou for your time. Have a great day!\n");
                        break;
                    default:
                        Console.WriteLine("\nEnter a valid option from the menu");
                        break;
                }
            }
        }
    }
}
