using System;
using System.IO;

namespace Myclasses
{
  public class Fileprocess
  {
    public bool Fileexists(string fileName)
    {
      if (string.IsNullOrEmpty(fileName))
      {
        throw new
          ArgumentNullException("fileName");
      }
      return File.Exists(fileName);
    }
  }
}
