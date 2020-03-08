using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLibrary
{
  /**
   * We can extend other classes that we don't have direct access
   * by creating extension methods.
   */
  public static class ExtensionMethods
  {
    /**
     * The method must be static.
     * 
     * We pass the keyword 'this' to the first parameter. The 'this' keyword
     * refers to the current object, and in this case allows us to associate
     * this class with the class that is extending.
     * 
     * In this case is a string.
     */
    public static int WordCount(this string str) {
      var wordCount = str.Split(new char[] { ' ', '.', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;

      return wordCount;
    }
  }
}
