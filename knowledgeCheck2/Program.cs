using System;
using System.Collections.Generic;
using System.Threading;

namespace KnowledgeCheck2
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Genre genre = new Genre();

      Console.WriteLine("How many books do you have? ");
      genre.bookTotal = int.Parse(Console.ReadLine());

      for (int i = 0; i < genre.bookTotal; i++)
      {
      
        Console.WriteLine("Enter in the titles please.");
        genre.AddTitle(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("Please enter in books genre.");
        genre.BookGenre(Console.ReadLine());

        Console.WriteLine($"{Environment.NewLine}The books name is {genre.bookName[i]} and the genre is {genre.bookGenre[i]}.");

      }

      foreach (String item in genre.bookName)
      {
        Console.WriteLine("These are all the titles");
        Console.WriteLine(item);
      }

      Console.WriteLine();

      foreach (String item in genre.bookGenre)
      {
        Console.WriteLine("These are all the Genre's");
        Console.WriteLine(item);
      }
    }
  }
}
