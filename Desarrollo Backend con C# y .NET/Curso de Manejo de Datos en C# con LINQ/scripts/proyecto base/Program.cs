// See https://aka.ms/new-console-template for more information

LinqQueries queries = new();
// var books = queries.GetBooksAfter2000();
var booksWith250Pages = queries.GetBookByPageAndByTitle(250, "in Action");
LinqQueries.PrintValues(booksWith250Pages);

Console.WriteLine($"All books has status: {queries.AllBooksHasStatus()}");
Console.WriteLine($"Any book has been publish by year 1950: {queries.AnyBookHasBeenPublishByYear(1950)}");

var booksByCategory = queries.GetBooksByCategory("Python");
LinqQueries.PrintValues(booksByCategory);

var booksFilteredAndSorted = queries.GetBooksFilteredByCategoryAndSortedByTitle(category: "Java");
LinqQueries.PrintValues(booksFilteredAndSorted);

var booksFilteredAndSortedDescending = queries.GetBooksByPagesAndSortedDescending(pages: 450);
LinqQueries.PrintValues(booksFilteredAndSortedDescending);

var booksFirstThreeBooksByCategory = queries.GetThreeFirstBooksByCategoryAndSortedByDate("Java");
LinqQueries.PrintValues(booksFirstThreeBooksByCategory);

var thirdAndFourthBookByPages = queries.GetThirdAndFourthBookByPages(pages: 400);
LinqQueries.PrintValues(thirdAndFourthBookByPages);

var threeFirstBooks = queries.GetFirstThreeBooks();
LinqQueries.PrintValues(threeFirstBooks);

var CountBooks = queries.GetBooksBetweenAmountOfPages(min: 200, max: 500);
Console.WriteLine($"Count books between 200 and 500 pages: {CountBooks}");

var MinPublishedDate = queries.GetMinPublishedDate();
Console.WriteLine($"Min published date: {MinPublishedDate.ToShortDateString()}");

var PagesFromMaxBookPages = queries.GetPagesFromMaxBookPages();
Console.WriteLine($"Pages from max book pages: {PagesFromMaxBookPages}");

var BookWithMinBookPages = queries.GetBookWithMinBookPages();
if (BookWithMinBookPages != null)
    Console.WriteLine($"Book with min book pages: {BookWithMinBookPages.Title} {BookWithMinBookPages.PageCount}");

var GetBookMaxPublishedDate = queries.GetBookMaxPublishedDate();
if (GetBookMaxPublishedDate != null)
    Console.WriteLine($"Book with max published date: {GetBookMaxPublishedDate.Title} {GetBookMaxPublishedDate.PublishedDate.ToShortDateString()}");

var SumAllPagesByMinAndMaxPages = queries.GetSumAllPagesByMinAndMaxPages(min: 0, max: 500);
Console.WriteLine($"Sum all pages by min and max pages: {SumAllPagesByMinAndMaxPages}");

var BooksTitleConcatenatedAfterYear = queries.GetBooksTitleConcatenatedAfterYear(year: 2015);
Console.WriteLine($"Books title concatenated after year: {BooksTitleConcatenatedAfterYear}");

// Func Expresión
Func<Book, bool> ConditionWhere = (x => x.PublishedDate.Year > 2015 && x.Title != string.Empty);
var BooksTitleSeparatedByComma = queries. GetTitleSeparatedByComma(ConditionWhere);
Console.WriteLine($"Books title separated by comma: {BooksTitleSeparatedByComma}");

var BooksTitleSeparatedByCommaV2 = queries.GetTitleSeparatedByCommaV2(ConditionWhere);
Console.WriteLine($"Books title separated by comma v2: {BooksTitleSeparatedByCommaV2}");


var AverageAmountOfTitlesCharacters = queries.GetAverageAmountOfTitlesCharacters();
Console.WriteLine($"Average amount of titles characters: {AverageAmountOfTitlesCharacters}");

var BooksPublishedAndGroupByYear = queries.GetBooksPublishedAndGroupByYear(year: 2000);
LinqQueries.PrintGrupo(BooksGroup: BooksPublishedAndGroupByYear);

var BooksDictionaryByVowel = queries.GetBooksDictionary();
LinqQueries.PrintDict(BooksDict: BooksDictionaryByVowel, character: 'P');

var BooksByYearAndByPages = queries.GetBooksByYearAndByPages(year: 2005, pages: 500);
LinqQueries.PrintValues(BooksByYearAndByPages);