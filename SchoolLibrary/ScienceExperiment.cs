using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
  /**
   * To implement an interface we do like a class inhertance.
   * Put a colon and the name of the interface.
   * 
   * It's possible to mix inheritance with interface implementation
   * just by adding a comma between them. Add more interfaces works
   * the same way.
   */
  public class ScienceExperiment : IScored
  {
    public string Hypothesis;
    public string Materials;
    public string Method;
    public string Conclusion;

    // Since the interface doesn't allow fields, implementation must have getters and setters.
    public float Score { get; set; }
    public float MaximumScore { get; set; }
  }
}
