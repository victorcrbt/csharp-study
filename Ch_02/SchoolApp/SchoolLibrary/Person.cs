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
  }
}
