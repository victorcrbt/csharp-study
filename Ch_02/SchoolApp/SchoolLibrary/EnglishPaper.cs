using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
  public class EnglishPaper
  {
    public string Title;
    public int MinimumWordCount;
    public string PaperText;
    public int WordCount {
       /**
        * We can then use the extended method as long as it is in the
        * same namespace.
        */
      get { return PaperText.WordCount(); }
    }
  }
}
