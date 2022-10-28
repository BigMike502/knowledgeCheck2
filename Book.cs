using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck2
{
  class Book
  {
    public static void BookData()
    {
      Totals info = new Totals();

      int totalofBooks;

      Console.WriteLine("Lets get some info about your favorite books!\r\nHow many books would you like to enter?");
      totalofBooks = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine();

      for (int total = 0; total != totalofBooks; total++)
      {
        Console.WriteLine("Enter in the name of the book!");
        info.AddTitle(Console.ReadLine());
        Console.WriteLine($"Enter in the page total for {info.Title[total]}.");
        info.AddPage(Console.ReadLine());
        Console.WriteLine($"The book {info.Title[total]} has {info.PageNumber[total]} Pages!\r\n");
      }

      Console.WriteLine($"There are {info.Title.Count} Titles in the list.\r\nThere are {info.PageNumber.Count} Pages in the List.\r\n");
      
      Console.WriteLine();

      for (int i = 0; i != totalofBooks; i++)
      {
        Console.WriteLine($"{info.Title[i]} : {info.PageNumber[i]}");
      }
    }   
  }
}
