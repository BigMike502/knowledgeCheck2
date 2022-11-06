using System;
using System.Collections.Generic;
using System.Threading;
using System.Linq;

namespace KnowledgeCheck2
{
  internal class Program
  {
    static void Main(string[] args)
    {
      

      Console.WriteLine("How many books do you have? ");
      int recordCount = int.Parse(Console.ReadLine());
      Console.WriteLine($"{Environment.NewLine}Press Enter to continue...");
      Console.ReadLine();
      Console.Clear();

      var recordlist = new List<Genre>();
      for (int i = 0; i < recordCount; i++)
      {

        Genre genre = new Genre();
        Console.WriteLine($"Enter in the books Title.");
        genre.bookTitle = Console.ReadLine();

        Console.WriteLine($"{Environment.NewLine}Please enter in {genre.bookTitle} page count.");
        genre.bookPages = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"{Environment.NewLine}{genre.bookTitle} is in what Genre.");
        genre.bookGenre = Console.ReadLine();

        Console.WriteLine($"{Environment.NewLine}Please enter in {genre.bookTitle} publishing year.");
        genre.bookPublish = Convert.ToInt32(Console.ReadLine());
        genre.bookYearsPublished = genre.currentYear - genre.bookPublish;
        Console.WriteLine($"{Environment.NewLine}{genre.bookTitle} is currently {genre.bookYearsPublished}");
        Console.WriteLine($"{Environment.NewLine}Press Enter to continue...");
        Console.ReadLine();
        Console.Clear();

        recordlist.Add(genre);

      }

      IEnumerable<Genre> GetAllBooks()
      {
        return recordlist;
      }

      foreach (var i in GetAllBooks())
      {
        Console.WriteLine($"{Environment.NewLine}The books name is {i.bookTitle} its genre is {i.bookGenre}, it has {i.bookPages}.");
        Console.WriteLine($"{i.bookTitle} was written in {i.bookPublish} it is {i.bookYearsPublished} years old!");
      }

    }
  }
}
