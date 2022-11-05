using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck2
{
  class Book
  {
    public int bookTotal
    { get; set; }

    public List<string> bookName { get; set; } = new List<string>();
    public void AddTitle(string titles)
    {
      bookName.Add(titles);

    }
  }
}
