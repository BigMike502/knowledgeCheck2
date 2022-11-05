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

      var recordlist = new List<Genre>();
      for (int i = 0; i < recordCount; i++)
      {

        Genre genre = new Genre();
        Console.WriteLine("Enter in the books Title.");
        genre.bookTitle = Console.ReadLine();
        Console.WriteLine();

        Console.WriteLine($"Please enter in {genre.bookTitle} page count.");
        genre.bookPages = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

        Console.WriteLine($"Please enter in {genre.bookTitle} publishing year.");
        genre.bookPublish = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"{genre.bookTitle} is currently {genre.currentYear - genre.bookPublish}");
        Console.WriteLine();

        Console.WriteLine($"{genre.bookTitle}is in what Genre.");
        genre.bookGenre = Console.ReadLine();

        //Console.WriteLine($"{Environment.NewLine}The books name is {genre.bookName[i]} and the genre is {genre.bookGenre[i]}.");

        recordlist.Add(Genre);

      }

      //foreach (String item in genre.bookName)
      //{
      //  Console.WriteLine("These are all the titles");
      //  Console.WriteLine(item);
      //}

      //Console.WriteLine();

      //foreach (String item in genre.bookGenre)
      //{
      //  Console.WriteLine("These are all the Genre's");
      //  Console.WriteLine(item);
      //}
    }
  }
}
