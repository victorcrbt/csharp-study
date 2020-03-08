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
    
    /**
     * To implement a base class absrtract method, we need to put the 'override'
     * keyword before the return type. If we don't do that, the code will not
     * compile, because we would be just creating another method with the same
     * name and not overriding the base class one.
     */
    public override float ComputeGradeAverage()
    {
      return 7.12f;
    }
  }
}
