using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
  /**
   * To inherit members from another class, we put a colon after the class name
   * then the name of the class that we want to inherit from.
   */
  public class Student : Person
  {
    public enum GradeLevels { Freshman, Sophomore, Junior, Senior };

    public GradeLevels GradeLevel;
  }
}
