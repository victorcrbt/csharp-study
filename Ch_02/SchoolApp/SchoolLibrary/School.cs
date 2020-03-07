using System;

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
  }
}

