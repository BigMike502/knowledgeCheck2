using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck2
{
    public class Totals
    {
      private List<string> title;
      private List<string> pageNumber;
      public Totals()
      {
      title = new List<string>() { };
      pageNumber = new List<string>() { };
      }

      public List<string> Title
      {
        get { return title; }
      }

      public List<string> PageNumber
      {
        get { return pageNumber; }
      }

      public void AddTitle(string titles)
      {
        title.Add(titles);
      }
  
      public void AddPage(string number)
      {
        pageNumber.Add(number);
      }
    }
}
