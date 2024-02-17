namespace BookLibrary;

public class BookManager
{
    private readonly List<Book> _books = new();

    public void AddBook(Book book)
    {
        _books.Add(book);
    }

    public void RemoveBook(int bookId)
    {
        _books.RemoveAll(b => b.Id == bookId);
    }

    public void ListBooks()
    {
        foreach (var book in _books)
            Console.WriteLine(
                $"Id: {book.Id}, Title: {book.Title}, Author: {book.Author}, Year: {book.YearOfPublication}");
    }

    public void SearchBooks(string searchTerm)
    {
        var searchResults = _books.Where(b =>
            b.Title.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
            b.Author.Contains(searchTerm, StringComparison.OrdinalIgnoreCase)).ToList();

        if (searchResults.Any())
            foreach (var book in searchResults)
                Console.WriteLine(
                    $"ID: {book.Id}, Title: \"{book.Title}\", Author: {book.Author}, Year: {book.YearOfPublication}");
        else
            Console.WriteLine("No books found matching your search.");
    }
}