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
      private List<int> pageNumber;
      public Totals()
      {
      title = new List<string>() { };
      pageNumber = new List<int>() { };
      }

      public List<string> Title
      {
        get { return title; }
      }

      public List<int> PageNumber
      {
        get { return pageNumber; }
      }

      public void AddTitle(string titles)
      {
        title.Add(titles);
      }
  
      public void AddPage(int number)
      {
        pageNumber.Add(number);
      }
    }
}
