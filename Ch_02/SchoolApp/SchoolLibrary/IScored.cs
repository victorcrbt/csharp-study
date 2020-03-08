using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
  /**
   * A interface define a contract that a class will adhere.
   * It can't contain implementation like an abstract class,
   * but we can implement multiple interfaces to a class whereas 
   * we can only inherit from one class.
   * 
   * Interfaces can only containt methods, properties, indexers and events.
   * 
   * Interfaces are automatically public and can't have access modifiers.
   * Also cannot have any static members.
   */
  public interface IScored
  {
    /**
     *  This is not permitted, because interfaces doesn't allow fields.
     *  We have to explicitly say that it's and a propertie by adding
     *  the getters and setters. It can be achieved with and auto property
     *  as well.
     *  
     *  ************
     *  float Score;
     */
    float Score { get; set; }
    float MaximumScore { get; set; }

    
  }
}
