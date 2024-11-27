using LinqJoin;
using System.Threading.Channels;

public class Program 
{
    public static void Main(string[] args)
    {
        List<Author> author = new List<Author>();
        author.Add(new Author { AuthorId = 1, Name = "Orhan Pamuk" });
        author.Add(new Author { AuthorId = 2, Name = "Elif Şafak" });
        author.Add(new Author { AuthorId = 3, Name = "Ahmet Ümit" });


        List<Book> book = new List<Book>();
        book.Add(new Book { BookId = 1, Title = "Kar", AuthorId = 1 });
        book.Add(new Book { BookId = 2, Title = "İstanbul", AuthorId = 1 });
        book.Add(new Book { BookId = 3, Title = "10 Minutes 38 Seconds in This Strange World", AuthorId = 2 });
        book.Add(new Book { BookId = 4, Title = "Beyoğlu Rapsodisi", AuthorId = 3 });

        var result = from b in book
                     join a in author on b.AuthorId equals a.AuthorId
                     select new
                     {
                         BookTitle = b.Title,
                         AuthorName = a.Name
                     };
        foreach (var item in result)
        {
            Console.WriteLine($" Yazar Adı: \t{item.AuthorName}\t\t\n\'Kitap Başlığı: {item.BookTitle}");
        }











    }

}
