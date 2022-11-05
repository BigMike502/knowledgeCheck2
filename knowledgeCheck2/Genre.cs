using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck2
{
  class Genre : Book
  {
    public List<string> bookGenre { get; set; } = new List<string>();

    public void BookGenre(string value)
    {
      bookGenre.Add(value);
    }

  }
}
