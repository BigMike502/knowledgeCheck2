﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck2
{
  class Book
  {
    public string bookTitle { get; set; }
    public int bookPages { get; set; }
    public int bookPublish { get; set; }
    public int currentYear = Convert.ToInt32(DateTime.Now.Year.ToString());
    public int bookYearsPublished { get; set; }


    //public List<string> bookName { get; set; } = new List<string>();
    //public void AddTitle(string titles)
    //{
    //  bookName.Add(titles);

    //}
  }
}
