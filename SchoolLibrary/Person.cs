using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
  /*
   * As usual, abstract classes are classes that cannot be instantiated.
   * They serve only as base classes to be extended.
   */
  public abstract class Person
  {
    public string FirstName;
    public string LastName;
    public string Email;

    /**
     * A abstract method is a method without implementation but thar forces
     * every children class to implement this method, otherwise, the code
     * will not compile.
     */
    public abstract float ComputeGradeAverage();

    /**
     * A virtual method is a method that have implementation on the base class
     * but can be overwriten in any inheriting class with the use of the keyword
     * 'override'. Only abstract and virtual members can be overwriten.
     */
    public virtual string SendMessage(string msg) {
      var sb = new StringBuilder();
      var timeStamp = string.Format("Sent on {0:D} at {0:t}.", DateTime.Now);

      sb.AppendLine(timeStamp);
      sb.AppendLine("");
      sb.AppendLine(string.Format("Dear {0},", FirstName));
      sb.AppendLine(msg);
      
      return sb.ToString();
    }
  }
}
