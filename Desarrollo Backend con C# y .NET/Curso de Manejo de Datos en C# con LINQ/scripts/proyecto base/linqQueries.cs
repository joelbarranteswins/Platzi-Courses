using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

public class LinqQueries
{
    private readonly List<Book> CollectionBook;
    public LinqQueries()
    {
        using StreamReader r = new("books.json");
        string json = r.ReadToEnd();
        CollectionBook = JsonConvert.DeserializeObject<List<Book>>(json) ?? new List<Book>();
    }

    public IEnumerable<Book> GetCollection()
    {
        return CollectionBook;
    }

    public IEnumerable<Book> GetBooksAfter2000()
    {
        //extension method
        //return CollectionBook.FindAll(book => book.PublishedDate.Year > 2000);

        //linq query
        return from book in CollectionBook 
               where book.PublishedDate.Year > 2000 
               select book;
    }

    public IEnumerable<Book> GetBookByPageAndByTitle(int page, string title)
    {
        //extension method
        //return CollectionBook.FindAll(book => book.PageCount > page && book.Title.Contains(title));

        //linq query
        return from book in CollectionBook 
               where (book.PageCount ?? 0) > page && (book.Title?.Contains(title) ?? false) 
               select book;

    }

    public bool AllBooksHasStatus()
    {
        //extension method
        return CollectionBook.TrueForAll(book => book.Status != null);

        //linq query
        // return (from book in CollectionBook where book.Status != null select book).Count() == CollectionBook.Count;
    }

    public bool AnyBookHasBeenPublishByYear(int year)
    {
        //extension method
        return CollectionBook.Exists(book => book.PublishedDate.Year == year);

        //linq query
        // return (from book in CollectionBook where book.PublishedDate.Year == year select book).Any();
    }

    public IEnumerable<Book> GetBooksByCategory(string category)
    {
        //extension method
        return CollectionBook.Where(book => (book.Categories ?? Enumerable.Empty<String>()).Contains(category));

        //linq query
        // return from book in CollectionBook where book.Categories.Contains(category) select book;
    }

    public IEnumerable<Book> GetBooksFilteredByCategoryAndSortedByTitle(string category)
    {
        //extension method
        // return CollectionBook.Where(book => (book.Categories ?? Enumerable.Empty<String>()).Contains(category)).OrderBy(book => book.Title);

        //linq query
        return from book in CollectionBook 
               where (book.Categories ?? Enumerable.Empty<String>()).Contains(category)
               orderby book.Title 
               select book;
    }

    public IEnumerable<Book> GetBooksByPagesAndSortedDescending(int pages)
    {
        //extension method
        // return CollectionBook.Where(book => (book.PageCount ?? 0) > pages).OrderByDescending(book => book.PageCount);

        //linq query
        return from book in CollectionBook 
               where book.PageCount > pages 
               orderby book.PageCount descending 
               select book;
    }

    public IEnumerable<Book> GetThreeFirstBooksByCategoryAndSortedByDate(string category)
    {
        //extension method
        // return CollectionBook.Where(book => (book.Categories ?? Enumerable.Empty<String>()).Contains(category)).OrderBy(book => book.PublishedDate).Take(3);

        //linq query
        // return (from book in CollectionBook 
        //         where (book.Categories ?? Enumerable.Empty<String>()).Contains(category) 
        //         orderby book.PublishedDate descending
        //         select book).Take(3);

        return (from book in CollectionBook 
                where (book.Categories ?? Enumerable.Empty<String>()).Contains(category) 
                orderby book.PublishedDate 
                select book).TakeLast(3);
    }

    public IEnumerable<Book> GetThirdAndFourthBookByPages(int pages)
    {
        //extension method
        // return CollectionBook.Where(book => (book.PageCount ?? 0) > pages).Take(4).Skip(2);

        //linq query
        return (from book in CollectionBook 
                where book.PageCount > pages 
                select book).Take(4).Skip(2);
    }


    public IEnumerable<Book> GetFirstThreeBooks()
    {
        //extension method
        // return CollectionBook.Take(3).Select(book => new Book() {Title = book.Title, PageCount = book.PageCount});

        //linq query
        return (from book in CollectionBook select new Book() {Title = book.Title, PageCount = book.PageCount}).Take(3);
    }


    public int GetBooksBetweenAmountOfPages(int min, int max)
    {
        //extension method
        //return CollectionBook.Where(book => (book.PageCount ?? 0) >= min && (book.PageCount ?? 0) <= max).Count();
        //return CollectionBook.Count(book => (book.PageCount ?? 0) >= min && (book.PageCount ?? 0) <= max);

        //linq query
        return (from book in CollectionBook 
                where (book.PageCount ?? 0) >= min && (book.PageCount ?? 0) <= max 
                select book).Count();
    }


    public DateTime GetMinPublishedDate()
    {
        //extension method
        return CollectionBook.Min(book => book.PublishedDate);

        //linq query
        // return (from book in CollectionBook select book.PublishedDate).Min();
    }

    public int GetPagesFromMaxBookPages()
    {
        //extension method
        return CollectionBook.Max(book => book.PageCount ?? 0);

        //linq query
        // return (from book in CollectionBook select book.PageCount).Max();
    }

    public Book? GetBookWithMinBookPages(){
        //extension method
        // return CollectionBook.Where(book => (book.PageCount ?? 0) > 0).OrderBy(book => book.PageCount).First();
        return CollectionBook
            .Where(book => (book.PageCount ?? 0) > 0)
            .MinBy(book => book.PageCount);
        

        //linq query
        // return (from book in CollectionBook where book.PageCount > 0 orderby book.PageCount select book).MinBy(book => book.PageCount);
    }

    public Book? GetBookMaxPublishedDate()
    {
        //extension method
        return CollectionBook.MaxBy(book => book.PublishedDate);

        //linq query
        // return (from book in CollectionBook select book).MaxBy(book => book.PublishedDate);
    }

    public int GetSumAllPagesByMinAndMaxPages(int min, int max)
    {
        //extension method
        return CollectionBook
            .Where(book => (book.PageCount ?? 0) >= min && (book.PageCount ?? 0) <= max)
            .Sum(book => book.PageCount ?? 0);

        //linq query
        // return (from book in CollectionBook where book.PageCount >= min && book.PageCount <= max select book).Sum(book => book.PageCount);
    }

    public string GetBooksTitleConcatenatedAfterYear(int year)
    {
        //extension method
        // return CollectionBook.Where(
        //     book => book.PublishedDate.Year > year
        //     ).Aggregate("", (BookTitle, next) =>
        //     {
        //         if (BookTitle != string.Empty)
        //             BookTitle += ", " + next.Title;
        //         else
        //             BookTitle += next.Title;
                
        //         return BookTitle;
        //     }
        //     );

        //linq query
        return (from book in CollectionBook 
                where book.PublishedDate.Year > year 
                select book).Aggregate("", (BookTitle, next) =>
                {
                    if (BookTitle != string.Empty)
                        BookTitle += ", " + next.Title;
                    else
                        BookTitle += next.Title;
                    
                    return BookTitle;
                }
                );
    }

    // Methods shared by another user
    public string GetTitleSeparatedByComma(Func<Book, bool> where)
        => string.Join(", ", CollectionBook.Where(where).Select(book => book.Title));

    public string GetTitleSeparatedByCommaV2(Func<Book, bool> where)
    {
        return CollectionBook?
        .Where(where)
        .Select(book => book.Title)
        .Aggregate((acumulator, next) => acumulator + ", " + next)
        ?? "";
    }

    public double GetAverageAmountOfTitlesCharacters()
    {
        //extension method
        // return CollectionBook.Average(book => (book.Title?? "").Length);

        //linq query
        return (from book in CollectionBook select (book.Title ?? "").Length).Average();
    }

    public IEnumerable<IGrouping<int,Book>> GetBooksPublishedAndGroupByYear(int year)
    {
        //extension method
        // return CollectionBook
        //         .Where(book => book.PublishedDate.Year >= year)
        //         .OrderBy(book => book.PublishedDate.Year)
        //         .ThenBy(book => book.PublishedDate.Month)
        //         .GroupBy(book => book.PublishedDate.Year);

        //linq query
        return from book in CollectionBook 
           where book.PublishedDate.Year >= year
           orderby book.PublishedDate.Year, book.PublishedDate.Month
           group book by book.PublishedDate.Year;
    }


    public ILookup<char, Book> GetBooksDictionary()
    {
        //extension method
        return CollectionBook.ToLookup(book => book.Title?.FirstOrDefault() ?? '\0');

        //linq query
        // return (from book in CollectionBook select book).ToLookup(book => book.Title[0]);
    }

    public IEnumerable<Book> GetBooksByYearAndByPages(int year, int pages)
    {
        //extension method
        // var BooksFilteredByYear =  CollectionBook.Where(book => book.PublishedDate.Year > year); 
        // var BooksFilteredByPages = CollectionBook.Where(book => (book.PageCount ?? 0) > pages);
        // return BooksFilteredByYear
        //        .Join(BooksFilteredByPages, 
        //             bookByYear => bookByYear.Title, 
        //             bookByPages => bookByPages.Title, 
        //             (bookByYear, bookByPages) => bookByYear);

        //linq query
        return (from bookByYear in CollectionBook
                where bookByYear.PublishedDate.Year > year
                join bookByPages in CollectionBook on bookByYear.Title equals bookByPages.Title
                where bookByPages.PageCount > pages
                select bookByYear);
    }

    public void PrintValues()
    {
        Console.WriteLine("{0, -60} {1, 9} {2, 15}\n", "Titulo", "N° paginas", "Fecha de Publicación");
        foreach (var book in CollectionBook)
        {
            Console.WriteLine("{0, -60} {1, 9} {2, 15}", book.Title, book.PageCount, book.PublishedDate.ToShortDateString());
        }
    }

    public static void PrintValues(IEnumerable<Book> books)
    {
        Console.WriteLine("{0, -60} {1, 9} {2, 15}\n", "Titulo", "N° paginas", "Fecha de Publicación");
        foreach (var book in books)
        {
            Console.WriteLine("{0, -60} {1, 9} {2, 15}", book.Title, book.PageCount, book.PublishedDate.ToShortDateString());
        }
    }

    public static void PrintGrupo(IEnumerable<IGrouping<int,Book>> BooksGroup)
    {
        foreach(var group in BooksGroup)
        {
            Console.WriteLine("");
            Console.WriteLine($"Grupo: { group.Key }");
            Console.WriteLine("{0,-60} {1, 15} {2, 15}\n", "Titulo", "N. Paginas", "Fecha publicacion");
            foreach(var item in group)
            {
                Console.WriteLine("{0,-60} {1, 15} {2, 15}", item.Title, item.PageCount, item.PublishedDate.Date.ToShortDateString()); 
            }
        }
    }

    public static void PrintDict(ILookup<char, Book> BooksDict, char character)
    {
        Console.WriteLine("");
        Console.WriteLine("{0,-60} {1, 15} {2, 15}\n", "Titulo", "N. Paginas", "Fecha publicacion");
        foreach(var item in BooksDict[character])
        {
            Console.WriteLine("{0,-60} {1, 15} {2, 15}", item.Title, item.PageCount, item.PublishedDate.Date.ToShortDateString()); 
        }
    }
}