using System;
using System.Text;

namespace SchoolLibrary 
{
  public class School
  {
    // Public modifiers expose the member to child classes and instance of the class.
    public string Name { get; set; } // This is called an auto property. Basically defines getter and setter for that property automatically.
    public string Address { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Zip { get; set; }
    public string PhoneNumber { get; set; }

    // Private members cannot be acessed or modified outside from the base class.
    private string _twitterAddress;
    string TwitterAddress 
    {
      // Make sure that twitter address starts with @
      get { return _twitterAddress; }

      set
      {
        // The value comes automatically in the context of getters and setters
        if (value.StartsWith("@"))
        {
          _twitterAddress = value;
        }
        else
        {
          throw new Exception("The Twitter address must begin with and @.");
        }
      }
    }

    // To define a class constructor, we create a public method with the exact same name of the class.
    public School()
    {
      Name = "Untitled School";
      PhoneNumber = "555-1234";
    }

    /*
     *  Static methods act just like in other languages. They are methods that can be accessed only by
     *  the class side and not for the instance. That is, when we use the reserved word 'new' to instantiate 
     *  the class, we will not have access to the static methods in that instance.
     */

    /*
     * This is a overload for the constructor.
     * 
     * We define another constructor with the same name that different arguments (number of arguments or
     * types) so we can deal with the arguments in the proper way.
     */
    public School(string schoolName, string schoolPhoneNumber)
    {
      Name = schoolName;
      PhoneNumber = schoolPhoneNumber;
    }

    /*
     * Define methods works about the same way as constructores, with the difference that if the method has a return,
     * pass inform the return type right after the method's name.
     */
    public static float AverageThreeScores(float score1, float score2, float score3)
    {
      float average = (score1 + score2 + score3) / 3;

      return average;
    }


    // Like in constructors, this is an overload for the method. Works the same way as constructors.
    public static int AverageThreeScores(int score1, int score2, int score3)
    {
      int average = (score1 + score2 + score3) / 3;

      return average;
    }

    /*
     *  This is call bodied expression.
     *  
     *  We write our code like an arrow function of JavaScript, but can only write the return, not the
     *  function block.
     */
    public static double AverageThreeScores(double score1, double score2, double score3) => (score1 + score2 + score3) / 3;

    /*
     * We use the keyword 'override' define a new implementation of a virtual, abstract or override method
     * from the base class. We cannot override static or non virtual methods.
     */
    public override string ToString()
    {
      StringBuilder sb = new StringBuilder();
      sb.AppendLine(this.Name);
      sb.AppendLine(this.Address); ;
      sb.AppendLine(this.City);
      sb.AppendLine(", ");
      sb.AppendLine(this.State);
      sb.AppendLine("  ");
      sb.AppendLine(this.Zip);

      return sb.ToString();
    }
  }
}


