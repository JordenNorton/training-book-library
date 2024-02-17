using BookLibrary;

namespace BookLibrary;

class Program
{
static BookManager bookManager = new BookManager();

    static void Main(string[] args)
        {
            bool continueRunning = true;
            while (continueRunning)
            {
                Console.WriteLine("What would you like to do? \n 1: Add book \n 2: Remove Book \n 3: Show all \n 4: Find Book \n 5: Exit");
                int choice = int.TryParse(Console.ReadLine(), out int result) ? result : 0;

                switch (choice)
                {
                    case 1:
                        AddBook();
                        break;
                    case 2:
                        RemoveBook();
                        break;
                    case 3:
                        ListBooks();
                        break;
                    case 4:
                        FindBook();
                        break;
                    case 5:
                        continueRunning = false;
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please select a valid option.");
                        break;
                }
            }
        }

        static void AddBook()
        {
            Console.WriteLine("Enter ID");
            int id = int.TryParse(Console.ReadLine(), out int idResult) ? idResult : 0;
            Console.WriteLine("Enter Title");
            string title = Console.ReadLine();
            Console.WriteLine("Enter Author");
            string author = Console.ReadLine();
            Console.WriteLine("Enter Year of Publication");
            int year = int.TryParse(Console.ReadLine(), out int yearResult) ? yearResult : 0;

            bookManager.AddBook(new Book { Id = id, Title = title, Author = author, YearOfPublication = year });
            Console.WriteLine("Book added successfully!");
        }

        static void RemoveBook()
        {
            Console.WriteLine("Enter Book ID");
            int id = int.TryParse(Console.ReadLine(), out int idResult) ? idResult : 0;
            bookManager.RemoveBook(id);
            Console.WriteLine("Book removed successfully!");
        }

        static void ListBooks()
        {
            bookManager.ListBooks();
        }

        static void FindBook()
        {
            Console.WriteLine("Enter search term:");
            string searchTerm = Console.ReadLine();
            bookManager.SearchBooks(searchTerm);
        }
}