using Microsoft.VisualStudio.TestTools.UnitTesting;
using Myclasses;

namespace MyclassesTest1
{
  [TestClass]
  public class UnitTest1
  {
    [TestMethod]
    public void FileNameDoes()
    {
      FileProcess fp = new FileProcess();
      bool fromCall;
      fromCall = fp.Fileexists(@"C: \Users\johnm\Desktop\Program.cs");

      //assert
      Assert.IsTrue(fromCall);
     
    }
  }
}
