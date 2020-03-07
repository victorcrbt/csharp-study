using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary 
{
  class School 
  {
    string Name { get; set; } // This is called an auto property. Basically defines getter and setter for that property automatically.
    string Address { get; set; }
    string City { get; set; }
    string State { get; set; }
    string Zip { get; set; }
    string PhoneNumber { get; set; }

    string _twitterAddress;
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
